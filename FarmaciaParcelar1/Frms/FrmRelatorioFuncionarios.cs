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
    public partial class FrmRelatorioFuncionarios : Form
    {
        public FrmRelatorioFuncionarios()
        {
            InitializeComponent();
        }

        private void CrystalReportViewerFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorioFuncionarios_Load(object sender, EventArgs e)
        {
            DalConexao conexao = new DalConexao(DadosDaConexao.StringDeConexao);
            OleDbCommand cmd = new OleDbCommand(@"SELECT funcionario.idfuncionario, funcionario.nome, funcionario.bi, funcionario.usuario, funcionario.senha, genero.genero, funcionario.email, funcionario.telefone, funcionario.data, funcionario.dataRegisto, acesso.acesso
FROM     ((acesso INNER JOIN
                  funcionario ON acesso.idacesso = funcionario.idacesso) INNER JOIN
                  genero ON funcionario.idgenero = genero.idgenero)", conexao.ObjetoConexao);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "RelatorioFuncionario");
            CrystalReportFuncionarios crystal = new CrystalReportFuncionarios();
            crystal.Load("");
            crystal.SetDataSource(ds);
            crystalReportViewerFuncionarios.ReportSource = crystal;
        }
    }
}
