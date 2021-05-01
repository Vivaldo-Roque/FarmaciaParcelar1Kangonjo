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
    //Classe responsavel por fazer o CRUD na tabela cliente
    class DalCliente
    {
        private readonly DalConexao conexao;

        public DalCliente(DalConexao conexao)
        {
            this.conexao = conexao;
        }
        public void Adicionar(ModeloCliente cliente)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into cliente (nome, bi, idgenero, data, idestadoCivil, telefone, email, dataRegisto) values (?, ?, ?, ?, ?, ?, ?, ?)"
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.BI;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.Genero;
            cmd.Parameters.Add("?", OleDbType.Date).Value = cliente.Data;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.EstadoCivil;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.Telefone;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.Email;
            cmd.Parameters.Add("?", OleDbType.Date).Value = cliente.DataRegisto;
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

        public void Alterar(ModeloCliente cliente)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update cliente set nome=?, bi=?, idgenero=?, data=?, idestadoCivil=?, telefone=?, email=?, dataRegisto=? where idcliente=?"
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.BI;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.Genero;
            cmd.Parameters.Add("?", OleDbType.Date).Value = cliente.Data;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.EstadoCivil;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.Telefone;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = cliente.Email;
            cmd.Parameters.Add("?", OleDbType.Date).Value = cliente.DataRegisto;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.ID;
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

        public void Deletar(ModeloCliente cliente)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from cliente where idcliente=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = cliente.ID;
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
            OleDbCommand cmd = new OleDbCommand($"select * from cliente where nome like '%{valor}%'", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand(@"SELECT cliente.idcliente, cliente.nome, cliente.bi, genero.genero, cliente.data, EstadoCivil.EstadoCivil, cliente.telefone, cliente.email, cliente.dataRegisto
FROM (cliente INNER JOIN EstadoCivil ON cliente.idestadoCivil = EstadoCivil.idEstadoCivil) INNER JOIN genero ON cliente.idgenero = genero.idgenero;
", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente cliente = new ModeloCliente();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select * from cliente where idcliente=?"
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = codigo;
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                cliente.ID = Convert.ToInt32(reader["idcliente"]);
                cliente.Nome = Convert.ToString(reader["nome"]);
                cliente.BI = Convert.ToString(reader["bi"]);
                cliente.Genero = Convert.ToInt32(reader["idgenero"]);
                cliente.Data = Convert.ToDateTime(reader["data"]);
                cliente.EstadoCivil = Convert.ToInt32(reader["idgenero"]);
                cliente.Telefone = Convert.ToInt32(reader["telefone"]);
                cliente.Email = Convert.ToString(reader["email"]);
                cliente.DataRegisto = Convert.ToDateTime(reader["dataRegisto"]);
                MessageBox.Show("Localizado com sucesso com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel localizar!");
            }
            conexao.Desconectar();
            return cliente;
        }
    }
}
