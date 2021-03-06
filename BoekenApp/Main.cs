﻿using System;
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
            updateLB(cbCategorie.SelectedItem as string);
        }

        // EVENT HANDLERS
        private void btnInfo_Click(object sender, EventArgs e)
        {
            LaadInfo();

        }

        private void btnBoekToevoegen_Click(object sender, EventArgs e)
        {
            NewBoek formNewBoek = new NewBoek();
            if (formNewBoek.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"{formNewBoek.nieuwBoek.Titel} toegevoegd.");
                updateLB("Boeken");
            }
        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLB(cbCategorie.SelectedItem as string);
        }

        private void lbBoeken_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LaadInfo();
        }

        private void btnNieuweUitgeverij_Click(object sender, EventArgs e)
        {
            NewUitgeverij newUitgeverijFrom = new NewUitgeverij();
            if (newUitgeverijFrom.ShowDialog() == DialogResult.OK)
            {
                updateLB("Uitgeverij");
                cbCategorie.SelectedItem = "Uitgeverij";
                MessageBox.Show($"{newUitgeverijFrom.nieuweUitgeverij.Naam} toegevoegd.");
            }
        }

        private void btnAuteurToevoegen_Click(object sender, EventArgs e)
        {
            NewAuteur newAuteurForm = new NewAuteur();
            if (newAuteurForm.ShowDialog() == DialogResult.OK)
            {
                updateLB("Auteur");
                cbCategorie.SelectedItem = "Auteur";
                MessageBox.Show($"{newAuteurForm.nieuweAuteur.Voornaam} {newAuteurForm.nieuweAuteur.Achternaam} toegevoegd.");

            }
        }

        private void btnGenreToevoegen_Click(object sender, EventArgs e)
        {
            newGenre newGenreForm = new newGenre();
            if (newGenreForm.ShowDialog() == DialogResult.OK)
            {
                updateLB("Genre");
                cbCategorie.SelectedItem = "Genre";
                MessageBox.Show($"{newGenreForm.nieuwGenre.Genre} Toegevoegd.");
            }
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            var categorie = cbCategorie.SelectedItem.ToString();
            var selectedID = (int)lbBoeken.SelectedValue;
            using (BoekenEntities ctx = new BoekenEntities())
            {               
                switch (categorie)
                {
                    case "Boeken":
                        var boek = ctx.Boeken.Where(b => b.Id == selectedID).FirstOrDefault();
                        if (MessageBox.Show($"Ben je zeker dat je {boek.Titel} wil verwijderen?", "Verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ctx.BoekenAuteurs.RemoveRange(ctx.BoekenAuteurs.Where(b => b.BoekId == boek.Id));
                            ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(b => b.BoekId == boek.Id));
                            ctx.Boeken.Remove(boek);
                        }
                        break;
                    case "Auteurs":
                        var auteur = ctx.Auteurs.Where(a => a.Id == selectedID).FirstOrDefault();
                        if (MessageBox.Show($"Ben je zeker dat je {auteur.Voornaam} {auteur.Achternaam} wil verwijderen", "Verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ctx.BoekenAuteurs.RemoveRange(ctx.BoekenAuteurs.Where(a => a.AuteurId == auteur.Id));
                            ctx.Auteurs.Remove(auteur);
                        }
                        break;
                    case "Genres":
                        var genre = ctx.Genres.Where(g => g.Id == selectedID).FirstOrDefault();
                        if (MessageBox.Show($"Ben je zeker dat je het genre: {genre.Genre} wil verwijderen?", "Verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ctx.BoekenGenres.RemoveRange(ctx.BoekenGenres.Where(g => g.Id == genre.Id));
                            ctx.Genres.Remove(genre);
                        }
                        break;
                    case "Uitgeverij":
                        var uitgeverij = ctx.Uitgeverijen.Where(u => u.Id == selectedID).FirstOrDefault();
                        if (MessageBox.Show($"Ben je zeker dat je de uitgeverij: {uitgeverij.Naam} en al zijn uitgebrachte boeken wil verwijderen?", "Verwijderen", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ctx.Boeken.RemoveRange(ctx.Boeken.Where(b => b.UitgeverId == uitgeverij.Id));
                            ctx.Uitgeverijen.Remove(uitgeverij);
                        }
                        break;
                    default:
                        break;
                }
                ctx.SaveChanges();
                updateLB(categorie);
            }
        }
        // METHODES
        private void LaadInfo()
        {
            var categorie = cbCategorie.SelectedItem.ToString();
            var selectedID = (int)lbBoeken.SelectedValue;
            using (BoekenEntities ctx = new BoekenEntities())
            {
                switch (categorie)
                {
                    case "Boeken":

                        FormBoekenInfo checkInfo = new FormBoekenInfo();
                        checkInfo.MijnBoekID = selectedID;
                        checkInfo.ShowDialog();

                        break;
                    case "Auteurs":

                        MessageBox.Show("Auteurs Info");

                        break;
                    case "Genres":

                        MessageBox.Show("Genre Info");


                        break;
                    case "Uitgeverij":

                        MessageBox.Show($"Uitgeverij Info: {ctx.Uitgeverijen.Where(p => p.Id == selectedID).Select(p => p.Naam).FirstOrDefault()}");

                        break;
                    default:
                        break;
                }
            }
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
    }
}
