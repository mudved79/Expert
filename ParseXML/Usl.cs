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
    class Usl
    {
        public long UslID { get; set; }
        public long SluchID { get; set; }
        public string IDSERV { get; set; }
        public string LPU { get; set; }
        public string LPU_1 { get; set; }
        public int PODR { get; set; }
        public int UCHASTOK { get; set; }
        public int PUNKT { get; set; }
        public int PROFIL { get; set; }
        public string VID_VME { get; set; }
        public int DET { get; set; }
        public DateTime DATE_IN { get; set; }
        public DateTime DATE_OUT { get; set; }
        public int P_OTK { get; set; }
        string DS;
        public string DS1
        {
            get { return DS; }
            set
            {
                DS = value;
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
        public string CODE_USL { get; set; }
        public double KOL_USL { get; set; }
        public double TARIF { get; set; }
        public double SUMV_USL { get; set; }
        public int PRVS { get; set; }
        public string CODE_MD { get; set; }
        public int NPL { get; set; }
        public int DENTAL_F { get; set; }
        public string DENT_SURFACE { get; set; }
        public string COMENTU { get; set; }

        public long InserToSQL(SqlConnection pSqlConn,Schet schet,Sluch sluch)
        {
            if (this.UslID == 0)
            {
                string sqlExp = @"insert into EXP_UO_EX (EXP_SCHET_EX_ID,EXP_RE_EX_ID,NSH,DSH,RE,G1,KOL_USL,TARIF,SUM_USL,DATE_IN,DATE_OUT,COMMENTU,VID_VME,
V002_ID,K16,K51,DS,V015_CODE,CODE_MD,OT,G13,G14,G16,DENTAL_F,DENT_SURFACE,CODE_USL,P_OTK,NPL,MCOD_LPU) 
values(@EXP_SCHET_EX_ID,@EXP_RE_EX_ID,@NSH,@DSH,@RE,@G1,@KOL_USL,@TARIF,@SUM_USL,@DATE_IN,@DATE_OUT,@COMMENTU,@VID_VME,
@V002_ID,@K16,@K51,@DS,@V015_CODE,@CODE_MD,@OT,@G13,@G14,@G16,@DENTAL_F,@DENT_SURFACE,@CODE_USL,@P_OTK,@NPL,@MCOD_LPU) 
select @@IDENTITY as uID";
                SqlCommand command = new SqlCommand(sqlExp, pSqlConn);
                command.Parameters.Add("@EXP_SCHET_EX_ID", SqlDbType.BigInt).Value = schet.SchetID;
                command.Parameters.Add("@EXP_RE_EX_ID", SqlDbType.BigInt).Value = sluch.SluchID;
                command.Parameters.Add("@NSH", SqlDbType.Char).Value = schet.Nschet;
                command.Parameters.Add("@DSH", SqlDbType.DateTime).Value = schet.Dschet;
                command.Parameters.Add("@RE", SqlDbType.Int).Value = sluch.N_zap;
                command.Parameters.Add("@G1", SqlDbType.Int).Value = sluch.Idcase;
                command.Parameters.Add("@KOL_USL", SqlDbType.Decimal).Value = this.KOL_USL;
                command.Parameters.Add("@TARIF", SqlDbType.Decimal).Value = this.TARIF;
                command.Parameters.Add("@SUM_USL", SqlDbType.Decimal).Value = this.SUMV_USL;
                command.Parameters.Add("@DATE_IN", SqlDbType.DateTime).Value = this.DATE_IN;
                command.Parameters.Add("@DATE_OUT", SqlDbType.DateTime).Value = this.DATE_OUT;
                command.Parameters.Add("@COMMENTU", SqlDbType.NVarChar).Value = this.COMENTU ?? (object)DBNull.Value;
                command.Parameters.Add("@VID_VME", SqlDbType.Char).Value = this.VID_VME ?? (object)DBNull.Value;
                command.Parameters.Add("@V002_ID", SqlDbType.Int).Value = this.PROFIL == 0 ? (object)DBNull.Value: this.PROFIL;
                command.Parameters.Add("@K16", SqlDbType.NChar).Value = this.Mkb1 ?? (object)DBNull.Value;
                command.Parameters.Add("@K51", SqlDbType.NChar).Value = this.Mku1 ?? (object)DBNull.Value;
                command.Parameters.Add("@DS", SqlDbType.NChar).Value = this.DS1 ?? (object)DBNull.Value;
                command.Parameters.Add("@V015_CODE", SqlDbType.Int).Value = this.PRVS;
                command.Parameters.Add("@CODE_MD", SqlDbType.Char).Value = this.CODE_MD;
                command.Parameters.Add("@OT", SqlDbType.Decimal).Value = this.PODR;
                command.Parameters.Add("@G13", SqlDbType.Decimal).Value = this.KOL_USL;
                command.Parameters.Add("@G14", SqlDbType.Decimal).Value = this.TARIF;
                command.Parameters.Add("@G16", SqlDbType.Decimal).Value = this.SUMV_USL;
                command.Parameters.Add("@DENTAL_F", SqlDbType.Decimal).Value = this.DENTAL_F == 0 ? (object)DBNull.Value: this.DENTAL_F;
                command.Parameters.Add("@DENT_SURFACE", SqlDbType.NChar).Value = this.DENT_SURFACE ?? (object)DBNull.Value;
                command.Parameters.Add("@CODE_USL", SqlDbType.NChar).Value = this.CODE_USL ?? (object)DBNull.Value;
                command.Parameters.Add("@P_OTK", SqlDbType.Int).Value = this.P_OTK == 0 ? (object)DBNull.Value : this.P_OTK;
                command.Parameters.Add("@NPL", SqlDbType.Int).Value = this.NPL == 0 ? (object)DBNull.Value : this.NPL;
                command.Parameters.Add("@MCOD_LPU", SqlDbType.NVarChar).Value = this.LPU ?? (object)DBNull.Value;



                this.UslID = Convert.ToInt64(((decimal)command.ExecuteScalar()));
                return this.UslID;

            }
            else
            {
                MessageBox.Show($"Услуга {this.UslID} \n уже имеет ID запрос не выполнен");
                return this.UslID;
            }

            return UslID;
        }
    }
}
