using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.Modelos;

namespace FarmaciaParcelar1.BLL
{
    class BllFuncionario
    {
        private readonly DalConexao conexao;
        public BllFuncionario(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Adicionar(ModeloFuncionario funcionario)
        {
            if(String.IsNullOrEmpty(funcionario.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            dalFuncionario.Adicionar(funcionario);
        }
        public void Alterar(ModeloFuncionario funcionario) {

            if (funcionario.ID <= 0)
            {
                throw new Exception("O campo ID é obrigatório");
            }
            if (String.IsNullOrEmpty(funcionario.Nome) == true)
            {
                throw new Exception("O campo nome é obrigatório");
            }
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            dalFuncionario.Alterar(funcionario);
        }
        public void Deletar(ModeloFuncionario funcionario) {
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            dalFuncionario.Deletar(funcionario);
        }
        public DataTable Localizar(String valor) {
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            return dalFuncionario.Localizar(valor);
        }

        public DataTable CarregarDataGridView() {
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            return dalFuncionario.CarregarDataGridView();
        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo) {
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            return dalFuncionario.CarregaModeloFuncionario(codigo);
        }

        public bool VerificarLogin(ModeloFuncionario funcionario)
        {
            DalFuncionario dalFuncionario = new DalFuncionario(conexao);
            return dalFuncionario.VerificarLogin(funcionario);
        }

    }
}
