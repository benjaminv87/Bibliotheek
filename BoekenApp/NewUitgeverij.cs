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
    public partial class NewUitgeverij : Form
    {
        public NewUitgeverij()
        {
            InitializeComponent();
        }

        public Uitgeverijen nieuweUitgeverij = new Uitgeverijen();

        //EVENT HANDLERS
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            nieuweUitgeverij.Naam = tbNaam.Text;
            using (BoekenEntities ctx = new BoekenEntities())
            {
                ctx.Uitgeverijen.Add(nieuweUitgeverij);
                ctx.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
