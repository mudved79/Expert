using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseXML
{
    class Z_sl
    {
        public Pacient Pac { get; set; }

        public long Exp_z_sl_id { get; set; }
        public int Z_sl_id { get; set; }
        public int Istochik_opl { get; set; }
        int usl_ok;
        public int Usl_ok
        {
            get { return usl_ok; }
            set
            {
                usl_ok = value;
                // перекодировка в старый код характера лечения
                switch (value)
                {
                    case 1:
                        this.Xl = 2;
                        break;
                    case 2:
                        this.Xl = 8;
                        break;
                    case 3:
                        this.Xl = 1;
                        break;
                    case 4:
                        this.Xl = 10;
                        break;
                    default:
                        this.Xl = 0;
                        break;
                }
            }
        }
        public int Xl { get; set; }
        public int Vidpom { get; set; }
        public int For_pom { get; set; }
        public string Lpu { get; set; }
        public string Npr_mo { get; set; }
        public string Np { get; set; }
        public DateTime Npr_date { get; set; }
        public string Np_iddokt { get; set; }
        public DateTime Date_z_1 { get; set; }
        public DateTime Date_z_2 { get; set; }
        public int Kd_z { get; set; }
        public int Vnov_m { get; set; }
        public int Rslt { get; set; }
        public int Ishod { get; set; }
        public int Os_sluch { get; set; }
        public int Vb_p { get; set; }
        public int Idsp { get; set; }
        public double Sum_z { get; set; }
        public int Oplata { get; set; }
        public double Sum_z_tfoms { get; set; } //??
        public int Vbr { get; set; }
        public int Rslt_d { get; set; }
        public int P_otk { get; set; }

        public Z_sl()
        {
            Pac = null;
            Exp_z_sl_id = 0;
            Z_sl_id = 0;
            Istochik_opl = 0;
            Usl_ok = 0;
            Xl = 0;
            Vidpom = 0;
            For_pom = 0;
            Lpu = null;
            Npr_mo = null;
            Np = null;
            Npr_date = DateTime.MinValue;
            Np_iddokt = null;
            Date_z_1 = DateTime.MinValue;
            Date_z_2 = DateTime.MinValue;
            Kd_z = 0;
            Vnov_m = 0;
            Rslt = 0;
            Ishod = 0;
            Os_sluch = 0;
            Vb_p = 0;
            Idsp = 0;
            Sum_z = 0;
            Oplata = 0;
            Sum_z_tfoms = 0;
            Vbr = 0;
            Rslt_d = 0;
            P_otk = 0;
    }

        public long InsertToSQL(SqlConnection pSqlConn, Pacient p, Schet s)
        {
            long zID;
            if (this.Exp_z_sl_id == 0)
            {
                string sqlExp = @"insert into EXP_Z_SL (EXP_SCHET_EX_ID,Z_SL_ID,ISTOCHIK_OPL,USL_OK,VID_POM,FOR_POM,LPU,NPR_MO,NP,NPR_DATE,NP_IDDOKT,
                                                        DATE_Z1,DATE_Z2,KD_Z,VNOV_M,RSLT,ISHOD,OS_SLUCH,VB_P,IDSP,SUMV_Z,OPLATA,VBR,RSLT_D,P_OTK) 
                                                        values(@EXP_SCHET_EX_ID,@Z_SL_ID,@ISTOCHIK_OPL,@USL_OK,@VID_POM,@FOR_POM,@LPU,@NPR_MO,@NP,@NPR_DATE,@NP_IDDOKT,
                                                        @DATE_Z1,@DATE_Z2,@KD_Z,@VNOV_M,@RSLT,@ISHOD,@OS_SLUCH,@VB_P,@IDSP,@SUMV_Z,@OPLATA,@VBR,@RSLT_D,@P_OTK) 
                                                        select @@IDENTITY as zsID";
                SqlCommand command = new SqlCommand(sqlExp, pSqlConn);

                

                SqlParameter EXP_SCHET_EX_ID = new SqlParameter("@EXP_SCHET_EX_ID", s.SchetID);
                command.Parameters.Add(EXP_SCHET_EX_ID);
                SqlParameter Z_SL_ID = new SqlParameter("@Z_SL_ID", this.Z_sl_id);
                command.Parameters.Add(Z_SL_ID);
                SqlParameter ISTOCHIK_OPL = new SqlParameter("@ISTOCHIK_OPL", this.Istochik_opl);
                command.Parameters.Add(ISTOCHIK_OPL);
                SqlParameter USL_OK = new SqlParameter("@USL_OK", this.Usl_ok);
                command.Parameters.Add(USL_OK);
                SqlParameter VID_POM = new SqlParameter("@VID_POM", this.Vidpom);
                command.Parameters.Add(VID_POM);
                SqlParameter FOR_POM = new SqlParameter("@FOR_POM", this.For_pom);
                command.Parameters.Add(FOR_POM);
                SqlParameter LPU = new SqlParameter("@LPU", this.Lpu);
                command.Parameters.Add(LPU);
                SqlParameter NPR_MO = new SqlParameter("@NPR_MO", this.Npr_mo ?? (object)DBNull.Value);
                command.Parameters.Add(NPR_MO);
                SqlParameter NP = new SqlParameter("@NP", this.Np ?? (object)DBNull.Value);
                command.Parameters.Add(NP);
                SqlParameter NPR_DATE = new SqlParameter("@NPR_DATE", this.Npr_date == DateTime.MinValue ? (object)DBNull.Value : this.Npr_date);
                command.Parameters.Add(NPR_DATE);
                SqlParameter NP_IDDOKT = new SqlParameter("@NP_IDDOKT", this.Np_iddokt == null ? (object)DBNull.Value : this.Np_iddokt);
                command.Parameters.Add(NP_IDDOKT);
                SqlParameter DATE_Z1 = new SqlParameter("@DATE_Z1", this.Date_z_1 == DateTime.MinValue ? (object)DBNull.Value: this.Date_z_1);
                command.Parameters.Add(DATE_Z1);
                SqlParameter DATE_Z2 = new SqlParameter("@DATE_Z2", this.Date_z_2 == DateTime.MinValue ? (object)DBNull.Value : this.Date_z_2);
                command.Parameters.Add(DATE_Z2);
                SqlParameter KD_Z = new SqlParameter("@KD_Z", this.Kd_z==0 ? (object)DBNull.Value : this.Kd_z);
                command.Parameters.Add(KD_Z);
                SqlParameter VNOV_M = new SqlParameter("@VNOV_M", this.Vnov_m == 0 ? (object)DBNull.Value : this.Vnov_m);
                command.Parameters.Add(VNOV_M);
                SqlParameter RSLT = new SqlParameter("@RSLT", this.Rslt);
                command.Parameters.Add(RSLT);
                SqlParameter ISHOD = new SqlParameter("@ISHOD", this.Ishod);
                command.Parameters.Add(ISHOD);
                SqlParameter OS_SLUCH = new SqlParameter("@OS_SLUCH", this.Os_sluch == 0 ? (object)DBNull.Value : this.Os_sluch);
                command.Parameters.Add(OS_SLUCH);
                SqlParameter VB_P = new SqlParameter("@VB_P", this.Vb_p == 0 ? (object)DBNull.Value: this.Vb_p);
                command.Parameters.Add(VB_P);
                SqlParameter IDSP = new SqlParameter("@IDSP", this.Idsp == 0 ? (object)DBNull.Value: this.Idsp);
                command.Parameters.Add(IDSP);
                SqlParameter SUMV_Z = new SqlParameter("@SUMV_Z", this.Sum_z == 0 ? (object)DBNull.Value : this.Sum_z);
                command.Parameters.Add(SUMV_Z);
                SqlParameter OPLATA = new SqlParameter("@OPLATA", this.Oplata);
                command.Parameters.Add(OPLATA);
                SqlParameter VBR = new SqlParameter("@VBR", this.Vbr == 0 ? (object)DBNull.Value : this.Vbr);
                command.Parameters.Add(VBR);
                SqlParameter RSLT_D = new SqlParameter("@RSLT_D", this.Rslt_d == 0 ? (object)DBNull.Value : this.Rslt_d);
                command.Parameters.Add(RSLT_D);
                SqlParameter P_OTK = new SqlParameter("@P_OTK", this.P_otk == 0 ? (object)DBNull.Value : this.P_otk);
                command.Parameters.Add(P_OTK);

                zID = Convert.ToInt64(((decimal)command.ExecuteScalar()));
                this.Exp_z_sl_id = zID;
                return zID;
            }
            else
            {
                MessageBox.Show($"Законченный случай {this.ToString()} \n уже имеет ID запрос не выполнен");
                zID = this.Exp_z_sl_id;
                return zID;
            }
        }

    }
}
