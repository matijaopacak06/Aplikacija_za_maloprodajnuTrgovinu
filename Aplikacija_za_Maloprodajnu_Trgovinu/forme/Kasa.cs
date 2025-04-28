using Aplikacija_za_Maloprodajnu_Trgovinu.klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Aplikacija_za_Maloprodajnu_Trgovinu.forme
{
    public partial class Kasa : Form
    {

        private string proizvodiXml = "Proizvodi.xml"; // put do xml-a s proizovdima
        private string kupciXml = "Kupci.xml"; // put do xml-a s kupcima

        //Lista koja ce pohraniti podatke o proizvodima
        private List<Tuple<string, string, string, decimal, int>> //Tuple sadrži podatke
            proizvodi = new List<Tuple<string, string, string, decimal, int>>();
        public Kasa()
        {
            InitializeComponent();

            // Povezujemo event handler s promjenom odabrane kategorije
            comboBoxKategorija.SelectedIndexChanged += comboBoxKategorija_SelectedIndexChanged;
            UcitajKategorije();
            UcitajKupce();
           
        }

        private void UcitajKategorije()
        {
            
       


            XDocument doc = XDocument.Load(proizvodiXml); // Dohvaćamo sve proizvode iz XML-a
            var kategorije = doc.Descendants("Proizvod")
                              .Select(p => p.Element("Kategorija")?.Value)
                              .Distinct()
                              .ToList();
            comboBoxKategorija.Items.Clear();
            comboBoxKategorija.Items.AddRange(kategorije.ToArray());



        }

        

        private void UcitajKupce()
        {
            if (!File.Exists(kupciXml)) return;


            XDocument doc = XDocument.Load(kupciXml);
            cmbBoxKupci.Items.Clear();
           

            foreach(XElement kupac in doc.Descendants("Kupac"))
            {
                Kupac noviKupac = new Kupac()



                {

                    ID_Kupac1 = int.Parse(kupac.Attribute("ID_Kupac")?.Value),
                    Ime1 = kupac.Element("Ime")?.Value,
                    Prezime1 = kupac.Element("Prezime")?.Value,
                    Adresa1 = kupac.Element("Adresa")?.Value,
                    Telefon1 = int.Parse(kupac.Element("Telefon")?.Value),
                    Email1 = kupac.Element("Email")?.Value
               
                };

                cmbBoxKupci.Items.Add(noviKupac);
            }

        }




        private void btnDodajProizvoda_Click(object sender, EventArgs e)
        {
            if (!(cmbBoxKupci.SelectedItem is Kupac odabraniKupac))

            {
                MessageBox.Show("Molimo odaberite kupca!");
                return;
            }

            string kupac = odabraniKupac.ID_Kupac1.ToString();
            string kategorija = comboBoxKategorija.SelectedItem?.ToString();
            string nazivproizvoda = cmbBoxNazivProizvoda.SelectedItem?.ToString();
            int kolicina = (int)numericUpDownKolicina.Value;

            if (string.IsNullOrEmpty(kategorija) || string.IsNullOrEmpty(nazivproizvoda))
            {
                MessageBox.Show("Molimo odaberite proizvod i kategoriju.");
                return;
            }
            XDocument doc = XDocument.Load(proizvodiXml); //Učitavanje XML-dokumenta

            decimal cijena = 0;

            // Pretraživanje proizvoda u XML datoteci
            var proizvodXml = doc.Descendants("Proizvod")
                .FirstOrDefault(x => (x.Element("Naziv")?.Value ?? "").Trim() == nazivproizvoda.Trim());

            if (proizvodXml != null)
            {
                decimal.TryParse(proizvodXml.Element("Cijena")?.Value, System.Globalization.NumberStyles.Any, 
                    System.Globalization.CultureInfo.InvariantCulture, out cijena);
                
            }
            else
            {
                MessageBox.Show($"Proizvod '{nazivproizvoda}' nije pronađen u XML datoteci.", "Upozorenje", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }

            
            // Provjeri i ažuriraj količinu
            int trenutnaKolicina = int.Parse(proizvodXml.Element("Količina")?.Value ?? "0");

            if (trenutnaKolicina < kolicina)
            {
                MessageBox.Show("Nema dovoljno proizvoda na skladištu!", "Greška", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int novaKolicina = trenutnaKolicina - kolicina;
            proizvodXml.Element("Količina").Value = novaKolicina.ToString();

            // Spremi promjene u XML
            doc.Save(proizvodiXml);






            proizvodi.Add(new Tuple<string, string, string, decimal, int>(
                kupac, kategorija, nazivproizvoda, cijena, kolicina));

            RacunForma racunForma = new RacunForma(proizvodi);
            racunForma.Show();









        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabranaKategorija = comboBoxKategorija.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(odabranaKategorija)) return;

            XDocument doc = XDocument.Load("Proizvodi.xml");

            // Filtriraj proizvode prema kategoriji
            var proizvodi = doc.Descendants("Proizvod")
                .Where(p => p.Element("Kategorija")?.Value == odabranaKategorija)
                .Select(p => p.Element("Naziv")?.Value)
                .Where(naziv => !string.IsNullOrEmpty(naziv))
                .ToList();

            cmbBoxNazivProizvoda.Items.Clear();
            cmbBoxNazivProizvoda.Items.AddRange(proizvodi.ToArray());
        }




        private void Pocetna_Load(object sender, EventArgs e)
        {
           

        }

       
    }
}
