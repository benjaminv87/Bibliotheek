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
    public partial class NewBoek : Form
    {
        public NewBoek()
        {
            InitializeComponent();
        }

        public Boeken nieuwBoek;
        public List<BoekenAuteurs> nieuwBoekenAuteurs = new List<BoekenAuteurs>();
        private void NewBoek_Load(object sender, EventArgs e)
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var auteurQuery = ctx.Auteurs.Select(a => new Test() { Id = a.Id, Naam = a.Voornaam + " " + a.Achternaam }).ToList(); /*{Id = a.Id, Naam = a.Voornaam + " " + a.Achternaam }).ToList()*/;
                lbAuteurs.DisplayMember = "Naam";
                lbAuteurs.ValueMember = "Id";
                lbAuteurs.DataSource = auteurQuery;
                var genresQuery = ctx.Genres.Select(g => g).ToList();
                lbGenres.DisplayMember = "Genre";
                lbGenres.ValueMember = "Id";
                lbGenres.DataSource = genresQuery;
                var uitgeverijQuery = ctx.Uitgeverijen.Select(g => g).ToList();
                cbUitgeverij.DisplayMember = "Naam";
                cbUitgeverij.ValueMember = "Id";
                cbUitgeverij.DataSource = uitgeverijQuery;

            }
        }

        private void btnBoekToevoegen_Click(object sender, EventArgs e)
        {
            Boeken nieuwBoek = new Boeken();
            nieuwBoek.Titel = tbTitel.Text;
            nieuwBoek.AantalPaginas = (int)numAantalPaginas.Value;
            nieuwBoek.Score = (int)numScore.Value;
            nieuwBoek.UitgeverId = (int)cbUitgeverij.SelectedValue;
            nieuwBoek.Publicatie = dtPublicatieDatum.Value;

            using (BoekenEntities ctx = new BoekenEntities())
            {
                ctx.Boeken.Add(nieuwBoek);
                ctx.SaveChanges();

                //ctx.BoekenGenres.Add(new BoekenGenres { BoekId = 1, GenreId = 1 });

                foreach (var genre in lbGenres.SelectedItems)
                {
                    ctx.BoekenGenres.Add(new BoekenGenres() { BoekId = nieuwBoek.Id, GenreId = (genre as Genres).Id });

                }

                foreach (var item in lbAuteurs.SelectedItems)
                {
                    ctx.BoekenAuteurs.Add(new BoekenAuteurs() { BoekId = nieuwBoek.Id, AuteurId = (item as Test).Id });

                }
            }
        }




        private class Test
        {
            public int Id { get; set; }
            public string Naam { get; set; }

            public Test()
            {
            }
        }
    }

}
