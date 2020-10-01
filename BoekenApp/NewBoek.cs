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

        public Boeken nieuwBoek = new Boeken();
        private void NewBoek_Load(object sender, EventArgs e)
        {
            updateListBoxAuteur();
            updateListBoxGenre();
            updateComboBoxUitgeverij();
        }

        //EventHandlers
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

                foreach (var item in lbGenres.SelectedItems)
                {
                    ctx.BoekenGenres.Add(new BoekenGenres() { BoekId = nieuwBoek.Id, GenreId = (item as Genres).Id });
                }

                foreach (var item in lbAuteurs.SelectedItems)
                {
                    ctx.BoekenAuteurs.Add(new BoekenAuteurs() { BoekId = nieuwBoek.Id, AuteurId = (item as ListItem).Id });
                }
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUitgeverijToevoegen_Click(object sender, EventArgs e)
        {
            NewUitgeverij newUitgeverijForm = new NewUitgeverij();
            if (newUitgeverijForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"{newUitgeverijForm.nieuweUitgeverij.Naam} toegevoegd");
                updateComboBoxUitgeverij();
                cbUitgeverij.Text = newUitgeverijForm.nieuweUitgeverij.Naam;
            }

        }

        private void btnNieuweAuteur_Click(object sender, EventArgs e)
        {
            NewAuteur newAuteurForm = new NewAuteur();
            if (newAuteurForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"{newAuteurForm.nieuweAuteur.Voornaam} {newAuteurForm.nieuweAuteur.Achternaam} toegevoegd ");
                updateListBoxAuteur();
            }

        }

        private void btnNieuwGenre_Click(object sender, EventArgs e)
        {
            newGenre newGenreForm = new newGenre();
            if (newGenreForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"{newGenreForm.nieuwGenre.Genre} Toegevoegd.");
                updateListBoxGenre();

            }
        }

        //UPDATE BOXES

        private void updateListBoxAuteur()
        {

            using (BoekenEntities ctx = new BoekenEntities())
            {
                var auteurQuery = ctx.Auteurs.Select(a => new ListItem() { Id = a.Id, Naam = (a.Voornaam + " " + a.Achternaam) }).ToList();
                lbAuteurs.DisplayMember = "Naam";
                lbAuteurs.ValueMember = "Id";
                lbAuteurs.DataSource = auteurQuery;


            }
        }

        private void updateListBoxGenre()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var genresQuery = ctx.Genres.Select(g => g).ToList();
                lbGenres.DisplayMember = "Genre";
                lbGenres.ValueMember = "Id";
                lbGenres.DataSource = genresQuery;
            }
        }

        private void updateComboBoxUitgeverij()
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                var uitgeverijQuery = ctx.Uitgeverijen.Select(g => g).ToList();
                cbUitgeverij.DisplayMember = "Naam";
                cbUitgeverij.ValueMember = "Id";
                cbUitgeverij.DataSource = uitgeverijQuery;
            }
        }

        internal class ListItem
        {
            public ListItem()
            {
            }

            public int Id { get; set; }
            public string Naam { get; set; }
        }


    }
}


