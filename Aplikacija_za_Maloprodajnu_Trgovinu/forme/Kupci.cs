using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class Kupci : Form
    {
        public Kupci()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string xmlFile = "kupci.xml"; // prikazuje naziv XML datoteke.

            if (!File.Exists(xmlFile))
            {
                MessageBox.Show("XML datoteka ne postoji!" , "Greška" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Očistiti će dataGridView prije novog učitavanja
            dataGridViewKupci.Rows.Clear();
            dataGridViewKupci.Columns.Clear();

            //Dodavanje kolone u dataGridView i njihove vrijednosti
            dataGridViewKupci.Columns.Add("ID_Kupac", "ID_Kupca");
            dataGridViewKupci.Columns.Add("Ime", "Ime");
            dataGridViewKupci.Columns.Add("Prezime", "Prezime");
            dataGridViewKupci.Columns.Add("Adresa", "Adresa");
            dataGridViewKupci.Columns.Add("Telefon", "Telefon");
            dataGridViewKupci.Columns.Add("Email", "Email");

            //Učitavanje XML dokumenta
            XDocument document = XDocument.Load(xmlFile);

            foreach (XElement kupac in document.Descendants("Kupac")) // Prolazenje kroz XML-elemnta <Kupac> i unutar njega <Kupci>
            {
                dataGridViewKupci.Rows.Add(
                    //Uzimaju se vrijednosti atributa
                    kupac.Attribute("ID_Kupac")?.Value, 
                    kupac.Element("Ime")?.Value,
                    kupac.Element("Prezime")?.Value,
                    kupac.Element("Adresa")?.Value,
                    kupac.Element("Telefon")?.Value,
                    kupac.Element("Email")?.Value
                );
            }


        }
    }
}
