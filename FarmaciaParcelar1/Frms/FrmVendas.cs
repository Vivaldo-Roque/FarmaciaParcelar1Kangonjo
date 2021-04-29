using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.Modelos;
using FarmaciaParcelar1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }

        readonly ModeloProduto produto = new ModeloProduto();
        readonly ModeloCliente cliente = new ModeloCliente();
        decimal subtotal = 0, total = 0, imposto = 0, desconto = 0, dinheiro = 0, troco = 0;

        private void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Start();
            ConsultarClientes();
            ConsultarProdutos();
            LblData.Text = $"Data: {DateTime.Now.ToShortDateString()}";
            GbProduto.Enabled = false;
        }

        private void ConsultarClientes()
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bll = new BllCliente(conexao);
            DgvClientes.DataSource = bll.CarregarDataGridView();
            foreach (DataGridViewColumn column in DgvClientes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ConsultarProdutos()
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bll = new BllProduto(conexao);
            DgvProdutos.DataSource = bll.CarregarDataGridView();
            foreach (DataGridViewColumn column in DgvProdutos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void TxtPesquisarCliente_TextChanged(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bll = new BllCliente(conexao);
            DgvClientes.DataSource = bll.Localizar(TxtPesquisarCliente.Text);
        }

        private void TxtPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bll = new BllProduto(conexao);
            DgvProdutos.DataSource = bll.Localizar(TxtPesquisarProduto.Text);
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            TxtClienteSelecionado.Text = DgvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            cliente.ID = Convert.ToInt32(DgvClientes.Rows[e.RowIndex].Cells["idcliente"].Value.ToString());
            cliente.Nome = DgvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            cliente.BI = DgvClientes.Rows[e.RowIndex].Cells["bi"].Value.ToString();
            cliente.Genero = Convert.ToInt32(DgvClientes.Rows[e.RowIndex].Cells["idgenero"].Value.ToString());
            cliente.Data = Convert.ToDateTime(DgvClientes.Rows[e.RowIndex].Cells["data"].Value.ToString());
            cliente.EstadoCivil = Convert.ToInt32(DgvClientes.Rows[e.RowIndex].Cells["idestadoCivil"].Value.ToString());
            cliente.Telefone = Convert.ToInt32(DgvClientes.Rows[e.RowIndex].Cells["telefone"].Value.ToString());
            cliente.Email = DgvClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();
            cliente.DataRegisto = Convert.ToDateTime(DgvClientes.Rows[e.RowIndex].Cells["dataRegisto"].Value.ToString());
            GbProduto.Enabled = true;
        }

        private void DgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            TxtProdutoSelecionado.Text = DgvProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            TxtValor.Text = Convert.ToDecimal(DgvProdutos.Rows[e.RowIndex].Cells["ValorFinal"].Value.ToString()).ToString("#,##0.00");
            TxtQuantidadeMinima.Text = DgvProdutos.Rows[e.RowIndex].Cells["quantidademinima"].Value.ToString();
            TxtQuantidade.Text = DgvProdutos.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
            produto.ID = Convert.ToInt32(DgvProdutos.Rows[e.RowIndex].Cells["idproduto"].Value.ToString());
            produto.Nome = DgvProdutos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            produto.Quantidade = Convert.ToInt32(DgvProdutos.Rows[e.RowIndex].Cells["quantidade"].Value.ToString());
            produto.QuantidadeMinima = Convert.ToInt32(DgvProdutos.Rows[e.RowIndex].Cells["quantidademinima"].Value.ToString());
            produto.ValorFinal = Convert.ToDecimal(DgvProdutos.Rows[e.RowIndex].Cells["ValorFinal"].Value.ToString());
            produto.Descricao = DgvProdutos.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            produto.Data = Convert.ToDateTime(DgvProdutos.Rows[e.RowIndex].Cells["data"].Value.ToString());
            produto.Fabricante = DgvProdutos.Rows[e.RowIndex].Cells["fabricante"].Value.ToString();
            produto.Fornecedor = DgvProdutos.Rows[e.RowIndex].Cells["fornecedor"].Value.ToString();
        }

        private void BtnAdicionarItem_Click(object sender, EventArgs e)
        {
            var items = new ListViewItem(new string[] { produto.ID.ToString(), produto.Nome, produto.ValorFinal.ToString("#,##0.00"), TxtQuantidadeVenda.Text, (produto.ValorFinal * Convert.ToInt32(TxtQuantidadeVenda.Text)).ToString("#,##0.00") });
            LvItemsVenda.Items.Add(items);
            subtotal = SomarColuna(LvItemsVenda);
            TxtSubTotal.Text = subtotal.ToString("#,##0.00");
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in LvItemsVenda.CheckedItems)
            {
                subtotal -= Convert.ToDecimal(eachItem.SubItems[4].Text);
                TxtSubTotal.Text = subtotal.ToString();
                LvItemsVenda.Items.Remove(eachItem);
            }
        }

        private void TxtDinheiro_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtDinheiro.Text) == false)
            {
                if (Convert.ToDecimal(TxtDinheiro.Text) <= 0)
                {
                    MessageBox.Show("Insira uma quantidade válida!", "Dinheiro");
                    TxtQuantidadeVenda.Text = "1";
                }
                else
                {
                    dinheiro = Convert.ToDecimal(TxtDinheiro.Text);
                    TxtDinheiro.Text = dinheiro.ToString("#,##0.00");
                    troco = dinheiro - total;
                    TxtTroco.Text = troco.ToString("#,##0.00");
                }
            }


        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            ModeloVenda venda = new ModeloVenda();
            ModeloItemVenda itemVenda = new ModeloItemVenda();
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllIVenda vendas = new BllIVenda(conexao);
            BllItemVenda itemVendas = new BllItemVenda(conexao);
            long vendaID;

            if (Convert.ToDecimal(TxtDinheiro.Text) <= Convert.ToDecimal(TxtTotal.Text) && Convert.ToDecimal(TxtImpostoPercentagem.Text) <= 0 && Convert.ToDecimal(TxtDescontoPercentagem.Text) <= 0 && Convert.ToDecimal(TxtDinheiro.Text) <= 0)
            {
                MessageBox.Show("Preencha todos os campos devidamente", "Venda");
            }
            else
            {
                venda.Cliente = cliente.ID;
                venda.Funcionario = LogadoNoSistema.ID;
                venda.Data = DateTime.Now;
                venda.DataPagamento = DateTime.Now;
                venda.Hora = DateTime.Now;
                venda.NumeroFatura = vendas.PegarUltimaVenda();
                venda.ValorBruto = subtotal;
                venda.Imposto = Convert.ToDecimal(TxtImpostoPercentagem.Text);
                venda.Desconto = Convert.ToDecimal(TxtDescontoPercentagem.Text);
                venda.ValorLiquido = total;

                vendaID = vendas.Adicionar(venda);

                for (int i = 0; i < LvItemsVenda.Items.Count; i++)
                {
                    itemVenda.Produto = Convert.ToInt32(LvItemsVenda.Items[i].SubItems[0].Text);
                    itemVenda.Quantidade = Convert.ToInt32(LvItemsVenda.Items[i].SubItems[3].Text);
                    itemVenda.Venda = Convert.ToInt32(vendaID.ToString());
                    itemVenda.ValorUnico = Convert.ToDecimal(LvItemsVenda.Items[i].SubItems[2].Text);

                    itemVendas.Adicionar(itemVenda);
                }
            }
        }

        private void FrmVendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timer1.Stop();
            Timer1.Dispose();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = $"Hora: {DateTime.Now:HH:mm:ss}";
        }

        private void TxtQuantidadeVenda_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtQuantidadeVenda.Text) == false)
            {
                if (Convert.ToInt32(TxtQuantidadeVenda.Text) <= 0)
                {
                    MessageBox.Show("Insira uma quantidade válida!", "Quantidade");
                    TxtQuantidadeVenda.Text = "1";
                }
            }
        }

        private void TxtQuantidadeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void TxtImpostoPercentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void TxtDescontoPercentagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void TxtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(e);
        }

        private void TxtImpostoPercentagem_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtImpostoPercentagem.Text) == false)
            {
                if (Convert.ToDecimal(TxtImpostoPercentagem.Text) <= 0)
                {
                    MessageBox.Show("Insira um valor válido!", "Imposto");
                    TxtImpostoPercentagem.Text = "1";
                }
                else
                {
                    imposto = CalcularImposto(Convert.ToDecimal(TxtImpostoPercentagem.Text), Convert.ToDecimal(TxtSubTotal.Text));
                    TxtImpostoValorEmKZ.Text = imposto.ToString("#,##0.00");
                    total = subtotal + imposto;
                    TxtTotal.Text = total.ToString("#,##0.00");
                }
            }

        }

        private void TxtDescontoPercentagem_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtDescontoPercentagem.Text) == false)
            {
                if (Convert.ToDecimal(TxtDescontoPercentagem.Text) <= 0)
                {
                    MessageBox.Show("Insira um valor válido!", "Desconto");
                    TxtDescontoPercentagem.Text = "1";
                }
                else
                {
                    desconto = CalcularDesconto(Convert.ToDecimal(TxtDescontoPercentagem.Text), Convert.ToDecimal(TxtSubTotal.Text));
                    TxtDescontoValorEmKZ.Text = desconto.ToString("#,##0.00");
                    total -= desconto;
                    TxtTotal.Text = total.ToString("#,##0.00");
                }
            }
        }

        private decimal CalcularImposto(decimal percentagem, decimal valor)
        {
            return ((percentagem / 100) * valor);
        }
        private decimal CalcularDesconto(decimal percentagem, decimal valor)
        {
            return ((percentagem / 100) * valor);
        }

        private decimal SomarColuna(ListView listView)
        {
            decimal valorAcumulado = 0;
            for (int i = 0; i < listView.Items.Count; i++)
            {
                valorAcumulado += decimal.Parse(listView.Items[i].SubItems[4].Text);
            }
            return valorAcumulado;
        }
    }
}
