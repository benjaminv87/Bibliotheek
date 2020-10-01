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
    public partial class newGenre : Form
    {
        public newGenre()
        {
            InitializeComponent();
        }
        public Genres nieuwGenre = new Genres();
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            nieuwGenre.Genre = tbNaam.Text;
            using (BoekenEntities ctx = new BoekenEntities())
            {
                ctx.Genres.Add(nieuwGenre);
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
