using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu
{
    internal class Zaposlenik
    {
        int ID_Zaposlenik;
        int ime;
        int prezime;
        int pozicija;
        int broj_telefona;

        public Zaposlenik(int iD_Zaposlenik, int ime, int prezime, int pozicija, int broj_telefona)
        {
            ID_Zaposlenik1 = iD_Zaposlenik;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Pozicija = pozicija;
            this.Broj_telefona = broj_telefona;
        }

        public int ID_Zaposlenik1 { get => ID_Zaposlenik; set => ID_Zaposlenik = value; }
        public int Ime { get => ime; set => ime = value; }
        public int Prezime { get => prezime; set => prezime = value; }
        public int Pozicija { get => pozicija; set => pozicija = value; }
        public int Broj_telefona { get => broj_telefona; set => broj_telefona = value; }
    }
}
