using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmaciaParcelar1.DAL;
using FarmaciaParcelar1.BLL;
using System.Data.OleDb;
using FarmaciaParcelar1.CrystalReports;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmRelatorioProdutos : Form
    {
        public FrmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void crystalReportViewerProdutos_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            OleDbCommand cmd = new OleDbCommand(@"SELECT * FROM produto", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "produto");
            CrystalReportProdutos crystal = new CrystalReportProdutos();
            crystal.Load("");
            crystal.SetDataSource(ds);
            crystalReportViewerProdutos.ReportSource = crystal;
        }
    }
}
