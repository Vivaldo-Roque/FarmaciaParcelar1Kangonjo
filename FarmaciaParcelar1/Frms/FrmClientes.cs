using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.Modelos;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        ModeloCliente cliente = new ModeloCliente();

        private void Campos(int x)
        {
            if(x == 0)
            {
                TxtID.Enabled = true;
                TxtBI.Enabled = false;
                TxtEmail.Enabled = false;
                TxtNome.Enabled = false;
                TxtTelefone.Enabled = false;
                DtpData.Enabled = false;
                DtpDataRegisto.Enabled = false;
                CmbEstadoCivil.Enabled = false;
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
                CmbEstadoCivil.Enabled = true;
                CmbGenero.Enabled = true;
            }
        }
        private void Buttons(int x)
        {
            if(x == 0)
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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            DataTable dataTable = new DataTable();
            OleDbCommand cmd = new OleDbCommand("select * from genero", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            CmbGenero.DataSource = dataTable;
            CmbGenero.ValueMember = "genero";
            CmbGenero.DisplayMember = "genero";

            dataTable = new DataTable();
            cmd = new OleDbCommand("select * from estadocivil", conexao.ObjetoConexao);
            adapter = new OleDbDataAdapter(cmd);
            adapter.Fill(dataTable);
            CmbEstadoCivil.DataSource = dataTable;
            CmbEstadoCivil.ValueMember = "EstadoCivil";
            CmbEstadoCivil.DisplayMember = "EstadoCivil";
            BtnConsultar_Click(sender, e);

            Buttons(0);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bllCliente = new BllCliente(conexao);
            DgvClientes.DataSource = bllCliente.CarregarDataGridView();
        }

        private void LimparDgvClientes()
        {
            DataTable DT = (DataTable)DgvClientes.DataSource;
            if (DT != null)
                DT.Clear();
        }

        private void Limpar()
        {
            TxtID.Text = "";
            TxtBI.Text = "";
            TxtEmail.Text = "";
            TxtNome.Text = "";
            TxtTelefone.Text = "";
            CmbEstadoCivil.SelectedIndex = -1;
            CmbGenero.SelectedIndex = -1;
            DtpData.Value = DateTime.Now;
            DtpDataRegisto.Value = DateTime.Now;
            LimparDgvClientes();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            cliente.Nome = TxtNome.Text;
            cliente.Telefone = Convert.ToInt32(TxtTelefone.Text);
            cliente.Genero = CmbGenero.SelectedIndex + 1;
            cliente.EstadoCivil = CmbEstadoCivil.SelectedIndex + 1;
            cliente.Email = TxtEmail.Text;
            cliente.Data = DtpData.Value;
            cliente.DataRegisto = DtpDataRegisto.Value;
            cliente.BI = TxtBI.Text;
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bllCliente = new BllCliente(conexao);
            bllCliente.Adicionar(cliente);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            cliente.ID = Convert.ToInt32(TxtID.Text);
            cliente.Nome = TxtNome.Text;
            cliente.Telefone = Convert.ToInt32(TxtTelefone.Text);
            cliente.Genero = CmbGenero.SelectedIndex + 1;
            cliente.EstadoCivil = CmbEstadoCivil.SelectedIndex + 1;
            cliente.Email = TxtEmail.Text;
            cliente.Data = DtpData.Value;
            cliente.DataRegisto = DtpDataRegisto.Value;
            cliente.BI = TxtBI.Text;
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bllCliente = new BllCliente(conexao);
            bllCliente.Alterar(cliente);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            cliente.ID = Convert.ToInt32(TxtID.Text);
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bllCliente = new BllCliente(conexao);
            bllCliente.Deletar(cliente);
            BtnLimpar_Click(sender, e);
            BtnConsultar_Click(sender, e);
            Buttons(0);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente bllCliente = new BllCliente(conexao);
            cliente.ID = Convert.ToInt32(TxtID.Text);
            cliente = bllCliente.CarregaModeloCliente(cliente.ID);
            TxtID.Text = cliente.ID.ToString();
            TxtBI.Text = cliente.BI;
            TxtEmail.Text = cliente.Email;
            TxtNome.Text = cliente.Nome;
            TxtTelefone.Text = cliente.Telefone.ToString();
            CmbEstadoCivil.SelectedIndex = cliente.EstadoCivil -1;
            CmbGenero.SelectedIndex = cliente.Genero -1;
            DtpData.Value = cliente.Data;
            DtpDataRegisto.Value = cliente.DataRegisto;
            Buttons(2);
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
