using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.klase
{
    internal class Zaliha
    {
        int ID_Zaliha;
        int Kolicina;

        public Zaliha(int iD_Zaliha, int kolicina)
        {
            ID_Zaliha1 = iD_Zaliha;
            Kolicina1 = kolicina;
        }

        public int ID_Zaliha1 { get => ID_Zaliha; set => ID_Zaliha = value; }
        public int Kolicina1 { get => Kolicina; set => Kolicina = value; }
    }
}
