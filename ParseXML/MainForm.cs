using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO.Compression;
using System.IO;
using System.Xml.Linq;
using System.Globalization;
using System.Xml;
using System.Threading;

namespace ParseXML
{
    public partial class MainForm : Form
    {
        SqlConnection sqlConn;
        Thread treadParse;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //LoginForm LoginForm1 = new LoginForm();
            //LoginForm1.ShowDialog(this);
            tsFname.Text = "";
           
            string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConn = new SqlConnection(ConnectionString);
            try
            {
                sqlConn.Open();
                toolStripSqlLabel.Text = sqlConn.DataSource.ToString();
                toolStripDBLabel.Text  = sqlConn.Database.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripSqlLabel.Text = "";
                toolStripDBLabel.Text = "";
            }
        }
        private void ToolStripMenuItemConnect_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm1 = new LoginForm();
            LoginForm1.ShowDialog(this);
            string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            sqlConn = new SqlConnection(ConnectionString);
            try
            {
                sqlConn.Open();
                toolStripSqlLabel.Text = sqlConn.DataSource.ToString();
                toolStripDBLabel.Text = sqlConn.Database.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                toolStripSqlLabel.Text = "";
                toolStripDBLabel.Text = "";
            }
        }
        public bool ThreadCheck (Thread t)
        {
            if (t == null)
                return false;
            else
            {
                if (t.IsAlive)
                {
                    MessageBox.Show(this, $"Выполняется загрузка!\nНевозможно завершить программу");
                    return true;
                }
                else return false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ThreadCheck(treadParse))
                return;
            else
            {
                if (sqlConn != null && sqlConn.State != ConnectionState.Closed)
                {
                    //MessageBox.Show(sqlConn.DataSource.ToString() + " из меню");
                    sqlConn.Close();
                }
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (ThreadCheck(treadParse))
            //    return;
            //else
            //{
                if (sqlConn != null && sqlConn.State != ConnectionState.Closed)
                {
                    //MessageBox.Show(sqlConn.DataSource.ToString()+" по кнопке");
                    sqlConn.Close();
                }
                //this.Close();
            //}
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
        public string ReadXMLElementString(XElement XElem,string NameTag)
        {
            string Res;
            if (XElem.Elements(NameTag.ToUpper()).Count() > 0)
                Res = XElem.Element(NameTag.ToUpper()).Value;
            else
                Res = null;
            return Res;
        }
        public int ReadXMLElementInt(XElement XElem, string NameTag)
        {
            int Res;
            if (XElem.Elements(NameTag.ToUpper()).Count() > 0)
                Res = int.Parse(XElem.Element(NameTag.ToUpper()).Value);
            else
                Res = 0;
            return Res;
        }
        public DateTime ReadXMLElementDate(XElement XElem, string NameTag)
        {
            DateTime Res;
            if (XElem.Elements(NameTag.ToUpper()).Count() > 0)
                Res = DateTime.ParseExact(XElem.Element(NameTag.ToUpper()).Value, "yyyy-MM-dd", null);
            else
                Res = DateTime.MinValue;
            return Res;
        }
        public double ReadXMLElementDouble(XElement XElem, string NameTag)
        {
            //??
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            double Res;
            if (XElem.Elements(NameTag.ToUpper()).Count() > 0)
                Res = Convert.ToDouble(XElem.Element(NameTag.ToUpper()).Value, nfi);
            else
                Res = 0;
            return Res;
        }
        /// <summary>
        /// загрузка из xml в базу
        /// </summary>
        /// <param name="ePath">путь к распакованным файлам</param>
        public void LoadToDB(string ePath)
        {
            string lcfname = Path.GetFileNameWithoutExtension(ePath);
            string lcHMfname = $"HM{lcfname}.xml";
            string lcLMfname = $"LM{lcfname}.xml";
            //MessageBox.Show($"{ePath}\\{lcHMfname}\n{ePath}\\{lcLMfname}");

            XDocument HMfname = XDocument.Load($"{ePath}\\{lcHMfname}");
            //XmlDocument HMfname = new XmlDocument();
            //HMfname.Load($"{ePath}\\{lcHMfname}");
            int SluchCount = (from xe in HMfname.Root.Descendants("SLUCH") select xe).Count();

            Invoke(new Action(() => MainPBar.Maximum = SluchCount));

            XDocument LMfname = XDocument.Load($"{ePath}\\{lcLMfname}");
            // получаем счет из файла

            Schet schet = new Schet();
            Pacient pac = new Pacient();
            Person p = new Person();
            
            foreach (XElement SE in HMfname.Element("ZL_LIST").Elements("SCHET"))
            {
                string ns = ReadXMLElementString(SE,"NSCHET");
                DateTime ds = ReadXMLElementDate(SE, "DSCHET");
                int ye = ReadXMLElementInt(SE, "YEAR");
                int mn = ReadXMLElementInt(SE, "MONTH");
                string cm = ReadXMLElementString(SE, "CODE_MO");
                string pl = ReadXMLElementString(SE, "PLAT");
                double sum = ReadXMLElementDouble(SE, "SUMMAV");
                
                schet = new Schet(0, ns, ds, ye, mn, cm, pl, sum);
                schet.SchetID =schet.InsertToSQL(sqlConn);
            }
            // получаем ZAP из файла
            foreach (XElement ZAP in HMfname.Element("ZL_LIST").Elements("ZAP"))
            {
                int n_zap = ReadXMLElementInt(ZAP, "N_ZAP") ;//O
                int pr_nov = ReadXMLElementInt(ZAP, "PR_NOV");//O
                string nschet_p = ReadXMLElementString(ZAP, "NSCHET_P"); 
                DateTime dschet_p = ReadXMLElementDate(ZAP, "DSCHET_P");
                int n_zap_p = ReadXMLElementInt(ZAP, "N_ZAP_P"); 
                 
                foreach (XElement PACIENT in ZAP.Elements("PACIENT"))
                {
                    // вычитываем инфо пациента

                    pac.Id_pac = ReadXMLElementString(PACIENT, "ID_PAC");
                    pac.Vpolis = ReadXMLElementInt(PACIENT, "VPOLIS");
                    pac.Spolis = ReadXMLElementString(PACIENT, "SPOLIS");
                    pac.Npolis = ReadXMLElementString(PACIENT, "NPOLIS");
                    pac.St_okato = ReadXMLElementString(PACIENT, "ST_ОКАТО");
                    pac.Smo = ReadXMLElementString(PACIENT, "SMO");
                    pac.Smo_ogrn = ReadXMLElementString(PACIENT, "SMO_OGRN");
                    pac.Smo_ok = ReadXMLElementString(PACIENT, "SMO_OK"); 
                    pac.Smo_nam = ReadXMLElementString(PACIENT, "SMO_NAM");
                    pac.Inv = ReadXMLElementInt(PACIENT, "INV");
                    pac.Mse = ReadXMLElementInt(PACIENT, "MSE");
                    pac.Novor = ReadXMLElementString(PACIENT, "NOVOR");                  
                    pac.Vnov_d = ReadXMLElementInt(PACIENT, "VNOV_D");

                    //выколупываем из L-файла ФИО и тд.
                     var Pers = from pers in LMfname.Element("PERS_LIST").Elements("PERS")
                                where (string)pers.Element("ID_PAC") == pac.Id_pac
                                select pers;
                    // читае инфо пациента
                    foreach (XElement xEle in Pers)
                    {
                        p.Id_pac = ReadXMLElementString(xEle, "ID_PAC"); 
                        p.Fam = ReadXMLElementString(xEle, "FAM");
                        p.Im = ReadXMLElementString(xEle, "IM");
                        p.Ot = ReadXMLElementString(xEle, "OT");
                        p.W = ReadXMLElementInt(xEle, "W");
                        p.Dr = ReadXMLElementDate(xEle, "DR");
                        p.Tel = ReadXMLElementString(xEle, "TEL");
                        p.Fam_p = ReadXMLElementString(xEle, "FAM_P");
                        p.Im_p = ReadXMLElementString(xEle, "FAM_P"); 
                        p.Ot_p = ReadXMLElementString(xEle, "OT_P");
                        p.W_p = ReadXMLElementInt(xEle, "W_P");
                        p.Dr_p = ReadXMLElementDate(xEle, "DR_P");
                        p.Mr = ReadXMLElementString(xEle, "MR");
                        p.Doctype = ReadXMLElementInt(xEle, "DOCTYPE");
                        p.Docser = ReadXMLElementString(xEle, "DOCSER");
                        p.Docnum = ReadXMLElementString(xEle, "DOCNUM");
                        p.Snils = ReadXMLElementString(xEle, "SNILS");
                        p.Okatog = ReadXMLElementString(xEle, "OKATOG");
                        p.Okatop = ReadXMLElementString(xEle, "OKATOP");
                        p.Fh = ReadXMLElementString(xEle, "FH");
                        p.Kat_lg = ReadXMLElementInt(xEle, "KAT_LG");
                        p.Commentp = ReadXMLElementString(xEle, "COMENTP");
                        p.Adr = ReadXMLElementString(xEle, "ADR"); 

                        pac.Pers = p;
                    }


                    //var items = from xe in LMfname.Element("PERS_LIST").Elements("PERS")
                    //            where (xe.Element("ID_PAC").Value == id_pac)
                    //            select new Person
                    //            {
                    //                Id_pac = xe.Element("ID_PAC").Value,
                    //                Fam = xe.Element("FAM").Value,
                    //                Im = xe.Element("IM").Value,
                    //                Ot =  xe.Element("OT").Value ,
                    //                Dr = DateTime.ParseExact(xe.Element("DR").Value, "yyyy-MM-dd", null)

                    //            };
                    //foreach (var item in items)
                    //{
                    //    //MessageBox.Show($"{item.ToString()}");
                    //    //MessageBox.Show($"{item.Fam} {item.Im} {item.Ot}");
                    //}


                }
                // вычитываем инфо по законченному случаю
                foreach (XElement Z_SL in ZAP.Elements("Z_SL"))
                {
                    Z_sl z = new Z_sl();
                    z.Pac = pac;
                    z.Z_sl_id = ReadXMLElementInt(Z_SL, "Z_SL_ID");
                    z.Istochik_opl = ReadXMLElementInt(Z_SL, "ISTOCHIK_OPL");
                    z.Usl_ok = ReadXMLElementInt(Z_SL, "USL_OK");
                    z.Vidpom = ReadXMLElementInt(Z_SL, "VIDPOM");
                    z.For_pom = ReadXMLElementInt(Z_SL, "FOR_POM");
                    z.Lpu = ReadXMLElementString(Z_SL, "LPU");
                    z.Npr_mo = ReadXMLElementString(Z_SL, "NPR_MO");
                    z.Np = ReadXMLElementString(Z_SL, "NP");
                    z.Npr_date = ReadXMLElementDate(Z_SL, "NPR_DATE");
                    z.Np_iddokt = ReadXMLElementString(Z_SL, "NP_IDDOKT");
                    z.Date_z_1 = ReadXMLElementDate(Z_SL, "DATE_Z_1");
                    z.Date_z_2 = ReadXMLElementDate(Z_SL, "DATE_Z_2");
                    z.Kd_z = ReadXMLElementInt(Z_SL, "KD_Z");
                    z.Vnov_m = ReadXMLElementInt(Z_SL, "VNOV_M");
                    z.Rslt = ReadXMLElementInt(Z_SL, "RSLT");
                    z.Ishod = ReadXMLElementInt(Z_SL, "ISHOD");
                    z.Os_sluch = ReadXMLElementInt(Z_SL, "OS_SLUCH");
                    z.Vb_p = ReadXMLElementInt(Z_SL, "VB_P");
                    z.Idsp = ReadXMLElementInt(Z_SL, "IDSP");
                    z.Sum_z = ReadXMLElementDouble(Z_SL, "SUMV_Z");
                    z.Oplata = ReadXMLElementInt(Z_SL, "OPLATA");
                    z.Vbr = ReadXMLElementInt(Z_SL, "VBR");
                    z.Rslt_d = ReadXMLElementInt(Z_SL, "RSLT_D");
                    z.P_otk = ReadXMLElementInt(Z_SL, "P_OTK");

                    z.InsertToSQL(sqlConn, pac, schet);
                    // перебираем случаи
                    foreach (XElement SLUCH in Z_SL.Elements("SLUCH"))
                    {
                        Sluch s = new Sluch();
                        // вычитываем случай лечения
                        s.N_zap = n_zap;
                        s.Idcase = ReadXMLElementInt(SLUCH, "IDCASE");
                        s.Caseguid = ReadXMLElementString(SLUCH, "CASEGUID");
                        s.Vid_hmp = ReadXMLElementString(SLUCH, "VID_HMP");
                        s.Metod_hmp = ReadXMLElementInt(SLUCH, "METOD_HMP");
                        s.Disp = ReadXMLElementString(SLUCH, "Disp");
                        s.Lpu_1 = ReadXMLElementString(SLUCH, "Lpu_1");
                        s.Podr = ReadXMLElementInt(SLUCH, "Podr");
                        s.Uchastok = ReadXMLElementInt(SLUCH, "Uchastok");
                        s.Punkt = ReadXMLElementInt(SLUCH, "Punkt");
                        s.Profil = ReadXMLElementInt(SLUCH, "Profil");
                        s.Profil_k = ReadXMLElementInt(SLUCH, "Profil_k");
                        s.Det = ReadXMLElementInt(SLUCH, "Det");
                        s.Tal_d = ReadXMLElementDate(SLUCH, "Tal_d");
                        s.Tal_num = ReadXMLElementString(SLUCH, "Tal_num");
                        s.Tal_p = ReadXMLElementDate(SLUCH, "Tal_p");
                        s.Nhistory = ReadXMLElementString(SLUCH, "Nhistory");
                        s.Obr = ReadXMLElementString(SLUCH, "Obr");
                        s.P_per = ReadXMLElementInt(SLUCH, "P_per");
                        s.Date_1 = ReadXMLElementDate(SLUCH, "Date_1");
                        s.Date_2 = ReadXMLElementDate(SLUCH, "Date_2");
                        s.Kd = ReadXMLElementInt(SLUCH, "Kd");
                        s.Ds0 = ReadXMLElementString(SLUCH, "Ds0");
                        s.Ds1 = ReadXMLElementString(SLUCH, "Ds1");
                        s.Ds1_pr = ReadXMLElementInt(SLUCH, "Ds1_pr");
                        s.Ds1_dn = ReadXMLElementInt(SLUCH, "Ds1_dn");
                        s.C_zab = ReadXMLElementInt(SLUCH, "C_zab");
                        s.Ds_onk = ReadXMLElementInt(SLUCH, "Ds_onk");
                        s.Code_mes1 = ReadXMLElementString(SLUCH, "Code_mes1");
                        s.Code_mes2 = ReadXMLElementString(SLUCH, "Code_mes2");
                        s.Reab = ReadXMLElementInt(SLUCH, "Reab"); 
                        s.Prvs = ReadXMLElementInt(SLUCH, "Prvs");
                        s.Iddokt = ReadXMLElementString(SLUCH, "Iddokt");
                        s.Ed_col = ReadXMLElementDouble(SLUCH, "Ed_col");
                        s.Tarif = ReadXMLElementDouble(SLUCH, "Tarif");
                        s.Sumv = ReadXMLElementDouble(SLUCH, "Sumv");
                        s.Sump = ReadXMLElementDouble(SLUCH, "Sump");
                        s.Idcase_p = ReadXMLElementInt(SLUCH, "Idcase_p");
                        s.CodeRefusal = ReadXMLElementInt(SLUCH, "CodeRefusal");
                        s.Comentsl = ReadXMLElementString(SLUCH, "Comentsl");
                        s.Pr_nov = pr_nov;
                        switch (z.For_pom)
                        {
                            case 1:
                                s.PR3 = "*";
                                break;
                            default:
                                s.PR3 = null;
                                break;
                        }
                        s.InsertToSQL(sqlConn, pac, schet, z);
                        // перебираем услуги
                        foreach (XElement USL in SLUCH.Elements("USL"))
                        {
                            Usl u = new Usl();
                            // вычитываем услуги по случаю
                            u.IDSERV = ReadXMLElementString(USL, "IDSERV");
                            u.LPU = ReadXMLElementString(USL, "LPU");
                            u.LPU_1= ReadXMLElementString(USL, "LPU_1");
                            u.PODR = ReadXMLElementInt(USL, "PODR");
                            u.UCHASTOK = ReadXMLElementInt(USL, "UCHASTOK");
                            u.PUNKT = ReadXMLElementInt(USL, "PUNKT");
                            u.PROFIL = ReadXMLElementInt(USL, "PROFIL");
                            u.VID_VME = ReadXMLElementString(USL, "VID_VME");
                            u.DET = ReadXMLElementInt(USL, "PROFIL");
                            u.DATE_IN = ReadXMLElementDate(USL, "DATE_IN");
                            u.DATE_OUT = ReadXMLElementDate(USL, "DATE_OUT");
                            u.P_OTK = ReadXMLElementInt(USL, "P_OTK");
                            u.DS1 = ReadXMLElementString(USL, "DS");
                            u.CODE_USL = ReadXMLElementString(USL, "CODE_USL");
                            u.KOL_USL = ReadXMLElementDouble(USL, "KOL_USL");
                            u.TARIF = ReadXMLElementDouble(USL, "TARIF");
                            u.SUMV_USL = ReadXMLElementDouble(USL, "SUMV_USL");
                            u.PRVS = ReadXMLElementInt(USL, "PRVS");
                            u.CODE_MD = ReadXMLElementString(USL, "CODE_MD");
                            u.NPL = ReadXMLElementInt(USL, "NPL");
                            u.DENTAL_F = ReadXMLElementInt(USL, "DENTAL_F");
                            u.DENT_SURFACE = ReadXMLElementString(USL, "DENT_SURFACE");
                            u.COMENTU = ReadXMLElementString(USL, "COMENTU");
                            u.InserToSQL(sqlConn, schet,s);
                        }

                        Invoke(new Action(() => MainPBar.Value +=1));
                    }
                }

                }

            
            HMfname = null;
            LMfname = null;
            Invoke(new Action(() => MainPBar.Value = 0));
        }

        public void UnzipFilesXmlToTmp()
        {

            string path = null;
            string[] saBillList;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            string startupPath = Environment.CurrentDirectory;
            //Invoke(new Action(() => MessageBox.Show(this, $"{startupPath}")));
            dialog.SelectedPath = startupPath+"\\tmp";
            

            // в метод
            if (dialog.ShowDialog() == DialogResult.OK)
                {
                    path = dialog.SelectedPath;
                    saBillList = Directory.GetFiles(path, "*.zip");
                    Invoke(new Action(() => MessageBox.Show(this, $"Найдено {saBillList.Length} файлов для загрузки")));
                }
                else
                {
                    Invoke(new Action(() => MessageBox.Show(this, "Каталог не выбран")));
                    return;
                }
            // перебираем файлы 
            for (int i = 0; i < saBillList.Length; i++)
            {
                // создаем каталог в тмп для каждой пары файлов
                FileInfo fileInf = new FileInfo(saBillList[i]);
                if (fileInf.Exists)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo($"{path}\\extract\\{fileInf.Name}");
                    // переделать
                    if (dirInfo.Exists)
                        { dirInfo.Delete(true); }
                    
                    // создаем каталог
                    dirInfo.Create();
                    // распаковываем архив
                    Invoke(new Action(() => tsFname.Text =$"загружается счет №{i+1}: {fileInf.Name}"));
                    string zipPath = fileInf.FullName;
                    string extractPath = $"{path}\\extract\\{fileInf.Name}";
                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                    // обработка файлов 
                    Invoke(new Action(() => MainPBar.Value = 0));
                    LoadToDB(extractPath);
                    //MessageBox.Show($"{path}\\extract\\{fileInf.Name}");
                    //удаляем каталог
                    dirInfo.Delete(true);
                    //tsFname.Text = "";
                    Invoke(new Action(() => tsFname.Text = ""));


                }
            }
            Invoke(new Action(() => MessageBox.Show(this, "Завершено")));
        }
        
        private void ToolStripMenuItemAppReestr_Click(object sender, EventArgs e)
        {

            treadParse = new Thread(UnzipFilesXmlToTmp);
            treadParse.SetApartmentState(ApartmentState.STA);
            treadParse.Start();
            //UnzipFilesXmlToTmp();
            
        }
    }
}
