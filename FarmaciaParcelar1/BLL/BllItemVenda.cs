using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.BLL
{
    class BllItemVenda
    {
        private readonly DalConexao conexao;
        public BllItemVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Adicionar(ModeloItemVenda venda)
        {
            DalItemVenda vendas = new DalItemVenda(conexao);
            vendas.Adicionar(venda);
        }

        public void Alterar(ModeloItemVenda venda)
        {
            if (venda.ID <= 0)
            {
                throw new Exception("O campo ID é obrigatório");
            }
            DalItemVenda vendas = new DalItemVenda(conexao);
            vendas.Alterar(venda);
        }

        public void Deletar(ModeloItemVenda venda)
        {
            DalItemVenda vendas = new DalItemVenda(conexao);
            vendas.Deletar(venda);
        }

        public DataTable Localizar(String valor)
        {
            DalItemVenda vendas = new DalItemVenda(conexao);
            return vendas.Localizar(valor);
        }

        public DataTable CarregarDataGridView()
        {
            DalItemVenda vendas = new DalItemVenda(conexao);
            return vendas.CarregarDataGridView();
        }

        public ModeloItemVenda CarregaModeloItemVenda(int codigo)
        {
            DalItemVenda vendas = new DalItemVenda(conexao);
            return vendas.CarregaModeloItemVenda(codigo);
        }
    }
}
