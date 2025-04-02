using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class StavkaRacuna
    {
        int kolicina;
        float cijena;

        public StavkaRacuna(int kolicina, float cijena)
        {
            this.Kolicina = kolicina;
            this.Cijena = cijena;
        }

        public int Kolicina { get => kolicina; set => kolicina = value; }
        public float Cijena { get => cijena; set => cijena = value; }
    }
}
