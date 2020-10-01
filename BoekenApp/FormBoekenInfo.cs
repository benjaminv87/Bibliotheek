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
    public partial class FormBoekenInfo : Form
    {
        public int MijnBoekID;
        public FormBoekenInfo()
        {
            InitializeComponent();
        }

        private void BoekenInfo_Load(object sender, EventArgs e)
        {
            using (BoekenEntities ctx = new BoekenEntities())
            {
                Boeken MijnBoek = ctx.Boeken.Where(b => b.Id == MijnBoekID).FirstOrDefault();
                Uitgeverijen uitgeverij = ctx.Uitgeverijen.Where(u => u.Id == MijnBoek.UitgeverId).FirstOrDefault();

                var genreLijst = ctx.BoekenGenres.Where(bg => bg.BoekId == MijnBoek.Id).Join(ctx.Genres,
                    gl => gl.GenreId,
                    g => g.Id,
                    (gl, g) => new { g.Genre }).ToList();

                var auteurLijst = ctx.BoekenAuteurs.Where(ba => ba.BoekId == MijnBoekID).Join(ctx.Auteurs,
                    ba => ba.AuteurId,
                    a => a.Id,
                    (ba, a) => new { Naam = a.Voornaam + " " + a.Achternaam }).ToList();

                lblTitel.Text = MijnBoek.Titel;
                lblPaginas.Text = MijnBoek.AantalPaginas.ToString();
                lblScore.Text = MijnBoek.Score.ToString();
                lblPublicatie.Text = Convert.ToDateTime(MijnBoek.Publicatie).ToString("dd MMM yy");
                lblUitgeverij.Text = uitgeverij.Naam;

                lbAuteurs.DataSource = auteurLijst;
                lbAuteurs.DisplayMember = "Naam";
                lbGenres.DataSource = genreLijst;
                lbGenres.DisplayMember = "Genre";
            }
        }
    }
}
