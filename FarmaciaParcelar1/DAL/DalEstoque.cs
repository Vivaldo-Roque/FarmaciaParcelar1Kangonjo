using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaParcelar1.DAL
{
    class DalEstoque
    {
        private readonly DalConexao conexao;

        public DalEstoque(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand(@"SELECT p.nome AS produtos, p.quantidade AS entradas, Sum(v.quantidade) AS saidas, p.quantidade-saidas AS [estoque final]
FROM produto AS p INNER JOIN item_venda AS v ON p.idproduto = v.idproduto
GROUP BY p.nome, p.quantidade
ORDER BY p.nome, p.quantidade-Sum(v.quantidade);
", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }


    }
}
