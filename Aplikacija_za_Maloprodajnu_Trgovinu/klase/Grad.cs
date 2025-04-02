using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Grad
    {
        string Postanski_Broj;
        string NazivGrada;

        public Grad(string postanski_Broj, string nazivGrada)
        {
            Postanski_Broj1 = postanski_Broj;
            NazivGrada1 = nazivGrada;
        }

        public string Postanski_Broj1 { get => Postanski_Broj; set => Postanski_Broj = value; }
        public string NazivGrada1 { get => NazivGrada; set => NazivGrada = value; }
    }
}
