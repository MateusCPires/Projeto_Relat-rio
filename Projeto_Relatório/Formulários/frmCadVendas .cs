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
            if (txtCodigo.Text != "")
            {
                ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
                DataSet_Dados_Do_Banco.ProdutoDataTable dtProduto = new DataSet_Dados_Do_Banco.ProdutoDataTable();
                dtProduto = taProduto.Procura_Produto(int.Parse(txtCodigo.Text));
                if (dtProduto.Rows.Count == 0)
                {
                    MessageBox.Show("Código não cadastrado");
                    txtCodigo.Focus();
                }
                else
                {
                    lblDescricaoProduto.Text = dtProduto.Rows[@]["pro_Descricao"].ToString();
                    txtValorUnit.Text = dtProduto.Rows[0]["pro_valor"].ToString();
                    vSaldoAtual = (int)dtProduto.Rows[0]["pro_QtdeEstoque"];
                    txtQuantidade.Focus();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
            CarregaGridItens();
            PedidoTableAdapter tapedido = new PedidoTableAdapter();
            vld_VendaAtual = (int)taPedido.UltimoPedido() + 1;
            lblNumeroPedido.Text = vld_VendaAtual.ToString();
            grbpedido.Enabled = true;
            grbItem.Enabled = true;
            btnGravarVenda.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Visible = true;
            cmbCliente.Focus();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            Item_TempTableAdapter taItemTemp = new Item_TempTableAdapter();
            taItemTemp.Insert(vld_VendaAtual, int.Parse(txtCodigo.Text),
                lblDescricaoProduto.Text, int.Parse(txtQuantidade.Text),
                decimal.Parse(txtValorUnit.Text), Usuario);
            Limpa_Campos_Item();
            CarregaGridItens();
            vTotalDoPedido = vTotalDoPedido + vValorTotalProduto;
            lblTotaldoPedido.Text = (TotalDoPedido).ToString("###,##0.00");
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "") txtQuantidade.Text = "1";
            vQuantidadeDigitada = Convert.ToInt16(txtQuantidade.Text);
            if (vQuantidadeDigitada > vSaldoAtual)
            {
                MessageBox.Show("Saldo insuficiente, só existem" + vSaldoAtual.ToString() + "disponível");
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
        }

        private void txtValorUnit_Leave(object sender, EventArgs e)
        {
            VValorUnitDigitado = Convert.ToDouble(txtValorUnit.Text);
            vValorTotalProduto = vQuantidadeDigitada * valorUnitDigitado;
            // lblTotalProduto.Text = (vValorTotalProduto).ToString("###,##0.00");
            lblTotalProduto.Text = (vValorTotalProduto).ToString("c");
            btnAdicionarItem.Focus();
        }
    }
}
