using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_PPE
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            consultRapport cR = new consultRapport();
            cR.Show();
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            creationRapport creaRap = new creationRapport();
            creaRap.Show();
        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifRapport modRap = new modifRapport();
            modRap.Show();
        }

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            supprRapport supRap = new supprRapport();
            supRap.Show();
        }
    }
}
