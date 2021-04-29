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
    public partial class FrmRelatorioVendas : Form
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmRelatorios_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            OleDbCommand cmd = new OleDbCommand(@"SELECT cliente.nome, funcionario.nome AS Expr1, produto.nome AS Expr2, item_venda.quantidade, item_venda.ValorUnico, venda.DataVenda, venda.DataPagamento, venda.HoraVenda, venda.nFatura, venda.valorBrutoVenda, venda.imposto, 
                  venda.desconto, venda.valorLiquidoVenda
FROM     (funcionario INNER JOIN
                  (cliente INNER JOIN
                  ((produto INNER JOIN
                  item_venda ON produto.idproduto = item_venda.idproduto) INNER JOIN
                  venda ON item_venda.idvenda = venda.idvenda) ON cliente.idcliente = venda.idcliente) ON funcionario.idfuncionario = venda.idfuncionario)", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "RelatorioVenda");
            CrystalReportVendas crystal = new CrystalReportVendas();
            crystal.Load("");
            crystal.SetDataSource(ds);
            crystalReportViewerVendas.ReportSource = crystal;
        }
    }
}
