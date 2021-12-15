using FarmaciaParcelar1.Classes;
using System;
using System.Windows.Forms;

namespace FarmaciaParcelar1.Frms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CustomizarDesign();
        }

        private void CustomizarDesign()
        {
            PainelCadastroEditarEliminarConsultarSubMenu.Visible = false;
            PainelRelatorioSubMenu.Visible = false;
            PainelConsultarSubMenu.Visible = false;
        }



        private void EsconderSubMenu()
        {
            if (PainelCadastroEditarEliminarConsultarSubMenu.Visible == true)
                PainelCadastroEditarEliminarConsultarSubMenu.Visible = false;
            if (PainelRelatorioSubMenu.Visible == true)
                PainelRelatorioSubMenu.Visible = false;
            if (PainelConsultarSubMenu.Visible == true)
                PainelConsultarSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }else
            {
                subMenu.Visible = false;
            }
        }

        Form formAtivo = null;
        private void AbrirForm(Form form)
        {
            if(formAtivo!=null)
            {
                formAtivo.Close();
            }
            formAtivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            PainelForms.Controls.Add(form);
            PainelForms.Tag = form;
            form.BringToFront();
            form.Show();
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if(LogadoNoSistema.Acesso == 1)
            {
                LblUsuarioLogado.Text = $"Funcionário: {LogadoNoSistema.NomeDeUsuario}\nNome: {LogadoNoSistema.Nome}\nAcesso: Administrador";
            }
            else
            if(LogadoNoSistema.Acesso == 2)
            {
                BtnCadastroEditarEliminarConsultar.Visible = false;
                PainelCadastroEditarEliminarConsultarSubMenu.Visible = false;
                LblUsuarioLogado.Text = $"Funcionário: {LogadoNoSistema.NomeDeUsuario}\nNome: {LogadoNoSistema.Nome}\nAcesso: Farmacêutico(a)";
            }
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PainelCadastroEditarEliminarConsultarSubMenu);
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmFuncionarios());
            EsconderSubMenu();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmClientes());
            EsconderSubMenu();
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmProdutos());
            EsconderSubMenu();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PainelRelatorioSubMenu);
        }

        private void BtnRelatorioFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmRelatorioFuncionarios());
            EsconderSubMenu();
        }

        private void BtnRelatorioClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmRelatorioClientes());
            EsconderSubMenu();
        }

        private void BtnRelatorioProdutos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmRelatorioProdutos());
            EsconderSubMenu();
        }

        private void PainelLogo_Click(object sender, EventArgs e)
        {
            formAtivo.Close();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmVendas());
            EsconderSubMenu();
        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PainelConsultarSubMenu);
        }

        private void BtnConsultarItemsVenda_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void BtnConsultarVenda_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmConsultarVendas());
            EsconderSubMenu();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void BtnRelatorioVendas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmRelatorioVendas());
            EsconderSubMenu();
        }

        private void BtnConsultarEstoque_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmEstoque());
            EsconderSubMenu();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(new FrmInfo());
            EsconderSubMenu();
        }
    }
}
