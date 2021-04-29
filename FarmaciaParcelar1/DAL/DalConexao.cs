using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.DAL
{
    //Classe responsavel por lidar com a conexao
    class DalConexao
    {
        private string _stringConexao;
        private OleDbConnection _conexao = new OleDbConnection();

        public DalConexao(string dadosConexao)
        {
            this._conexao = new OleDbConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }
       public OleDbConnection ObjetoConexao
        {
            get {return this._conexao; }
            set {this._conexao = value; }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }

        public void Desconectar()
        {
            this._conexao.Close();
        }


    }
}
