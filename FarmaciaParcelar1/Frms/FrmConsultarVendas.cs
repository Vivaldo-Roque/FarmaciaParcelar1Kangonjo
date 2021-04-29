using FarmaciaParcelar1.BLL;
using FarmaciaParcelar1.DAL;
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
    public partial class FrmConsultarVendas : Form
    {
        public FrmConsultarVendas()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarVendas_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllCliente cliente = new BllCliente(conexao);
            CmbCliente.ValueMember = "idcliente";
            CmbCliente.DisplayMember = "nome";
            CmbCliente.DataSource = cliente.CarregarDataGridView();
            Limpar();
            CmbCliente.SelectedIndex = -1;
        }

        public void LimparDgvVendas()
        {
            DataTable DT = (DataTable)DgvVendas.DataSource;
            if (DT != null)
                DT.Clear();
        }

        public void LimparDgvItemsVenda() 
        {
            DataTable DT = (DataTable)DgvItemsVenda.DataSource;
            if (DT != null)
                DT.Clear();
        }

        public void Limpar()
        {
            LimparDgvVendas();
            LimparDgvItemsVenda();
            TxtTelefone.Text = "";
        }

        private void CmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            Limpar();
            if (CmbCliente.SelectedIndex != -1)
            {
                DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
                BllIVenda venda = new BllIVenda(conexao);
                BllCliente cliente = new BllCliente(conexao);
                TxtTelefone.Text = cliente.CarregaModeloCliente(Convert.ToInt32(CmbCliente.SelectedValue.ToString())).Telefone.ToString();
                DgvVendas.DataSource = venda.Localizar(CmbCliente.SelectedValue.ToString());
            }
            
        }

        private void DgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllItemVenda itemsVenda = new BllItemVenda(conexao);
            DgvItemsVenda.DataSource = itemsVenda.Localizar(DgvVendas.Rows[e.RowIndex].Cells["Idvenda"].Value.ToString());
        }

        private void GbCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
