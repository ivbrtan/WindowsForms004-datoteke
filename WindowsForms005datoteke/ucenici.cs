using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms005datoteke
{
    public class ucenik
    {
        
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string Razred { get; set; }
            public string Uspjeh { get; set; }

            public override string ToString()
            {
                return Ime + " " + Prezime + " " + Razred + " " + Uspjeh;
            }
       
    }
}

