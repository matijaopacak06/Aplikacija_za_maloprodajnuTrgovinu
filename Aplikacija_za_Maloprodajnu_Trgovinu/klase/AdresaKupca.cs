using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class AdresaKupca
    {
        int ID_AdresaKupca;
        string Ulica;
        string KucniBroj;

        public AdresaKupca(int iD_AdresaKupca, string ulica, string kucniBroj)
        {
            ID_AdresaKupca1 = iD_AdresaKupca;
            Ulica1 = ulica;
            KucniBroj1 = kucniBroj;
        }

        public int ID_AdresaKupca1 { get => ID_AdresaKupca; set => ID_AdresaKupca = value; }
        public string Ulica1 { get => Ulica; set => Ulica = value; }
        public string KucniBroj1 { get => KucniBroj; set => KucniBroj = value; }
    }
}
