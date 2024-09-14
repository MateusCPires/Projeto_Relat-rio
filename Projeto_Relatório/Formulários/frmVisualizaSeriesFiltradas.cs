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
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Series.Series'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSet_Series.Series);

            this.reportViewer2.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classificacaoEtaria_SeriesTableAdapter.Fill(this.dataSet_Series.ClassificacaoEtaria_Series);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Classificacao", cmbClassificacao.Text));
            this.reportViewer2.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.reportViewer2.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Classificacao", (string)null));
            this.reportViewer2.RefreshReport();
        }
    }
}
