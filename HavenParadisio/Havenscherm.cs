using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavenParadisio
{
    public partial class Havenscherm : Form
    {
        // Fields
        private Haven haven;

        Schip schip = new Schip("test", 3, "lpg");

        // Constructor
        public Havenscherm()
        {
            InitializeComponent();

            

            haven = new Haven("Paradisio");
            lblNaamVanDeHaven.Text = haven.Naam;

            haven.BoekEenSchipIn("Stella", 134, null);
            haven.BoekEenSchipIn("Claudia", 110, null);
            haven.BoekEenSchipIn("Snoekgracht", 135, null);
            haven.BoekEenSchipIn("Statendam", 230, null);
            VerversScherm();
        }



        // Methods
        private void VerversScherm()
        {
        }

        private void btnInboeken_Click(object sender, EventArgs e)
        {
            string naam = txtNaamInboeken.Text;
            if (string.IsNullOrEmpty(naam))
            {
                MessageBox.Show("Je dient een naam op te geven.");
                return;
            }

            string nummer = txtLengteInboeken.Text;
            if (string.IsNullOrEmpty(nummer))
            {
                MessageBox.Show("Je hebt geen nummer ingevuld");
                return;
            }
            int num;
            if (!int.TryParse(nummer, out num))
            {
                MessageBox.Show("Geef een geldige waarde voor nummer");
                return;
            }

            string lading = txtLadingInboeken.Text;
            if (string.IsNullOrEmpty(lading))
            {
                MessageBox.Show("Je dient een naam op te geven.");
                return;
            }

            bool gelukt = haven.BoekEenSchipIn(naam, num, lading );

            if(gelukt)
            {
                MessageBox.Show("Inboeken gelukt");
            }

            if (!gelukt)
            {
                MessageBox.Show("Er is al een schip met die naam.");
                return;
            }

            liAlleSchepen.Items.Clear();
            txtNaamInboeken.Clear();
            txtLengteInboeken.Clear();
            txtLadingInboeken.Clear();

            List<Schip> alleArtikelen = haven.GeefAlleArtikelen();

            foreach (Schip huidigeArtikel in alleArtikelen)
            {
                string Schipnaam = huidigeArtikel.Naam;
                int Schiplengte = huidigeArtikel.Lengte;
                string Schiplading = huidigeArtikel.Lading;
                string tekst = Schipnaam + " " + Schiplengte + " " + Schiplading;
                liAlleSchepen.Items.Add(tekst);
            }            
        }

        private void btnUitboeken_Click(object sender, EventArgs e)
        {
            liAlleSchepen.Items.Remove(txtNaamUitboeken.Text == Name);
            //liAlleSchepen.Items.Remove(txtNaamUitboeken.Text);
             string naam = txtNaamUitboeken.Text;
             if (string.IsNullOrEmpty(naam))
             {
                 MessageBox.Show("Je dient een naam op te geven.");
                 return;
             }

             Schip gevondenSchip = haven.GeefSchip(naam);

             if(gevondenSchip == null)
             {
                 MessageBox.Show("Voer een juiste naam van schip in");
             }
            // else
            // {
                 haven.BoekEenSchipUit(naam);
           
                liAlleSchepen.Items.Remove(txtNaamUitboeken.Text);
            
                
            //liAlleSchepen.Items.Remove(liAlleSchepen.SelectedItem);                                 
            //liAlleSchepen.Items.Remove(liAlleSchepen);
            txtNaamUitboeken.Clear();

            // }            
        }

        private void btnStatistiek_Click(object sender, EventArgs e)
        {
            string info =  haven.GeefStatistiek();
            MessageBox.Show("Statistiek " + "\n" + "Aantal schepen in de haven " + info);
        }

        private void pnlStatus_Paint(object sender, PaintEventArgs e)
        {
            int aantal = haven.Schepen.Count; 
            int number = 5;
            if (aantal <= number)
            {
                Graphics g = e.Graphics;
                int breedte = 50;
                int hoogte = 50;
                g.FillEllipse(Brushes.Green, 10, 10, breedte, hoogte);
            }
            else
            {
                Graphics gr = e.Graphics;
                using (Pen p = new Pen(Color.Red, 5))
                {
                    gr.DrawLine(p, 0, 0, 50, 50);
                    gr.DrawLine(p, 0, 50, 50, 0);
                }
            }

        }
    }
    }

