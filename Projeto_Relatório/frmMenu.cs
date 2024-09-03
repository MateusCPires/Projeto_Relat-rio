using Projeto_Relatório.Formulários;
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

        private void visualizarRelatórioAgrupadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaSeriesAgrupadas objVisualizaSeriesAgrupadas = new frmVisualizaSeriesAgrupadas();
            objVisualizaSeriesAgrupadas.MdiParent = this;
            objVisualizaSeriesAgrupadas.Show();
        }

        private void vilualizarRelatórioComFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaSeriesFiltradas objVisualizaSeriesFiltradas = new frmVisualizaSeriesFiltradas();
            objVisualizaSeriesFiltradas.MdiParent = this;
            objVisualizaSeriesFiltradas.Show();
        }
    }
}
