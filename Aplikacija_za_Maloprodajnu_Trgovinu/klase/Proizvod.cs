using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Proizvod
    {
        int ID_Proizvod;
        string Naziv;
        string Opis;
        float Cijena;
        string Kategorija;
        string Jedinica_mjere;

        public Proizvod(int iD_Proizvod, string naziv, string opis, float cijena, string kategorija, string jedinica_mjere)
        {
            ID_Proizvod1 = iD_Proizvod;
            Naziv1 = naziv;
            Opis1 = opis;
            Cijena1 = cijena;
            Kategorija1 = kategorija;
            Jedinica_mjere1 = jedinica_mjere;
        }

        public int ID_Proizvod1 { get => ID_Proizvod; set => ID_Proizvod = value; }
        public string Naziv1 { get => Naziv; set => Naziv = value; }
        public string Opis1 { get => Opis; set => Opis = value; }
        public float Cijena1 { get => Cijena; set => Cijena = value; }
        public string Kategorija1 { get => Kategorija; set => Kategorija = value; }
        public string Jedinica_mjere1 { get => Jedinica_mjere; set => Jedinica_mjere = value; }
    }
}
