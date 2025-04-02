using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class AdresaDobavljaca
    {
        int ID_AdresaDobavljaca;
        string KucniBroj;
        string Ulica;

        public AdresaDobavljaca(int iD_AdresaDobavljaca, string kucniBroj, string ulica)
        {
            ID_AdresaDobavljaca1 = iD_AdresaDobavljaca;
            KucniBroj1 = kucniBroj;
            Ulica1 = ulica;
        }

        public int ID_AdresaDobavljaca1 { get => ID_AdresaDobavljaca; set => ID_AdresaDobavljaca = value; }
        public string KucniBroj1 { get => KucniBroj; set => KucniBroj = value; }
        public string Ulica1 { get => Ulica; set => Ulica = value; }
    }
}
