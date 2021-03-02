using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ParseXML
{
    class Schet
    {
        public long SchetID { get; set; }
        public string Nschet { get; set; }
        public DateTime Dschet { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string Code_mo { get; set; }
        public string Plat { get; set; }
        public double Sumav { get; set; }
        public string Nsh_um { get; set; }

        public Schet()
        {
            SchetID = 0;
            Nschet = null;
            Dschet = DateTime.MinValue;
            Year = 0;
            Month = 0;
            Code_mo = null;
            Plat = null;
            Sumav = 0;
            Nsh_um = null;
        }
        public Schet(long id, string ns,DateTime ds,int ye,int mn,string cm,string pl,double sum)
        {
            SchetID = id;
            Nschet = ns;
            Dschet = ds;
            Year = ye;
            Month = mn;
            Code_mo = cm;
            Plat = pl;
            Sumav = sum;
            Nsh_um = $"{(mn.ToString()+" ").Substring(0,2)}.{ye.ToString()}";
        }

        public static string Right(string str, int length)
        { return str.Substring(str.Length - length, length); }
        public override string ToString()
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = " ";
            return $"{SchetID}\n{Nschet}\t{Dschet.ToString()}\n{Sumav.ToString("N",nfi)}\n{Year}\t{Month}\n{Nsh_um}";
        }
        /// <summary>
        /// отправляет счет на сервер в таблицу EXP_SCHET_EX
        /// </summary>
        /// <returns>id счета в таблице после записи</returns>
        public  long InsertToSQL(SqlConnection pSqlConn)
        {
            long sID;

            if (this.SchetID == 0)
            {
                string sqlExp = @"insert into EXP_SCHET_EX (NSH,DSH,[YEAR],[MONTH],NSH_UM,MCOD_SMO,MCOD_LPU,SUMS,DISMEN) 
                                                     values(@nsh,@dsh,@year,@month,@nsh_um,@mcod_smo,@mcod_lpu,@sums,@dismen) select @@IDENTITY as ShID";
                SqlCommand command = new SqlCommand(sqlExp, pSqlConn);

                command.Parameters.Add("@nsh", SqlDbType.Char).Value = this.Nschet;
                command.Parameters.Add("@dsh", SqlDbType.DateTime).Value = this.Dschet;
                command.Parameters.Add("@year", SqlDbType.Int).Value = this.Year;
                command.Parameters.Add("@month", SqlDbType.Int).Value = this.Month;
                command.Parameters.Add("@nsh_um", SqlDbType.NVarChar).Value = this.Nsh_um;
                command.Parameters.Add("@mcod_smo", SqlDbType.Int).Value = this.Plat;
                command.Parameters.Add("@mcod_lpu", SqlDbType.Int).Value = this.Code_mo;
                command.Parameters.Add("@sums", SqlDbType.Decimal).Value = this.Sumav;
                command.Parameters.Add("@dismen", SqlDbType.DateTime).Value = DateTime.Now;

                sID = Convert.ToInt64(((decimal) command.ExecuteScalar()));
                this.SchetID = sID;
                return sID;
                //reader.Close();
            }
            else
            {
                MessageBox.Show($"Счет {this.ToString()} \n уже имеет ID запрос не выполнен");
                sID = this.SchetID;
                return sID;
            }


        }
    }

}
