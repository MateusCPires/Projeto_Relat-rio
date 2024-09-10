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
    public partial class frmInformaParametros : Form
    {
        public frmInformaParametros()
        {
            InitializeComponent();
        }

        private void frmInformaParametros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Series.ClassificacaoEtaria_Series'. Você pode movê-la ou removê-la conforme necessário.
            this.classificacaoEtaria_SeriesTableAdapter.Fill(this.dataSet_Series.ClassificacaoEtaria_Series);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmVisualizaSeries objVisualizaSeries = new frmVisualizaSeries();
            objVisualizaSeries.pClassificacao = cmbClassificacao.Text;
            objVisualizaSeries.Show();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            frmVisualizaSeries objVisualizaSeries = new frmVisualizaSeries();
            objVisualizaSeries.pClassificacao = (string)null;
            objVisualizaSeries.Show();
        }
    }
}
