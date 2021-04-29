using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaParcelar1.Modelos;
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.BLL;
using System.Data;

namespace FarmaciaParcelar1.BLL
{
    class BllProduto
    {
        private readonly DalConexao conexao;
        public BllProduto(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Adicionar(ModeloProduto produto)
        {
            if (String.IsNullOrEmpty(produto.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalProdutos produtos = new DalProdutos(conexao);
            produtos.Adicionar(produto);
        }
        public void Alterar(ModeloProduto produto)
        {

            if (produto.ID <= 0)
            {
                throw new Exception("O campo ID é obrigatório");
            }
            if (String.IsNullOrEmpty(produto.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalProdutos produtos = new DalProdutos(conexao);
            produtos.Alterar(produto);
        }
        public void Deletar(ModeloProduto produto)
        {
            DalProdutos produtos = new DalProdutos(conexao);
            produtos.Deletar(produto);
        }
        public DataTable Localizar(String valor)
        {
            DalProdutos produtos = new DalProdutos(conexao);
            return produtos.Localizar(valor);
        }

        public DataTable CarregarDataGridView()
        {
            DalProdutos produtos = new DalProdutos(conexao);
            return produtos.CarregarDataGridView();
        }

        public ModeloProduto CarregaModeloFuncionario(int codigo)
        {
            DalProdutos produtos = new DalProdutos(conexao);
            return produtos.CarregaModeloProduto(codigo);
        }
    }
}
