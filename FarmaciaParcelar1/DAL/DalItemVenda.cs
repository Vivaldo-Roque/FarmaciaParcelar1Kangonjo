using FarmaciaParcelar1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.DAL
{
    class DalItemVenda
    {
        private readonly DalConexao conexao;

        public DalItemVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Adicionar(ModeloItemVenda venda)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into item_venda(idproduto, quantidade, ValorUnico, idvenda) values (?, ?, ?, ?)"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value=venda.Produto;
            cmd.Parameters.Add("?", OleDbType.Integer).Value =venda.Quantidade;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value =venda.ValorUnico;
            cmd.Parameters.Add("?", OleDbType.Integer).Value =venda.Venda;
            conexao.Conectar();
            venda.ID = Convert.ToInt32(cmd.ExecuteScalar());
            //if (venda.ID > 0)
            //{
            //    MessageBox.Show("Salvo com sucesso!");
            //}
            //else
            //{
            //    MessageBox.Show("Não foi possivel salvar!");
            //}
            conexao.Desconectar();
        }

        public void Alterar(ModeloItemVenda venda)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update item_venda set idproduto=?, quantidade=?, ValorUnico=?, idvenda=? where iditem_venda=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Produto;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Quantidade;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.ValorUnico;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Venda;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.ID;
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

        public void Deletar(ModeloItemVenda venda)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from item_venda where iditem_venda=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.ID;
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
            OleDbCommand cmd = new OleDbCommand($"select * from item_venda where idvenda like '%{valor}%'", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from item_venda", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public ModeloItemVenda CarregaModeloItemVenda(int codigo)
        {
            ModeloItemVenda venda = new ModeloItemVenda();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select * from venda where iditem_venda=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = codigo;
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                venda.ID = Convert.ToInt32(reader["iditem_venda"]);
                venda.Produto = Convert.ToInt32(reader["idproduto"]);
                venda.Quantidade = Convert.ToInt32(reader["quantidade"]);
                venda.ValorUnico = Convert.ToDecimal(reader["ValorUnico"]);
                venda.Venda = Convert.ToInt32(reader["idvenda"]);
                MessageBox.Show("Localizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel localizar!");
            }
            conexao.Desconectar();
            return venda;
        }
    }
}
