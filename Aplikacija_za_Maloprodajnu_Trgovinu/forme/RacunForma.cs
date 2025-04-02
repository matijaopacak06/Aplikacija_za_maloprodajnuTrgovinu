using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class RacunForma : Form
    {
        private List<Tuple<string, string, string, decimal, int>> proizvodi;

        public RacunForma(List<Tuple<string, string, string, decimal, int>> proizvodi)

        {
            InitializeComponent();
            this.proizvodi = proizvodi;
            UcitajProizvode(proizvodi);
        }

       

     

        private void UcitajProizvode(List<Tuple<string, string, string, decimal, int>> proizvodi)
        {
            dataGridViewRacun.Rows.Clear();

            foreach (var proizvod in proizvodi)
            {

                string kupac = proizvod.Item1;          // ID ili Ime Prezime
                string kategorija = proizvod.Item2;
                string naziv = proizvod.Item3;
                decimal cijena = proizvod.Item4;
                int kolicina = proizvod.Item5;
                decimal ukupnaCijena = cijena * kolicina;

                dataGridViewRacun.Rows.Add(
                   proizvod.Item1, // ID kupca
               proizvod.Item2, // Kategorija
               proizvod.Item3, // Proizvod
               proizvod.Item4.ToString("0.00"), // Cijena
               proizvod.Item5, // Količina
               ukupnaCijena.ToString("0.00" )   // Ukupna cijena
               );

                


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Racun_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewRacun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
