using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Kupac
    {
        int ID_Kupac;
        string Ime;
        string Prezime;
        string Adresa;
        int Telefon;
        string Email;

        public int ID_Kupac1 { get => ID_Kupac; set => ID_Kupac = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public string Adresa1 { get => Adresa; set => Adresa = value; }
        public int Telefon1 { get => Telefon; set => Telefon = value; }
        public string Email1 { get => Email; set => Email = value; }

        public Kupac(int iD_Kupac, string ime, string prezime, string adresa, int telefon, string email)
        {
          
           
        }
        public Kupac() { }

        public override string ToString()
        {
            return $"{Ime1} {Prezime1}";
        }



    }
}
