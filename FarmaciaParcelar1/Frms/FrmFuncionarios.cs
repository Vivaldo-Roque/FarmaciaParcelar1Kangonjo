using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaParcelar1.Modelos;
using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.DAL;
using System.Data.OleDb;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmFuncionarios : Form
    {
        ModeloFuncionario funcionario = new ModeloFuncionario();
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void LimparDgvFuncionarios()
        {
            DataTable DT = (DataTable)DgvFuncionarios.DataSource;
            if (DT != null)
                DT.Clear();
        }


        private void Campos(int x)
        {
            if (x == 0)
            {
                TxtID.Enabled = true;
                TxtBI.Enabled = false;
                TxtEmail.Enabled = false;
                TxtNome.Enabled = false;
                TxtTelefone.Enabled = false;
                TxtUsuario.Enabled = false;
                TxtSenha.Enabled = false;
                CmbAcesso.Enabled = false;
                DtpData.Enabled = false;
                DtpDataRegisto.Enabled = false;
                CmbGenero.Enabled = false;
            }
            else
            if (x == 1)
            {
                TxtBI.Enabled = true;
                TxtEmail.Enabled = true;
                TxtID.Enabled = false;
                TxtNome.Enabled = true;
                TxtTelefone.Enabled = true;
                DtpData.Enabled = true;
                DtpDataRegisto.Enabled = true;
                CmbGenero.Enabled = true;
                TxtUsuario.Enabled = true;
                TxtSenha.Enabled = true;
                CmbAcesso.Enabled = true;
            }
        }
        private void Buttons(int x)
        {
            if (x == 0)
            {
                BtnNovo.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnConsultar.Enabled = true;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnFechar.Enabled = true;
                BtnLimpar.Enabled = false;
                BtnPesquisar.Enabled = true;
                BtnCancelar.Enabled = false;
                Campos(0);

            }
            else
            if (x == 1)
            {
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = true;
                BtnConsultar.Enabled = false;
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnFechar.Enabled = false;
                BtnLimpar.Enabled = true;
                BtnPesquisar.Enabled = false;
                BtnCancelar.Enabled = true;
                Campos(1);
                Limpar();
            }
            else
            if (x == 2)
            {
                BtnNovo.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnConsultar.Enabled = false;
                BtnEditar.Enabled = true;
                BtnEliminar.Enabled = true;
                BtnFechar.Enabled = false;
                BtnLimpar.Enabled = true;
                BtnPesquisar.Enabled = false;
                BtnCancelar.Enabled = true;
                Campos(1);
            }
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand($"select * from genero", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            CmbGenero.DataSource = dataTable;
            CmbGenero.ValueMember = "genero";
            CmbGenero.DisplayMember = "genero";

            dataTable = new DataTable();
            cmd = new OleDbCommand("select * from acesso", conexao.ObjetoConexao);
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            CmbAcesso.DataSource = dataTable;
            CmbAcesso.ValueMember = "acesso";
            CmbAcesso.DisplayMember = "acesso";
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = TxtNome.Text;
            funcionario.Data = DtpData.Value;
            funcionario.Email = TxtEmail.Text;
            funcionario.Telefone = Convert.ToInt32(TxtTelefone.Text);
            funcionario.Usuario = TxtUsuario.Text;
            funcionario.Senha = TxtSenha.Text;
            funcionario.BI = TxtBI.Text;
            funcionario.DataRegisto = DtpDataRegisto.Value;
            funcionario.Genero = CmbGenero.SelectedIndex + 1;
            funcionario.Acesso = CmbAcesso.SelectedIndex + 1;

            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bll = new BllFuncionario(conexao);
            bll.Adicionar(funcionario);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            funcionario.ID = Convert.ToInt32(TxtID.Text);
            funcionario.Nome = TxtNome.Text;
            funcionario.Data = DtpData.Value;
            funcionario.Email = TxtEmail.Text;
            funcionario.Telefone = Convert.ToInt32(TxtTelefone.Text);
            funcionario.Usuario = TxtUsuario.Text;
            funcionario.Senha = TxtSenha.Text;
            funcionario.BI = TxtBI.Text;
            funcionario.DataRegisto = DtpDataRegisto.Value;
            funcionario.Genero = CmbGenero.SelectedIndex + 1;
            funcionario.Acesso = CmbAcesso.SelectedIndex + 1;

            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bll = new BllFuncionario(conexao);
            bll.Alterar(funcionario);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            funcionario.ID = Convert.ToInt32(TxtID.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bll = new BllFuncionario(conexao);
            bll.Deletar(funcionario);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bll = new BllFuncionario(conexao);
            DgvFuncionarios.DataSource = bll.CarregarDataGridView();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bll = new BllFuncionario(conexao);
            funcionario.ID = Convert.ToInt32(TxtID.Text);
            funcionario = bll.CarregaModeloFuncionario(funcionario.ID);
            TxtNome.Text = funcionario.Nome;
            TxtBI.Text = funcionario.BI;
            TxtEmail.Text = funcionario.Email;
            CmbAcesso.SelectedIndex = funcionario.Acesso - 1;
            CmbGenero.SelectedIndex = funcionario.Genero - 1;
            TxtSenha.Text = funcionario.Senha;
            TxtTelefone.Text = funcionario.Telefone.ToString();
            TxtUsuario.Text = funcionario.Usuario;
            DtpData.Value = funcionario.Data;
            DtpDataRegisto.Value = funcionario.DataRegisto;
            Buttons(2);
        }

        private void Limpar()
        {
            TxtID.Text = "";
            TxtNome.Text = "";
            TxtBI.Text = "";
            TxtEmail.Text = "";
            DtpData.Value = DateTime.Now;
            DtpDataRegisto.Value = DateTime.Now;
            CmbGenero.SelectedIndex = -1;
            CmbAcesso.SelectedIndex = -1;
            TxtSenha.Text = "";
            TxtTelefone.Text = "";
            TxtUsuario.Text = "";
            LimparDgvFuncionarios();
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Buttons(1);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Buttons(0);
            Limpar();
        }
    }
}
