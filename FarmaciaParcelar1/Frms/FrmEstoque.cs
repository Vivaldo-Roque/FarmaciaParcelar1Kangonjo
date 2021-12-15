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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            BllEstoque bllEstoque = new BllEstoque(conexao);
            DgvEstoque.DataSource = bllEstoque.CarregarDataGridView();
        }
    }
}
