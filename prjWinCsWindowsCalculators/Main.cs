using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsWindowsCalculators
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void calculatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatoreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuStandartCal_Click(object sender, EventArgs e)
        {
            frmSimpleCalculator fo = new frmSimpleCalculator();
            fo.MdiParent = this;
            fo.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fo = new frmAbout();
            fo.MdiParent = this;
            fo.Show();
        }
    }
}
