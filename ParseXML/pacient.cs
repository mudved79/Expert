using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXML
{
    class Pacient
    {
        public Person Pers { get; set; }
        public string Id_pac { get; set; }
        public int Vpolis { get; set; }
        public string Spolis { get; set; }
        public string Npolis { get; set; }
        public string St_okato { get; set; }
        public string Smo { get; set; }
        public string Smo_ogrn { get; set; }
        public string Smo_ok { get; set; }
        public string Smo_nam { get; set; }
        public int Inv { get; set; }
        public int Mse { get; set; }
        public string Novor { get; set; }
        public int Vnov_d { get; set; }
        public  Pacient()
        {
            Pers = null;
            Id_pac = null;
            Vpolis = 0;
            Spolis = null;
            Npolis = null;
            St_okato = null;
            Smo = null;
            Smo_ogrn = null;
            Smo_ok = null;
            Smo_nam = null;
            Inv = 0;
            Mse = 0;
            Novor = null;
            Vnov_d = 0;
        }

    }
}
