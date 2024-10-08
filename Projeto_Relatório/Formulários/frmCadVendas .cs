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
    public partial class frmCadVendas : Form
    {
        public frmCadVendas()
        {
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
            CarregaGridItens();
            PedidoTableAdapter tapedido = new Pedido TableAdapter(); vld_VendaAtual = (int)taPedido.UltimoPedido() + 1; lblNumeroPedido.Text = vld_VendaAtual.ToString();
            grbpedido.Enabled = true;
            grbItem.Enabled = true;
            btnGravarVenda.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cmbCliente.Focus();
        }
    }
}
