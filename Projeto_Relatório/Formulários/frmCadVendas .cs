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
                    SaldoAtual = (int)dtProduto.Rows[0]["pro_QtdeEstoque"];
                    txtQuantidade.Focus();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnCancelar_Click(sender, e);
            CarregaGridItens();
            PedidoTableAdapter tapedido = new PedidoTableAdapter();
            Id_VendaAtual = (int)taPedido.UltimoPedido() + 1;
            lblNumeroPedido.Text = Id_VendaAtual.ToString();
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
            taItemTemp.Insert(Id_VendaAtual, int.Parse(txtCodigo.Text),
                lblDescricaoProduto.Text, int.Parse(txtQuantidade.Text),
                decimal.Parse(txtValorUnit.Text), Usuario);
            Limpa_Campos_Item();
            CarregaGridItens();
            TotalDoPedido = TotalDoPedido + ValorTotalProduto;
            lblTotaldoPedido.Text = (TotalDoPedido).ToString("###,##0.00");
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text == "") txtQuantidade.Text = "1";
            QuantidadeDigitada = Convert.ToInt16(txtQuantidade.Text);
            if (QuantidadeDigitada > SaldoAtual)
            {
                MessageBox.Show("Saldo insuficiente, só existem" + SaldoAtual.ToString() + "disponível");
                txtQuantidade.Focus();
                txtQuantidade.SelectAll();
            }
        }

        private void txtValorUnit_Leave(object sender, EventArgs e)
        {
            ValorUnitDigitado = Convert.ToDouble(txtValorUnit.Text);
            ValorTotalProduto = QuantidadeDigitada * ValorUnitDigitado;
            // lblTotalProduto.Text = (ValorTotalProduto).ToString("###,##0.00");
            lblTotaldoPedido.Text = (ValorTotalProduto).ToString("c");
            btnAdicionarItem.Focus();
        }


        private void btnGravarVenda_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1
            {
                errErro.SetError(cmbCliente, "Selecione um Cliente");
                return;
            }
            else
            {
                errErro.SetError(cmbCliente, "");
            }
            PedidoTableAdapter taPedido = new PedidoTableAdapter();
            taPedido.Insert(int.Parse(cmbCliente.SelectedValue.ToString()),
                dtpDataVenda.Value, decimal.Parse(TotalDoPedido.ToString()), "V", txtObservacao.Text);
            Id_VendaAtual = (int)taPedido.UltimoPedido();

            ItemTableAdapter taItem = new ItemTableAdapter();
            ProdutoTableAdapter taProduto = new ProdutoTableAdapter();
            int CodigoProduto, QtdVendida;
            decimal ValorUnit;
            for (int i = 0; i < dgvItem.RowCount; i++)
            {
                CodigoProduto = (int)dgvItem.Rows[i].Cells["Codigo"].Value;
                QtdVendida = (int)dgvItem.Rows[i].Cells["Quantidade"].Value;
                ValorUnit = (decimal)dgvItem.Rows[i].Cells["ValorUnit"].Value;

                taItem.Insert(Id_VendaAtual, CodigoProduto, QtdVendida, ValorUnit);

                taProduto.Acerta_Saldo_Saida(CodigoProduto, QtdVendida);
            }
            MessageBox.Show("Venda gravada com sucesso!");
            Limpa_Campos_Pedido();

            Item_TempTableAdapter taItem_Temp = new Item_TempTableAdapter();
            taItem_Temp.Limpa_Itens(Id_VendaAtual, Usuario);
            CarregaGridItens();
            grbPedido.Enabled = false;
            grbItem.Enabled = false;
            btnGravarVenda.Enabled = false;
            btnNovo.Enabled = true;
            btnCancelar.Enabled = false;
        }
}
