using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Dobavljac
    {
        int ID_Dobavljac;
        string Naziv;
        int telefon;

        public Dobavljac(int iD_Dobavljac, string naziv, int telefon)
        {
            ID_Dobavljac1 = iD_Dobavljac;
            Naziv1 = naziv;
            this.Telefon = telefon;
        }

        public int ID_Dobavljac1 { get => ID_Dobavljac; set => ID_Dobavljac = value; }
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public int Telefon { get => telefon; set => telefon = value; }
    }
}
