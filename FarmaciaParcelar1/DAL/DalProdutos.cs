using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using FarmaciaParcelar1.Modelos;
using System.Data;
using System.Windows.Forms;

namespace FarmaciaParcelar1.DAL
{
    class DalProdutos
    {
        private readonly DalConexao conexao;

        public DalProdutos(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Adicionar(ModeloProduto produto)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into produto(nome, fabricante, fornecedor, data, descricao, quantidade, ValorFinal, quantidademinima) values (?, ?, ?, ?, ?, ?, ?, ?)"
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value =produto.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value =produto.Fabricante;
            cmd.Parameters.Add("?", OleDbType.WChar).Value =produto.Fornecedor;
            cmd.Parameters.Add("?", OleDbType.Date).Value =produto.Data;
            cmd.Parameters.Add("?", OleDbType.WChar).Value =produto.Descricao;
            cmd.Parameters.Add("?", OleDbType.Integer).Value =produto.Quantidade;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value =produto.ValorFinal;
            cmd.Parameters.Add("?", OleDbType.Integer).Value =produto.QuantidadeMinima;
            conexao.Conectar();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar!");
            }
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto produto)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update produto set nome=?, fabricante=?, fornecedor=?, data=?, descricao=?, quantidade=?, ValorFinal=?, quantidademinima=? where idproduto=?"
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value = produto.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = produto.Fabricante;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = produto.Fornecedor;
            cmd.Parameters.Add("?", OleDbType.Date).Value = produto.Data;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = produto.Descricao;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = produto.Quantidade;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = produto.ValorFinal;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = produto.QuantidadeMinima;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = produto.ID;
            conexao.Conectar();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Editado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel editar!");
            }
            conexao.Desconectar();
        }

        public void Deletar(ModeloProduto produto)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from produto where idproduto=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = produto.ID;
            conexao.Conectar();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eliminado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel eliminar!");
            }
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from produto where nome like '%{valor}%'", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from produto", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto produto = new ModeloProduto();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select * from produto where idproduto=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = codigo;
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                produto.ID = Convert.ToInt32(reader["idproduto"]);
                produto.Fabricante = Convert.ToString(reader["fabricante"]);
                produto.Fornecedor = Convert.ToString(reader["fornecedor"]);
                produto.Nome = Convert.ToString(reader["nome"]);
                produto.Data = Convert.ToDateTime(reader["data"]);
                produto.Descricao = Convert.ToString(reader["descricao"]);
                produto.Quantidade = Convert.ToInt32(reader["quantidade"]);
                produto.ValorFinal = Convert.ToDecimal(reader["ValorFinal"]);
                produto.QuantidadeMinima = Convert.ToInt32(reader["quantidademinima"]);
                MessageBox.Show("Localizado com sucesso com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel localizar!");
            }
            conexao.Desconectar();
            return produto;
        }
    }
}
