using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatório
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void VisualizarRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaSeries objVisualizaSeries = new frmVisualizaSeries();
            objVisualizaSeries.MdiParent = this;
            objVisualizaSeries.Show();
        }
    }
}
