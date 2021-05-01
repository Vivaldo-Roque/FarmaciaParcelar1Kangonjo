using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.DAL;
using MySql.Data.MySqlClient;
using FarmaciaParcelar1.Modelos;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
        ModeloProduto produto = new ModeloProduto();

        private void Campos(int x)
        {
            if (x == 0)
            {
                TxtID.Enabled = true;
                TxtDescricao.Enabled = false;
                TxtFabricante.Enabled = false;
                TxtNome.Enabled = false;
                TxtFornecedor.Enabled = false;
                DtpDataValidade.Enabled = false;
                TxtQuantidade.Enabled = false;
                TxtQuantidadeMinima.Enabled = false;
                TxtValorFinal.Enabled = false;
            }
            else
            if (x == 1)
            {
                TxtID.Enabled = false;
                TxtDescricao.Enabled = true;
                TxtFabricante.Enabled = true;
                TxtNome.Enabled = true;
                TxtFornecedor.Enabled = true;
                DtpDataValidade.Enabled = true;
                TxtQuantidade.Enabled = true;
                TxtQuantidadeMinima.Enabled = true;
                TxtValorFinal.Enabled = true;
            }
        }
        private void Buttons(int x)
        {
            if (x == 0)
            {
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnConsultar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnFechar.Enabled = true;
                BtnLimpar.Enabled = false;
                BtnPesquisar.Enabled = true;
                BtnCancelar.Enabled = false;
                Campos(0);

            }
            else
            if (x == 1)
            {
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
                BtnConsultar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnFechar.Enabled = false;
                BtnLimpar.Enabled = true;
                BtnPesquisar.Enabled = false;
                BtnCancelar.Enabled = true;
                Campos(1);
                Limpar();
            }
            else
            if (x == 2)
            {
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnConsultar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnFechar.Enabled = false;
                BtnLimpar.Enabled = true;
                BtnPesquisar.Enabled = false;
                BtnCancelar.Enabled = true;
                Campos(1);
            }
        }

        private void LimparDgvProdutos()
        {
            DataTable DT = (DataTable)DgvProdutos.DataSource;
            if (DT != null)
                DT.Clear();
        }
        public void FrmProdutos_Load(object sender, EventArgs e)
        {
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        public void BtnSalvar_Click(object sender, EventArgs e)
        {
            produto.Nome = TxtNome.Text;
            produto.Descricao = TxtDescricao.Text;
            produto.Data = DtpDataValidade.Value;
            produto.Fabricante = TxtFabricante.Text;
            produto.Fornecedor = TxtFornecedor.Text;
            produto.Quantidade = Convert.ToInt32(TxtQuantidade.Text);
            produto.QuantidadeMinima = Convert.ToInt32(TxtQuantidadeMinima.Text);
            produto.ValorFinal = Convert.ToDecimal(TxtValorFinal.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bllproduto = new BllProduto(conexao);
            bllproduto.Adicionar(produto);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        public void BtnEditar_Click(object sender, EventArgs e)
        {
            produto.ID = Convert.ToInt32(TxtID.Text);
            produto.Nome = TxtNome.Text;
            produto.Descricao = TxtDescricao.Text;
            produto.Data = DtpDataValidade.Value;
            produto.Fabricante = TxtFabricante.Text;
            produto.Fornecedor = TxtFornecedor.Text;
            produto.Quantidade = Convert.ToInt32(TxtQuantidade.Text);
            produto.QuantidadeMinima = Convert.ToInt32(TxtQuantidadeMinima.Text);
            produto.ValorFinal = Convert.ToDecimal(TxtValorFinal.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bllproduto = new BllProduto(conexao);
            bllproduto.Alterar(produto);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void Limpar()
        {
            TxtID.Text = "";
            TxtDescricao.Text = "";
            TxtNome.Text = "";
            TxtQuantidade.Text = "";
            TxtValorFinal.Text = "";
            TxtFabricante.Text = "";
            TxtFornecedor.Text = "";
            TxtValorFinal.Text = "";
            TxtQuantidadeMinima.Text = "";
            DtpDataValidade.Value = DateTime.Now;
            LimparDgvProdutos();
        }

        public void BtnEliminar_Click(object sender, EventArgs e)
        {
            produto.ID = Convert.ToInt32(TxtID.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bllproduto = new BllProduto(conexao);
            bllproduto.Deletar(produto);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        public void BtnConsultar_Click(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bllproduto = new BllProduto(conexao);
            DgvProdutos.DataSource = bllproduto.CarregarDataGridView();
        }

        public void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            produto.ID = Convert.ToInt32(TxtID.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllProduto bllproduto = new BllProduto(conexao);
            produto.ID = Convert.ToInt32(TxtID.Text);
            produto = bllproduto.CarregaModeloFuncionario(produto.ID);
            TxtID.Text = produto.ID.ToString();
            TxtDescricao.Text = produto.Descricao;
            TxtNome.Text = produto.Nome;
            TxtQuantidade.Text = produto.Quantidade.ToString();
            TxtValorFinal.Text = produto.ValorFinal.ToString();
            TxtFabricante.Text = produto.Fabricante;
            TxtFornecedor.Text = produto.Fornecedor;
            TxtQuantidadeMinima.Text = produto.QuantidadeMinima.ToString();
            Buttons(2);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Buttons(1);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Buttons(0);
            Limpar();
        }
    }
}
