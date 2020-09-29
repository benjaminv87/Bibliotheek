using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoekenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> categories = new List<string>() { "Boeken", "Auteurs", "Genres", "Uitgeverij" };
            cbCategorie.DataSource = categories;
            updateLB(cbCategorie.SelectedItem as string) ;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var selectedBookID = (int)lbBoeken.SelectedValue;
            FormBoekenInfo checkInfo = new FormBoekenInfo();
            checkInfo.MijnBoekID= selectedBookID;
            checkInfo.ShowDialog();
          
        }

        public void updateLB(string categorie)
        {
            switch (categorie)
            {
                case "Boeken":
                    using (BoekenEntities ctx = new BoekenEntities())
                    {
                        var queryBoeken = ctx.Boeken.Select(b => new { b.Id, b.Titel }).ToList();
                        lbBoeken.DataSource = queryBoeken;
                        lbBoeken.DisplayMember = "Titel";
                        lbBoeken.ValueMember = "Id";
                    }
                    break;
                case "Auteurs":
                    using (BoekenEntities ctx = new BoekenEntities())
                    {
                        var queryAuteurs = ctx.Auteurs.Select(a => new { naam = a.Voornaam + " " + a.Achternaam, a.Id }).ToList();
                        lbBoeken.DataSource = queryAuteurs;
                        lbBoeken.DisplayMember = "naam";
                        lbBoeken.ValueMember = "Id";
                    }
                    break;
                case "Genres":
                    using (BoekenEntities ctx = new BoekenEntities())
                    {
                        var genresQuery = ctx.Genres.Select(g => g).ToList();
                        lbBoeken.DataSource = genresQuery;
                        lbBoeken.DisplayMember = "Genre";
                        lbBoeken.ValueMember = "Id";

                    }
                    break;
                case "Uitgeverij":
                    using (BoekenEntities ctx = new BoekenEntities())
                    {
                        var uitgeverijQuery = ctx.Uitgeverijen.Select(g => g).ToList();
                        lbBoeken.DataSource = uitgeverijQuery;
                        lbBoeken.DisplayMember = "Naam";
                        lbBoeken.ValueMember = "Id";
                    }
                    break;
                default:
                    break;
            }

        }

        private void btnBoekToevoegen_Click(object sender, EventArgs e)
        {
            NewBoek formNewBoek = new NewBoek();
            if (formNewBoek.ShowDialog() == DialogResult.OK)
            {
                Boeken newBoek = formNewBoek.nieuwBoek;
                using (BoekenEntities ctx = new BoekenEntities())
                {
                    ctx.Boeken.Add(newBoek);
                    ctx.SaveChanges();
                }
                MessageBox.Show($"{newBoek.Titel} toegevoegd.");
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLB(cbCategorie.SelectedItem as string);

        }
    }
}
