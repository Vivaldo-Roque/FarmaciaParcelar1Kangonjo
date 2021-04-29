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
    class BllCliente
    {
        private readonly DalConexao conexao;
        public BllCliente(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Adicionar(ModeloCliente cliente)
        {
            if (String.IsNullOrEmpty(cliente.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalCliente dalCliente = new DalCliente(conexao);
            dalCliente.Adicionar(cliente);
        }
        public void Alterar(ModeloCliente cliente)
        {

            if (cliente.ID <= 0)
            {
                throw new Exception("O campo ID é obrigatório");
            }
            if (String.IsNullOrEmpty(cliente.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalCliente dalCliente = new DalCliente(conexao);
            dalCliente.Alterar(cliente);
        }
        public void Deletar(ModeloCliente cliente)
        {
            DalCliente dalCliente = new DalCliente(conexao);
            dalCliente.Deletar(cliente);
        }
        public DataTable Localizar(String valor)
        {
            DalCliente dalCliente = new DalCliente(conexao);
            return dalCliente.Localizar(valor);
        }

        public DataTable CarregarDataGridView()
        {
            DalCliente dalCliente = new DalCliente(conexao);
            return dalCliente.CarregarDataGridView();
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DalCliente dalCliente = new DalCliente(conexao);
            return dalCliente.CarregaModeloCliente(codigo);
        }
    }
}
