using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Drzava
    {
        string NazivDrzave;
        string PostanskiBroj;

        public Drzava(string nazivDrzave, string postanskiBroj)
        {
            NazivDrzave1 = nazivDrzave;
            PostanskiBroj1 = postanskiBroj;
        }

        public string NazivDrzave1 { get => NazivDrzave; set => NazivDrzave = value; }
        public string PostanskiBroj1 { get => PostanskiBroj; set => PostanskiBroj = value; }
    }
}
