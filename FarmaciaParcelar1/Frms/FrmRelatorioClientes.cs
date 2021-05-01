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
    public partial class FrmRelatorioClientes : Form
    {
        public FrmRelatorioClientes()
        {
            InitializeComponent();
        }

        private void CrystalReportViewerClientes_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioClientes_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            OleDbCommand cmd = new OleDbCommand(@"SELECT cliente.idcliente, cliente.nome, cliente.bi, genero.genero, cliente.data, EstadoCivil.EstadoCivil, cliente.telefone, cliente.email, cliente.dataRegisto
FROM     ((cliente INNER JOIN
                  EstadoCivil ON cliente.idestadoCivil = EstadoCivil.idEstadoCivil) INNER JOIN
                  genero ON cliente.idgenero = genero.idgenero)", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "RelatorioCliente");
            CrystalReportClientes crystal = new CrystalReportClientes();
            crystal.Load("");
            crystal.SetDataSource(ds);
            crystalReportViewerClientes.ReportSource = crystal;
        }
    }
}
