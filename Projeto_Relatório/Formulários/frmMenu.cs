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
            objVisualizaSeries.Show();
        }

        private void visualizarRelatórioAgrupadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaSeriesAgrupadas objVisualizaSeriesAgrupadas = new frmVisualizaSeriesAgrupadas();
            objVisualizaSeriesAgrupadas.Show();
        }

        private void vilualizarRelatórioComFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaSeriesFiltradas objVisualizaSeriesFiltradas = new frmVisualizaSeriesFiltradas();
            objVisualizaSeriesFiltradas.Show();
        }

        private void relatórioFiltradoPorPopupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformaParametros objInformaParametros = new frmInformaParametros();
            objInformaParametros.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSplashScreen objSplashScreen = new frmSplashScreen();
            objSplashScreen.Close();
        }
    }
}
