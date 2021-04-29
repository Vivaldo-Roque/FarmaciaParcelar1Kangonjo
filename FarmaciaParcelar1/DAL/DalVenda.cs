using FarmaciaParcelar1.Modelos;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.DAL
{
    class DalVenda
    {
        private readonly DalConexao conexao;

        public DalVenda(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public long Adicionar(ModeloVenda venda)
        {
            int ultimoRegistoInserido;
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into venda(idcliente, idfuncionario, DataVenda, DataPagamento, HoraVenda, nFatura, valorBrutoVenda, imposto, desconto, valorLiquidoVenda) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Cliente;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Funcionario;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.Data;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.DataPagamento;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.Hora;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.NumeroFatura;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.ValorBruto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.Imposto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.Desconto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.ValorLiquido;
            conexao.Conectar();

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel salvar!");
            }
            cmd.CommandText = "Select @@Identity";
            ultimoRegistoInserido = (int)cmd.ExecuteScalar();
            conexao.Desconectar();
            return ultimoRegistoInserido;
        }

        public void Alterar(ModeloVenda venda)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update venda set idcliente=?, idfuncionario=?, DataVenda=?, DataPagamento=?, HoraVenda=?, nFatura=?, valorBrutoVenda=?, imposto=?, desconto=?, valorLiquidoVenda=? where idvenda=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Cliente;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.Funcionario;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.Data;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.DataPagamento;
            cmd.Parameters.Add("?", OleDbType.Date).Value = venda.Hora;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = venda.NumeroFatura;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.ValorBruto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.Imposto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.Desconto;
            cmd.Parameters.Add("?", OleDbType.Numeric).Value = venda.ValorLiquido;
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

        public void Deletar(ModeloVenda venda)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from venda where idvenda=?"
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
            OleDbCommand cmd = new OleDbCommand($"select * from venda where idcliente like '%{valor}%'", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from venda", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda venda = new ModeloVenda();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select * from venda where idvenda=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = codigo;
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                venda.ID = Convert.ToInt32(reader["idvenda"]);
                venda.Cliente = Convert.ToInt32(reader["idcliente"]);
                venda.Funcionario = Convert.ToInt32(reader["idfuncionario"]);
                venda.Data = Convert.ToDateTime(reader["DataVenda"]);
                venda.DataPagamento = Convert.ToDateTime(reader["DataPagamento"]);
                venda.Hora = Convert.ToDateTime(reader["HoraVenda"]);
                venda.NumeroFatura = Convert.ToInt32(reader["nFatura"]);
                MessageBox.Show("Localizado com sucesso com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel localizar!");
            }
            conexao.Desconectar();
            return venda;
        }

        public int PegarUltimaVenda()
        {
            int count = 0;
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select count(*) from venda"
            };
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                count = Convert.ToInt32(reader["Expr1000"].ToString());
            }
            conexao.Desconectar();
            return count + 1;
        }
    }
}
