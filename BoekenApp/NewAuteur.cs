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
    public partial class NewAuteur : Form
    {
        public NewAuteur()
        {
            InitializeComponent();
        }

        public Auteurs nieuweAuteur = new Auteurs();
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            nieuweAuteur.Voornaam = tbVoornaam.Text;
            nieuweAuteur.Achternaam = tbAchternaam.Text;
            using(BoekenEntities ctx = new BoekenEntities())
            {
                ctx.Auteurs.Add(nieuweAuteur);
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

    }
}
