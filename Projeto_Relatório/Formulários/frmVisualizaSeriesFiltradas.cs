using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatório.Formulários
{
    public partial class frmVisualizaSeriesFiltradas : Form
    {
        public frmVisualizaSeriesFiltradas()
        {
            InitializeComponent();
        }

        private void frmVisualizaSeriesFiltradas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Series.ClassificacaoEtaria_Series'. Você pode movê-la ou removê-la conforme necessário.
            this.classificacaoEtaria_SeriesTableAdapter.Fill(this.dataSet_Series.ClassificacaoEtaria_Series);

            this.reportViewer2.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classificacaoEtaria_SeriesTableAdapter.FillBy(this.dataSet_Series.ClassificacaoEtaria_Series);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
