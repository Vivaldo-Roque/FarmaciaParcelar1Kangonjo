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
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.Frms;

namespace FarmaciaParcelar1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllFuncionario bllFuncionario = new BllFuncionario(conexao);
            CmbUsuario.DataSource = bllFuncionario.CarregarDataGridView();
            CmbUsuario.DisplayMember = "usuario";
            CmbUsuario.ValueMember = "usuario";
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            ModeloFuncionario funcionario = new ModeloFuncionario();
            bool verificador;
            funcionario.Usuario = CmbUsuario.SelectedValue.ToString();
            funcionario.Senha = TxtSenha.Text;


            if (String.IsNullOrEmpty(funcionario.Usuario) == true || String.IsNullOrEmpty(funcionario.Senha) == true)
            {
                MessageBox.Show("Os campos Usuário e Senha não podem estar vazios!", "AVISO!");
            }
            else
            {
                //MessageBox.Show("BUG", "DEBUG");
                DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
                BllFuncionario bllFuncionario = new BllFuncionario(conexao);
                verificador = bllFuncionario.VerificarLogin(funcionario);
                if (verificador == true)
                {
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide();
                    principal.Show();
                }
                else if(verificador == false)
                {
                    MessageBox.Show("Os campos Usuário e Senha estão incorretos!", "AVISO!");
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEntrar_Click(sender, e);
            }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEntrar_Click(sender, e);
            }
        }

        private void CmbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
