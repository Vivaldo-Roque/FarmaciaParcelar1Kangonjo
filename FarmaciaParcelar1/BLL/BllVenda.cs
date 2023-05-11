using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.BLL
{
    class BllIVenda
    {
        private readonly DalConexao conexao;
        public BllIVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public long Adicionar(ModeloVenda venda)
        {
            DalVenda vendas = new DalVenda(conexao);
            return vendas.Adicionar(venda);
        }

        public void Alterar(ModeloVenda venda)
        {
            if (venda.ID <= 0)
            {
                throw new Exception("O campo ID é obrigatório");
            }
            DalVenda vendas = new DalVenda(conexao);
            vendas.Alterar(venda);
        }

        public void Deletar(ModeloVenda venda)
        {
            DalVenda vendas = new DalVenda(conexao);
            vendas.Deletar(venda);
        }

        public DataTable Localizar(String valor)
        {
            DalVenda vendas = new DalVenda(conexao);
            return vendas.Localizar(valor);
        }

        public DataTable CarregarDataGridView()
        {
            DalVenda vendas = new DalVenda(conexao);
            return vendas.CarregarDataGridView();
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            DalVenda vendas = new DalVenda(conexao);
            return vendas.CarregaModeloVenda(codigo);
        }

        public int PegarUltimaVenda()
        {
            DalVenda vendas = new DalVenda(conexao);
            return vendas.PegarUltimaVenda();
        }
    }
}
