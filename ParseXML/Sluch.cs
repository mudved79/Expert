using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseXML
{
    class Sluch
    {
        public long SluchID { get; set; }
        public int Idcase { get; set; }
        public string Caseguid { get; set; }
        public string Vid_hmp { get; set; }
        public int Metod_hmp { get; set; }
        public string Disp { get; set; }
        public string Lpu_1 { get; set; }
        public int Podr { get; set; }
        public int Uchastok { get; set; }
        public int Punkt { get; set; }
        public int Profil { get; set; }
        public int Profil_k { get; set; }
        public int Det { get; set; }
        public DateTime Tal_d { get; set; }
        public string Tal_num { get; set; }
        public DateTime Tal_p { get; set; }
        public string Nhistory { get; set; }
        public string Obr { get; set; }
        public int P_per { get; set; }
        public DateTime Date_1 { get; set; }
        public DateTime Date_2 { get; set; }
        public int Kd { get; set; }
        public string Ds0 { get; set; }
        string ds1;
        public string Ds1
        {
            get { return ds1; }
            set
            {
                ds1 = value;
                // разбить на части, диагноз и уточнение для старой проги
                if (value == null)
                { Mkb1 = null; Mku1 = null; }
                else
                {
                    this.Mkb1 = value.Substring(0, 3);
                    if (value.Length > 4) this.Mku1 = value.Substring(4, 1);
                }
            }
        }
        public string Mkb1 { get; set; }
        public string Mku1 { get; set; }
        public int Ds1_pr { get; set; }
        public int Ds1_dn { get; set; }
        public int C_zab { get; set; }
        public int Ds_onk { get; set; }
        public string Code_mes1 { get; set; }
        public string Code_mes2 { get; set; }
        public int Reab { get; set; }
        public int Prvs { get; set; }
        public string Iddokt { get; set; }
        public double Ed_col { get; set; }
        public double Tarif { get; set; }
        public double Sumv { get; set; }
        public double Sump { get; set; }
        public int Idcase_p { get; set; }
        public int CodeRefusal { get; set; }
        public string Comentsl { get; set; }
        public int N_zap { get; set; }
        public string PR3 { get; set; }
        public string Ksg { get; set; }
        public int Pr_nov { get; set; }
        public Sluch()
        {
            SluchID = 0;
            Idcase = 0;
            Caseguid = null;
            Vid_hmp = null;
            Metod_hmp = 0;
            Disp = null;
            Lpu_1 = null;
            Podr = 0;
            Uchastok = 0;
            Punkt = 0;
            Profil = 0;
            Profil_k = 0;
            Det = 0;
            Tal_d = DateTime.MinValue;
            Tal_num = null;
            Tal_p = DateTime.MinValue;
            Nhistory = null;
            Obr = null;
            P_per = 0;
            Date_1 = DateTime.MinValue;
            Date_2 = DateTime.MinValue;
            Kd = 0;
            Ds0 = null;
            Ds1 = null;
            Mkb1 = null;
            Mku1 = null;
            Ds1_pr = 0;
            Ds1_dn = 0;
            C_zab = 0;
            Ds_onk = 0;
            Code_mes1 = null;
            Code_mes2 = null;
            Reab = 0;
            Prvs = 0;
            Iddokt = null;
            Ed_col = 0;
            Tarif = 0;
            Sumv = 0;
            Sump = 0;
            Idcase_p = 0;
            CodeRefusal = 0;
            Comentsl = null;
        }
        public long InsertToSQL(SqlConnection pSqlConn, Pacient p, Schet s, Z_sl z)
        {
            long slID;
            if (this.SluchID == 0)
            {
                string sqlExp = @"insert into EXP_RE_EX (EXP_SCHET_EX_ID,EXP_Z_SL_ID,NSH,DSH,RE,G1,POLIS_V,POLIS_S,POLIS_N,XL,MKB1,MKU1,G131,DS1,SN1,PR3,ITOG,FAMIL,IMJA,OTCH,GR,
POL,ADRES,ADR,G9,DNL,DKL,DISMEN,POT,TR,SUM_EX,OBR_S59,PCOD_VR,NSH_UM,OS_SLUCH,COMMENTU,DOCTYPE,DOCSER,DOCNUM,OKATOG,OKATOP,ISHOD,RSLT,VID_HMP,METOD_HMP,
DS0,KSG,V006_ID,V008_ID,V010_ID,V015_CODE,V016_IDDT,V017_IDDR,V014_ID,ISTOCHIK_OPL,UOMP,VIDP,FRMMP,LPU_1,DET,VNOV_M,CODE_MES1,CODE_MES2,
RSLT_D,PRVS,ED_COL,OPLATA,ID_PAC,OT,G151,G141,G161,VBR,UCHASTOK,PUNKT,TAL_D,TAL_P,DIRECT,DELIVER,PR_D_N,INV,MSE,KSG_DK,DS1_PR,PR_NOV,PROFIL_K,TAL_NUM,KD,DS1_DN,Z_SL_ID,DS_ONK,C_ZAB,REAB) 
values(@EXP_SCHET_EX_ID,@EXP_Z_SL_ID,@NSH,@DSH,@RE,@G1,@POLIS_V,@POLIS_S,@POLIS_N,@XL,@MKB1,@MKU1,@G131,@DS1,@SN1,@PR3,@ITOG,@FAMIL,@IMJA,@OTCH,@GR,
@POL,@ADRES,@ADR,@G9,@DNL,@DKL,@DISMEN,@POT,@TR,@SUM_EX,@OBR_S59,@PCOD_VR,@NSH_UM,@OS_SLUCH,@COMMENTU,@DOCTYPE,@DOCSER,@DOCNUM,@OKATOG,@OKATOP,@ISHOD,@RSLT,@VID_HMP,@METOD_HMP,
@DS0,@KSG,@V006_ID,@V008_ID,@V010_ID,@V015_CODE,@V016_IDDT,@V017_IDDR,@V014_ID,@ISTOCHIK_OPL,@UOMP,@VIDP,@FRMMP,@LPU_1,@DET,@VNOV_M,@CODE_MES1,@CODE_MES2,
@RSLT_D,@PRVS,@ED_COL,@OPLATA,@ID_PAC,@OT,@G151,@G141,@G161,@VBR,@UCHASTOK,@PUNKT,@TAL_D,@TAL_P,@DIRECT,@DELIVER,@PR_D_N,@INV,@MSE,@KSG_DK,@DS1_PR,@PR_NOV,@PROFIL_K,@TAL_NUM,@KD,@DS1_DN,@Z_SL_ID,@DS_ONK,@C_ZAB,@REAB) 
select @@IDENTITY as sID";
                SqlCommand command = new SqlCommand(sqlExp, pSqlConn);

                SqlParameter EXP_SCHET_EX_ID = new SqlParameter("@EXP_SCHET_EX_ID", s.SchetID);
                command.Parameters.Add(EXP_SCHET_EX_ID);
                SqlParameter EXP_Z_SL_ID = new SqlParameter("@EXP_Z_SL_ID", z.Exp_z_sl_id);
                command.Parameters.Add(EXP_Z_SL_ID);
                SqlParameter NSH = new SqlParameter("@NSH", s.Nschet);
                command.Parameters.Add(NSH);
                SqlParameter DSH = new SqlParameter("@DSH", s.Dschet);
                command.Parameters.Add(DSH);
                SqlParameter RE = new SqlParameter("@RE", this.N_zap);
                command.Parameters.Add(RE);
                SqlParameter G1 = new SqlParameter("@G1", this.Idcase);
                command.Parameters.Add(G1);
                SqlParameter POLIS_V = new SqlParameter("@POLIS_V",z.Pac.Vpolis);
                command.Parameters.Add(POLIS_V);
                SqlParameter POLIS_S = new SqlParameter("@POLIS_S", z.Pac.Spolis ?? (object)DBNull.Value);
                command.Parameters.Add(POLIS_S);
                SqlParameter POLIS_N = new SqlParameter("@POLIS_N", z.Pac.Npolis);
                command.Parameters.Add(POLIS_N);
                SqlParameter XL = new SqlParameter("@XL", z.Xl);
                command.Parameters.Add(XL);
                SqlParameter MKB1 = new SqlParameter("@MKB1", this.Mkb1);
                command.Parameters.Add(MKB1);
                SqlParameter MKU1 = new SqlParameter("@MKU1", this.Mku1 ?? "");
                command.Parameters.Add(MKU1);
                SqlParameter DS1 = new SqlParameter("@DS1", this.Ds1);
                command.Parameters.Add(DS1);
                SqlParameter G131 = new SqlParameter("@G131", this.Ed_col);
                command.Parameters.Add(G131);
                command.Parameters.Add("@SN1", SqlDbType.Decimal).Value = 0;
                SqlParameter PR3 = new SqlParameter("@PR3", this.PR3 ?? (object)DBNull.Value);
                command.Parameters.Add(PR3);
                SqlParameter ITOG = new SqlParameter("@ITOG", this.Sumv);
                command.Parameters.Add(ITOG);
                SqlParameter FAMIL = new SqlParameter("@FAMIL", z.Pac.Pers.Fam ?? "");
                command.Parameters.Add(FAMIL);
                SqlParameter IMJA = new SqlParameter("@IMJA", z.Pac.Pers.Im ?? "");
                command.Parameters.Add(IMJA);
                SqlParameter OTCH = new SqlParameter("@OTCH", z.Pac.Pers.Ot ?? "");
                command.Parameters.Add(OTCH);
                SqlParameter GR = new SqlParameter("@GR", z.Pac.Pers.Dr);
                command.Parameters.Add(GR);
                SqlParameter POL = new SqlParameter("@POL", z.Pac.Pers.W);
                command.Parameters.Add(POL);
                command.Parameters.Add("@ADRES", SqlDbType.Decimal).Value = 0;
                SqlParameter ADR = new SqlParameter("@ADR", z.Pac.Pers.Adr ?? "");
                command.Parameters.Add(ADR);
                SqlParameter G9 = new SqlParameter("@G9", this.Nhistory);
                command.Parameters.Add(G9);
                SqlParameter DNL = new SqlParameter("@DNL", this.Date_1);
                command.Parameters.Add(DNL);
                SqlParameter DKL = new SqlParameter("@DKL", this.Date_2);
                command.Parameters.Add(DKL);
                SqlParameter DISMEN = new SqlParameter("@DISMEN", DateTime.Now);
                command.Parameters.Add(DISMEN);
                SqlParameter POT = new SqlParameter("@POT", this.Profil);
                command.Parameters.Add(POT);
                SqlParameter TR = new SqlParameter("@TR", this.Tarif);
                command.Parameters.Add(TR);
                SqlParameter SUM_EX = new SqlParameter("@SUM_EX", this.Sump);
                command.Parameters.Add(SUM_EX);
                SqlParameter OBR_S59 = new SqlParameter("@OBR_S59", this.Obr ?? (object)DBNull.Value);
                command.Parameters.Add(OBR_S59);
                SqlParameter PCOD_VR = new SqlParameter("@PCOD_VR", this.Iddokt ?? (object)DBNull.Value);
                command.Parameters.Add(PCOD_VR);
                SqlParameter NSH_UM = new SqlParameter("@NSH_UM",s.Nsh_um);
                command.Parameters.Add(NSH_UM);
                SqlParameter OS_SLUCH = new SqlParameter("@OS_SLUCH", z.Os_sluch == 0 ? (object)DBNull.Value : z.Os_sluch);
                command.Parameters.Add(OS_SLUCH);
                SqlParameter COMMENTU = new SqlParameter("@COMMENTU", this.Comentsl ?? (object)DBNull.Value);
                command.Parameters.Add(COMMENTU);
                SqlParameter DOCTYPE = new SqlParameter("@DOCTYPE", p.Pers.Doctype == 0 ? (object)DBNull.Value : p.Pers.Doctype);
                command.Parameters.Add(DOCTYPE);
                command.Parameters.Add("@DOCSER", SqlDbType.NChar).Value = p.Pers.Docser ?? (object)DBNull.Value;
                command.Parameters.Add("@DOCNUM", SqlDbType.NChar).Value = p.Pers.Docnum ?? (object)DBNull.Value;
                command.Parameters.Add("@OKATOG", SqlDbType.NChar).Value = p.Pers.Okatog ?? (object)DBNull.Value;
                command.Parameters.Add("@OKATOP", SqlDbType.NChar).Value = p.Pers.Okatop ?? (object)DBNull.Value;
                command.Parameters.Add("@ISHOD", SqlDbType.Decimal).Value = z.Ishod == 0 ? (object)DBNull.Value : z.Ishod;
                command.Parameters.Add("@RSLT", SqlDbType.Decimal).Value = z.Rslt == 0 ? (object)DBNull.Value : z.Rslt;
                command.Parameters.Add("@VID_HMP", SqlDbType.NVarChar).Value = this.Vid_hmp ?? (object)DBNull.Value;
                command.Parameters.Add("@METOD_HMP", SqlDbType.Int).Value = this.Metod_hmp == 0 ? (object)DBNull.Value : this.Metod_hmp;
                command.Parameters.Add("@DS0", SqlDbType.NVarChar).Value = this.Ds0 ?? (object)DBNull.Value;
                command.Parameters.Add("@KSG", SqlDbType.NVarChar).Value = this.Ksg ?? (object)DBNull.Value;
                command.Parameters.Add("@V006_ID", SqlDbType.Int).Value = z.Usl_ok == 0 ? (object)DBNull.Value : z.Usl_ok;
                command.Parameters.Add("@V008_ID", SqlDbType.Int).Value = z.Vidpom == 0 ? (object)DBNull.Value : z.Vidpom;
                command.Parameters.Add("@V010_ID", SqlDbType.Int).Value = z.Idsp == 0 ? (object)DBNull.Value : z.Idsp;
                command.Parameters.Add("@V015_CODE", SqlDbType.Int).Value = this.Prvs == 0 ? (object)DBNull.Value : this.Prvs;
                command.Parameters.Add("@V016_IDDT", SqlDbType.NChar).Value = this.Disp ?? (object)DBNull.Value;
                command.Parameters.Add("@V017_IDDR", SqlDbType.Int).Value = z.Rslt_d == 0 ? (object)DBNull.Value : z.Rslt_d;
                command.Parameters.Add("@V014_ID", SqlDbType.Int).Value = z.For_pom == 0 ? (object)DBNull.Value : z.For_pom;
                command.Parameters.Add("@ISTOCHIK_OPL", SqlDbType.Int).Value = z.Istochik_opl == 0 ? (object)DBNull.Value : z.Istochik_opl;
                command.Parameters.Add("@UOMP", SqlDbType.Int).Value = z.Usl_ok == 0 ? (object)DBNull.Value : z.Usl_ok;
                command.Parameters.Add("@VIDP", SqlDbType.Int).Value = z.Vidpom == 0 ? (object)DBNull.Value : z.Vidpom;
                command.Parameters.Add("@FRMMP", SqlDbType.Int).Value = z.For_pom == 0 ? (object)DBNull.Value : z.For_pom;
                command.Parameters.Add("@LPU_1", SqlDbType.NVarChar).Value = this.Lpu_1 ?? (object)DBNull.Value;
                command.Parameters.Add("@DET", SqlDbType.Int).Value = this.Det == 0 ? (object)DBNull.Value : this.Det;
                command.Parameters.Add("@VNOV_M", SqlDbType.Int).Value = z.Vnov_m == 0 ? (object)DBNull.Value : z.Vnov_m;
                command.Parameters.Add("@CODE_MES1", SqlDbType.NChar).Value = this.Code_mes1 ?? (object)DBNull.Value;
                command.Parameters.Add("@CODE_MES2", SqlDbType.NChar).Value = this.Code_mes2 ?? (object)DBNull.Value;
                command.Parameters.Add("@RSLT_D", SqlDbType.Int).Value = z.Rslt_d == 0 ? (object)DBNull.Value : z.Rslt_d;
                command.Parameters.Add("@PRVS", SqlDbType.Int).Value = this.Prvs == 0 ? (object)DBNull.Value : this.Prvs;
                command.Parameters.Add("@ED_COL", SqlDbType.Decimal).Value = this.Ed_col == 0 ? (object)DBNull.Value : this.Ed_col;
                command.Parameters.Add("@OPLATA", SqlDbType.Int).Value = z.Oplata == 0 ? (object)DBNull.Value : z.Oplata;
                command.Parameters.Add("@ID_PAC", SqlDbType.NVarChar).Value = z.Pac.Id_pac ?? (object)DBNull.Value;
                command.Parameters.Add("@OT", SqlDbType.NVarChar).Value = Convert.ToString(this.Podr) ?? (object)DBNull.Value;
                command.Parameters.Add("@G151", SqlDbType.Decimal).Value = 1;
                command.Parameters.Add("@G141", SqlDbType.Decimal).Value = this.Sumv == 0 ? (object)DBNull.Value : this.Sumv;
                command.Parameters.Add("@G161", SqlDbType.Decimal).Value = this.Sumv == 0 ? (object)DBNull.Value : this.Sumv;
                command.Parameters.Add("@VBR", SqlDbType.Int).Value = z.Vbr == 0 ? (object)DBNull.Value : z.Vbr;
                command.Parameters.Add("@UCHASTOK", SqlDbType.Int).Value = this.Uchastok == 0 ? (object)DBNull.Value : this.Uchastok;
                command.Parameters.Add("@PUNKT", SqlDbType.Int).Value = this.Punkt == 0 ? (object)DBNull.Value : this.Punkt;
                command.Parameters.Add("@TAL_D", SqlDbType.DateTime).Value = this.Tal_d == DateTime.MinValue ? (object)DBNull.Value: this.Tal_d;
                command.Parameters.Add("@TAL_P", SqlDbType.DateTime).Value = this.Tal_p == DateTime.MinValue ? (object)DBNull.Value : this.Tal_p;
                command.Parameters.Add("@DIRECT", SqlDbType.Int).Value = z.P_otk == 0 ? (object)DBNull.Value : z.P_otk;
                command.Parameters.Add("@DELIVER", SqlDbType.Int).Value = this.P_per == 0 ? (object)DBNull.Value : this.P_per;
                command.Parameters.Add("@PR_D_N", SqlDbType.Int).Value = this.Ds1_dn == 0 ? (object)DBNull.Value : this.Ds1_dn;
                command.Parameters.Add("@INV", SqlDbType.Int).Value = p.Inv == 0 ? (object)DBNull.Value : p.Inv;
                command.Parameters.Add("@MSE", SqlDbType.Int).Value = p.Mse == 0 ? (object)DBNull.Value : p.Mse;
                command.Parameters.Add("@KSG_DK", SqlDbType.NVarChar).Value = (object)DBNull.Value;
                command.Parameters.Add("@DS1_PR", SqlDbType.Decimal).Value = this.Ds1_pr == 0 ? (object)DBNull.Value : this.Ds1_pr;
                command.Parameters.Add("@PR_NOV", SqlDbType.Bit).Value = Convert.ToBoolean(this.Pr_nov);
                command.Parameters.Add("@PROFIL_K", SqlDbType.Decimal).Value = this.Profil_k == 0 ? (object)DBNull.Value : this.Profil_k;
                command.Parameters.Add("@TAL_NUM", SqlDbType.NVarChar).Value = this.Tal_num ?? (object)DBNull.Value;
                command.Parameters.Add("@KD", SqlDbType.Decimal).Value = this.Kd == 0 ? (object)DBNull.Value : this.Kd;
                command.Parameters.Add("@DS1_DN", SqlDbType.Decimal).Value = this.Ds1_dn == 0 ? (object)DBNull.Value : this.Ds1_dn;
                command.Parameters.Add("@Z_SL_ID", SqlDbType.Int).Value = z.Z_sl_id == 0 ? (object)DBNull.Value : z.Z_sl_id;
                command.Parameters.Add("@DS_ONK", SqlDbType.Int).Value = this.Ds_onk == 0 ? (object)DBNull.Value : this.Ds_onk;
                command.Parameters.Add("@C_ZAB", SqlDbType.Int).Value = this.C_zab == 0 ? (object)DBNull.Value : this.C_zab;
                command.Parameters.Add("@REAB", SqlDbType.Int).Value = this.Reab == 0 ? (object)DBNull.Value : this.Reab;
                
                slID = Convert.ToInt64(((decimal)command.ExecuteScalar()));
                this.SluchID = slID;
                return slID;
            }
            else
            {
                MessageBox.Show($"Случай {this.Idcase} \n уже имеет ID запрос не выполнен");
                slID = this.SluchID;
                return slID;
            }

        }
    }
}
