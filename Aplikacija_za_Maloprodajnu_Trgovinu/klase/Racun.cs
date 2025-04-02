using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Racun
    {
        int ID_Racun;
       DateTime datum;

        public Racun(int iD_Racun, DateTime datum)
        {
            ID_Racun1 = iD_Racun;
            this.Datum = datum;
        }

        public int ID_Racun1 { get => ID_Racun; set => ID_Racun = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
