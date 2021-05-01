using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using FarmaciaParcelar1.Modelos;
using System.Data;
using FarmaciaParcelar1.Classes;
using System.Windows.Forms;

namespace FarmaciaParcelar1.DAL
{
    class DalFuncionario
    {
        private readonly DalConexao conexao;

        public DalFuncionario(DalConexao conexao)
        {
            this.conexao = conexao;
        }

        public void Adicionar(ModeloFuncionario funcionario)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "insert into funcionario(nome, bi, usuario, senha, idgenero, email, telefone, data, dataRegisto, idacesso) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)",
                CommandType = CommandType.Text,
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value= funcionario.BI;
            cmd.Parameters.Add("?", OleDbType.WChar).Value=funcionario.Usuario.Trim().ToLower().ToString();
            cmd.Parameters.Add("?", OleDbType.WChar).Value=funcionario.Senha.Trim().ToLower().ToString();
            cmd.Parameters.Add("?", OleDbType.Integer).Value=funcionario.Genero;
            cmd.Parameters.Add("?", OleDbType.WChar).Value=funcionario.Email;
            cmd.Parameters.Add("?", OleDbType.Integer).Value=funcionario.Telefone;
            cmd.Parameters.Add("?", OleDbType.Date).Value=funcionario.Data;
            cmd.Parameters.Add("?", OleDbType.Date).Value=funcionario.DataRegisto;
            cmd.Parameters.Add("?", OleDbType.Integer).Value=funcionario.Acesso;

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

        public void Alterar(ModeloFuncionario funcionario)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "update funcionario set nome=?, bi=?, usuario=?, senha=?, idgenero=?, email=?, telefone=?, data=?, dataRegisto=?, idacesso=? where idfuncionario=?",
                CommandType = CommandType.Text,
            };
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Nome;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.BI;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Usuario.Trim().ToLower().ToString();
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Senha.Trim().ToLower().ToString();
            cmd.Parameters.Add("?", OleDbType.Integer).Value = funcionario.Genero;
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Email;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = funcionario.Telefone;
            cmd.Parameters.Add("?", OleDbType.Date).Value = funcionario.Data;
            cmd.Parameters.Add("?", OleDbType.Date).Value = funcionario.DataRegisto;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = funcionario.Acesso;
            cmd.Parameters.Add("?", OleDbType.Integer).Value = funcionario.ID;
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

        public void Deletar(ModeloFuncionario funcionario)
        {
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "delete from funcionario where idfuncionario=?",
                CommandType = CommandType.Text
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value=funcionario.ID;
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

        public DataTable Localizar (String valor)
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from funcionario where nome like '%{valor}%'",conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CarregarDataGridView()
        {
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand(@"SELECT funcionario.idfuncionario, funcionario.nome, funcionario.bi, funcionario.usuario, funcionario.senha, genero.genero, funcionario.email, funcionario.telefone, funcionario.data, funcionario.dataRegisto, acesso.acesso
FROM genero INNER JOIN (acesso INNER JOIN funcionario ON acesso.idacesso = funcionario.idacesso) ON genero.idgenero = funcionario.idgenero;
", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public ModeloFuncionario CarregaModeloFuncionario(int codigo)
        {
            ModeloFuncionario funcionario = new ModeloFuncionario();
            OleDbCommand cmd = new OleDbCommand
            {
                Connection = conexao.ObjetoConexao,
                CommandText = "select * from funcionario where idfuncionario=?",
                CommandType = CommandType.Text,
            };
            cmd.Parameters.Add("?", OleDbType.Integer).Value = codigo;
            conexao.Conectar();
            OleDbDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                reader.Read();
                funcionario.ID = Convert.ToInt32(reader["idfuncionario"]);
                funcionario.Nome = Convert.ToString(reader["nome"]);
                funcionario.BI = Convert.ToString(reader["bi"]);
                funcionario.Usuario = Convert.ToString(reader["usuario"]);
                funcionario.Senha = Convert.ToString(reader["senha"]);
                funcionario.Genero = Convert.ToInt32(reader["idgenero"]);
                funcionario.Email = Convert.ToString(reader["email"]);
                funcionario.Telefone = Convert.ToInt32(reader["telefone"]);
                funcionario.Data = Convert.ToDateTime(reader["data"]);
                funcionario.DataRegisto = Convert.ToDateTime(reader["dataRegisto"]);
                funcionario.Acesso = Convert.ToInt32(reader["idacesso"]);
                MessageBox.Show("Localizado com sucesso com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel localizar!");
            }
            conexao.Desconectar();
            return funcionario;
        }

        //Classe responsavel por verificar o login e salvar o nome do usuario na classe acima
        public bool VerificarLogin(ModeloFuncionario funcionario)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from funcionario where usuario=? and senha=?";
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Usuario.Trim().ToLower().ToString();
            cmd.Parameters.Add("?", OleDbType.WChar).Value = funcionario.Senha.Trim().ToLower().ToString();
            conexao.Conectar();
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                
                reader.Read();
                LogadoNoSistema.ID = Convert.ToInt32(reader["idfuncionario"].ToString());
                LogadoNoSistema.NomeDeUsuario = reader["usuario"].ToString();
                LogadoNoSistema.Nome = reader["nome"].ToString();
                LogadoNoSistema.Acesso = Convert.ToInt32(reader["idacesso"]);
                conexao.Desconectar();
                return true;
            }
            else
            {
                conexao.Desconectar();
                return false;
            }
        }
    }
}
