using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXML
{
    class Person
    {
       public string Id_pac { get; set; }
       public string Fam { get; set; }
       public string Im { get; set; }
       public string Ot { get; set; }
       public int W { get; set; }
       public DateTime Dr { get; set; }
       public string Tel { get; set; }
       public string Fam_p { get; set; }
       public string Im_p { get; set; }
       public string Ot_p { get; set; }
       public int W_p { get; set; }
       public DateTime Dr_p { get; set; }
       public string Mr { get; set; }
       public int Doctype { get; set; }
       public string Docser { get; set; }
       public string Docnum { get; set; }
       public string Snils { get; set; }
       public string Okatog { get; set; }
       public string Okatop { get; set; }
       public string Fh { get; set; }
       public string Adr { get; set; }
       public int Kat_lg { get; set; }
       public string Commentp { get; set; }
       public Person()
        {
            Id_pac = null;
            Fam = null;
            Im = null;
            Ot = null;
            W = 0;
            Dr = DateTime.MinValue;
            Tel = null;
            Fam_p = null;
            Im_p = null;
            Ot_p = null;
            W_p = 0;
            Dr_p = DateTime.MinValue;
            Mr = null;
            Doctype = 0;
            Docser = null;
            Docnum = null;
            Snils = null;
            Okatog = null;
            Okatop = null;
            Fh = null;
            Kat_lg = 0;
            Commentp = null;
            Adr = null;
        }
        public override string ToString()
        {
            return $"{this.Id_pac} {this.Fam} {this.Im} {this.Ot} {this.Dr} {this.Adr}";
        }


    }
}
