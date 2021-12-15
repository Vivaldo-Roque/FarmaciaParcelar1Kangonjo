
namespace FarmaciaParcelar1.Frms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PainelDeslizante = new System.Windows.Forms.Panel();
            this.BtnVendas = new System.Windows.Forms.Button();
            this.PainelConsultarSubMenu = new System.Windows.Forms.Panel();
            this.BtnConsultarEstoque = new System.Windows.Forms.Button();
            this.BtnConsultarVenda = new System.Windows.Forms.Button();
            this.BtnConsultas = new System.Windows.Forms.Button();
            this.PainelRelatorioSubMenu = new System.Windows.Forms.Panel();
            this.BtnRelatorioVendas = new System.Windows.Forms.Button();
            this.btnRelatorioProdutos = new System.Windows.Forms.Button();
            this.btnRelatorioClientes = new System.Windows.Forms.Button();
            this.btnRelatorioFuncionarios = new System.Windows.Forms.Button();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.PainelCadastroEditarEliminarConsultarSubMenu = new System.Windows.Forms.Panel();
            this.BtnProduto = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnFuncionario = new System.Windows.Forms.Button();
            this.BtnCadastroEditarEliminarConsultar = new System.Windows.Forms.Button();
            this.PainelLogo = new System.Windows.Forms.Panel();
            this.PainelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GbUsuarioLogado = new FarmaciaParcelar1.Tools.myGroupBox();
            this.LblUsuarioLogado = new System.Windows.Forms.Label();
            this.PainelDeslizante.SuspendLayout();
            this.PainelConsultarSubMenu.SuspendLayout();
            this.PainelRelatorioSubMenu.SuspendLayout();
            this.PainelCadastroEditarEliminarConsultarSubMenu.SuspendLayout();
            this.PainelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.GbUsuarioLogado.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelDeslizante
            // 
            this.PainelDeslizante.AutoScroll = true;
            this.PainelDeslizante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(67)))));
            this.PainelDeslizante.Controls.Add(this.BtnVendas);
            this.PainelDeslizante.Controls.Add(this.PainelConsultarSubMenu);
            this.PainelDeslizante.Controls.Add(this.BtnConsultas);
            this.PainelDeslizante.Controls.Add(this.PainelRelatorioSubMenu);
            this.PainelDeslizante.Controls.Add(this.BtnRelatorio);
            this.PainelDeslizante.Controls.Add(this.PainelCadastroEditarEliminarConsultarSubMenu);
            this.PainelDeslizante.Controls.Add(this.BtnCadastroEditarEliminarConsultar);
            this.PainelDeslizante.Controls.Add(this.PainelLogo);
            this.PainelDeslizante.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelDeslizante.Location = new System.Drawing.Point(0, 0);
            this.PainelDeslizante.Name = "PainelDeslizante";
            this.PainelDeslizante.Size = new System.Drawing.Size(367, 614);
            this.PainelDeslizante.TabIndex = 6;
            // 
            // BtnVendas
            // 
            this.BtnVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVendas.FlatAppearance.BorderSize = 0;
            this.BtnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVendas.Location = new System.Drawing.Point(0, 650);
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnVendas.Size = new System.Drawing.Size(346, 45);
            this.BtnVendas.TabIndex = 9;
            this.BtnVendas.Text = "Vendas";
            this.BtnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVendas.UseVisualStyleBackColor = true;
            this.BtnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // PainelConsultarSubMenu
            // 
            this.PainelConsultarSubMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.PainelConsultarSubMenu.Controls.Add(this.BtnConsultarEstoque);
            this.PainelConsultarSubMenu.Controls.Add(this.BtnConsultarVenda);
            this.PainelConsultarSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelConsultarSubMenu.Location = new System.Drawing.Point(0, 551);
            this.PainelConsultarSubMenu.Name = "PainelConsultarSubMenu";
            this.PainelConsultarSubMenu.Size = new System.Drawing.Size(346, 99);
            this.PainelConsultarSubMenu.TabIndex = 8;
            // 
            // BtnConsultarEstoque
            // 
            this.BtnConsultarEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultarEstoque.FlatAppearance.BorderSize = 0;
            this.BtnConsultarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarEstoque.Location = new System.Drawing.Point(0, 45);
            this.BtnConsultarEstoque.Name = "BtnConsultarEstoque";
            this.BtnConsultarEstoque.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnConsultarEstoque.Size = new System.Drawing.Size(346, 45);
            this.BtnConsultarEstoque.TabIndex = 2;
            this.BtnConsultarEstoque.Text = "Estoque";
            this.BtnConsultarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarEstoque.UseVisualStyleBackColor = true;
            this.BtnConsultarEstoque.Click += new System.EventHandler(this.BtnConsultarEstoque_Click);
            // 
            // BtnConsultarVenda
            // 
            this.BtnConsultarVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultarVenda.FlatAppearance.BorderSize = 0;
            this.BtnConsultarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarVenda.Location = new System.Drawing.Point(0, 0);
            this.BtnConsultarVenda.Name = "BtnConsultarVenda";
            this.BtnConsultarVenda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnConsultarVenda.Size = new System.Drawing.Size(346, 45);
            this.BtnConsultarVenda.TabIndex = 1;
            this.BtnConsultarVenda.Text = "Vendas";
            this.BtnConsultarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarVenda.UseVisualStyleBackColor = true;
            this.BtnConsultarVenda.Click += new System.EventHandler(this.BtnConsultarVenda_Click);
            // 
            // BtnConsultas
            // 
            this.BtnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConsultas.FlatAppearance.BorderSize = 0;
            this.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultas.Location = new System.Drawing.Point(0, 506);
            this.BtnConsultas.Name = "BtnConsultas";
            this.BtnConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnConsultas.Size = new System.Drawing.Size(346, 45);
            this.BtnConsultas.TabIndex = 7;
            this.BtnConsultas.Text = "Consultar";
            this.BtnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultas.UseVisualStyleBackColor = true;
            this.BtnConsultas.Click += new System.EventHandler(this.BtnConsultas_Click);
            // 
            // PainelRelatorioSubMenu
            // 
            this.PainelRelatorioSubMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.PainelRelatorioSubMenu.Controls.Add(this.BtnRelatorioVendas);
            this.PainelRelatorioSubMenu.Controls.Add(this.btnRelatorioProdutos);
            this.PainelRelatorioSubMenu.Controls.Add(this.btnRelatorioClientes);
            this.PainelRelatorioSubMenu.Controls.Add(this.btnRelatorioFuncionarios);
            this.PainelRelatorioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelRelatorioSubMenu.Location = new System.Drawing.Point(0, 319);
            this.PainelRelatorioSubMenu.Name = "PainelRelatorioSubMenu";
            this.PainelRelatorioSubMenu.Size = new System.Drawing.Size(346, 187);
            this.PainelRelatorioSubMenu.TabIndex = 5;
            // 
            // BtnRelatorioVendas
            // 
            this.BtnRelatorioVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRelatorioVendas.FlatAppearance.BorderSize = 0;
            this.BtnRelatorioVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorioVendas.Location = new System.Drawing.Point(0, 135);
            this.BtnRelatorioVendas.Name = "BtnRelatorioVendas";
            this.BtnRelatorioVendas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnRelatorioVendas.Size = new System.Drawing.Size(346, 45);
            this.BtnRelatorioVendas.TabIndex = 3;
            this.BtnRelatorioVendas.Text = "Vendas";
            this.BtnRelatorioVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorioVendas.UseVisualStyleBackColor = true;
            this.BtnRelatorioVendas.Click += new System.EventHandler(this.BtnRelatorioVendas_Click);
            // 
            // btnRelatorioProdutos
            // 
            this.btnRelatorioProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorioProdutos.FlatAppearance.BorderSize = 0;
            this.btnRelatorioProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioProdutos.Location = new System.Drawing.Point(0, 90);
            this.btnRelatorioProdutos.Name = "btnRelatorioProdutos";
            this.btnRelatorioProdutos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRelatorioProdutos.Size = new System.Drawing.Size(346, 45);
            this.btnRelatorioProdutos.TabIndex = 2;
            this.btnRelatorioProdutos.Text = "Produtos";
            this.btnRelatorioProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioProdutos.UseVisualStyleBackColor = true;
            this.btnRelatorioProdutos.Click += new System.EventHandler(this.BtnRelatorioProdutos_Click);
            // 
            // btnRelatorioClientes
            // 
            this.btnRelatorioClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorioClientes.FlatAppearance.BorderSize = 0;
            this.btnRelatorioClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioClientes.Location = new System.Drawing.Point(0, 45);
            this.btnRelatorioClientes.Name = "btnRelatorioClientes";
            this.btnRelatorioClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRelatorioClientes.Size = new System.Drawing.Size(346, 45);
            this.btnRelatorioClientes.TabIndex = 1;
            this.btnRelatorioClientes.Text = "Clientes";
            this.btnRelatorioClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioClientes.UseVisualStyleBackColor = true;
            this.btnRelatorioClientes.Click += new System.EventHandler(this.BtnRelatorioClientes_Click);
            // 
            // btnRelatorioFuncionarios
            // 
            this.btnRelatorioFuncionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorioFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnRelatorioFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorioFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.btnRelatorioFuncionarios.Name = "btnRelatorioFuncionarios";
            this.btnRelatorioFuncionarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRelatorioFuncionarios.Size = new System.Drawing.Size(346, 45);
            this.btnRelatorioFuncionarios.TabIndex = 0;
            this.btnRelatorioFuncionarios.Text = "Funcionários";
            this.btnRelatorioFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorioFuncionarios.UseVisualStyleBackColor = true;
            this.btnRelatorioFuncionarios.Click += new System.EventHandler(this.BtnRelatorioFuncionarios_Click);
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRelatorio.FlatAppearance.BorderSize = 0;
            this.BtnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorio.Location = new System.Drawing.Point(0, 274);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRelatorio.Size = new System.Drawing.Size(346, 45);
            this.BtnRelatorio.TabIndex = 4;
            this.BtnRelatorio.Text = "Relatório";
            this.BtnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            this.BtnRelatorio.Click += new System.EventHandler(this.BtnRelatorio_Click);
            // 
            // PainelCadastroEditarEliminarConsultarSubMenu
            // 
            this.PainelCadastroEditarEliminarConsultarSubMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.PainelCadastroEditarEliminarConsultarSubMenu.Controls.Add(this.BtnProduto);
            this.PainelCadastroEditarEliminarConsultarSubMenu.Controls.Add(this.BtnCliente);
            this.PainelCadastroEditarEliminarConsultarSubMenu.Controls.Add(this.BtnFuncionario);
            this.PainelCadastroEditarEliminarConsultarSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelCadastroEditarEliminarConsultarSubMenu.Location = new System.Drawing.Point(0, 130);
            this.PainelCadastroEditarEliminarConsultarSubMenu.Name = "PainelCadastroEditarEliminarConsultarSubMenu";
            this.PainelCadastroEditarEliminarConsultarSubMenu.Size = new System.Drawing.Size(346, 144);
            this.PainelCadastroEditarEliminarConsultarSubMenu.TabIndex = 2;
            // 
            // BtnProduto
            // 
            this.BtnProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProduto.FlatAppearance.BorderSize = 0;
            this.BtnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProduto.Location = new System.Drawing.Point(0, 90);
            this.BtnProduto.Name = "BtnProduto";
            this.BtnProduto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnProduto.Size = new System.Drawing.Size(346, 45);
            this.BtnProduto.TabIndex = 2;
            this.BtnProduto.Text = "Produto";
            this.BtnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProduto.UseVisualStyleBackColor = true;
            this.BtnProduto.Click += new System.EventHandler(this.BtnProduto_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Location = new System.Drawing.Point(0, 45);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnCliente.Size = new System.Drawing.Size(346, 45);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnFuncionario
            // 
            this.BtnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFuncionario.FlatAppearance.BorderSize = 0;
            this.BtnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionario.Location = new System.Drawing.Point(0, 0);
            this.BtnFuncionario.Name = "BtnFuncionario";
            this.BtnFuncionario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnFuncionario.Size = new System.Drawing.Size(346, 45);
            this.BtnFuncionario.TabIndex = 0;
            this.BtnFuncionario.Text = "Funcionário";
            this.BtnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFuncionario.UseVisualStyleBackColor = true;
            this.BtnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // BtnCadastroEditarEliminarConsultar
            // 
            this.BtnCadastroEditarEliminarConsultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCadastroEditarEliminarConsultar.FlatAppearance.BorderSize = 0;
            this.BtnCadastroEditarEliminarConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastroEditarEliminarConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastroEditarEliminarConsultar.Location = new System.Drawing.Point(0, 85);
            this.BtnCadastroEditarEliminarConsultar.Name = "BtnCadastroEditarEliminarConsultar";
            this.BtnCadastroEditarEliminarConsultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCadastroEditarEliminarConsultar.Size = new System.Drawing.Size(346, 45);
            this.BtnCadastroEditarEliminarConsultar.TabIndex = 1;
            this.BtnCadastroEditarEliminarConsultar.Text = "Cadastro / Editar / Eliminar / Consultar";
            this.BtnCadastroEditarEliminarConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCadastroEditarEliminarConsultar.UseVisualStyleBackColor = true;
            this.BtnCadastroEditarEliminarConsultar.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // PainelLogo
            // 
            this.PainelLogo.BackColor = System.Drawing.Color.LightGreen;
            this.PainelLogo.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.farmcia_logo;
            this.PainelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PainelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelLogo.Location = new System.Drawing.Point(0, 0);
            this.PainelLogo.Name = "PainelLogo";
            this.PainelLogo.Size = new System.Drawing.Size(346, 85);
            this.PainelLogo.TabIndex = 0;
            this.PainelLogo.Click += new System.EventHandler(this.PainelLogo_Click);
            // 
            // PainelForms
            // 
            this.PainelForms.BackColor = System.Drawing.Color.LightGreen;
            this.PainelForms.Controls.Add(this.pictureBox1);
            this.PainelForms.Controls.Add(this.GbUsuarioLogado);
            this.PainelForms.Controls.Add(this.menuStrip1);
            this.PainelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelForms.Location = new System.Drawing.Point(367, 0);
            this.PainelForms.Name = "PainelForms";
            this.PainelForms.Size = new System.Drawing.Size(659, 614);
            this.PainelForms.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::FarmaciaParcelar1.Properties.Resources.farmcia_logo;
            this.pictureBox1.Location = new System.Drawing.Point(181, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hELPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(659, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // GbUsuarioLogado
            // 
            this.GbUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GbUsuarioLogado.BorderColor = System.Drawing.Color.White;
            this.GbUsuarioLogado.Controls.Add(this.LblUsuarioLogado);
            this.GbUsuarioLogado.Location = new System.Drawing.Point(405, 470);
            this.GbUsuarioLogado.Name = "GbUsuarioLogado";
            this.GbUsuarioLogado.Size = new System.Drawing.Size(242, 132);
            this.GbUsuarioLogado.TabIndex = 6;
            this.GbUsuarioLogado.TabStop = false;
            this.GbUsuarioLogado.Text = "Funcionário Logado:";
            // 
            // LblUsuarioLogado
            // 
            this.LblUsuarioLogado.AutoSize = true;
            this.LblUsuarioLogado.ForeColor = System.Drawing.Color.Blue;
            this.LblUsuarioLogado.Location = new System.Drawing.Point(23, 37);
            this.LblUsuarioLogado.Name = "LblUsuarioLogado";
            this.LblUsuarioLogado.Size = new System.Drawing.Size(179, 60);
            this.LblUsuarioLogado.TabIndex = 0;
            this.LblUsuarioLogado.Text = "Usuário: root\r\nNome: Vivaldo Roque\r\nAcesso: Administrador";
            this.LblUsuarioLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 614);
            this.Controls.Add(this.PainelForms);
            this.Controls.Add(this.PainelDeslizante);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(966, 608);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema gerenciador de Farmácia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PainelDeslizante.ResumeLayout(false);
            this.PainelConsultarSubMenu.ResumeLayout(false);
            this.PainelRelatorioSubMenu.ResumeLayout(false);
            this.PainelCadastroEditarEliminarConsultarSubMenu.ResumeLayout(false);
            this.PainelForms.ResumeLayout(false);
            this.PainelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbUsuarioLogado.ResumeLayout(false);
            this.GbUsuarioLogado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PainelDeslizante;
        private System.Windows.Forms.Panel PainelCadastroEditarEliminarConsultarSubMenu;
        private System.Windows.Forms.Button BtnProduto;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnFuncionario;
        private System.Windows.Forms.Button BtnCadastroEditarEliminarConsultar;
        private System.Windows.Forms.Panel PainelLogo;
        private System.Windows.Forms.Panel PainelRelatorioSubMenu;
        private System.Windows.Forms.Button btnRelatorioProdutos;
        private System.Windows.Forms.Button btnRelatorioClientes;
        private System.Windows.Forms.Button btnRelatorioFuncionarios;
        private System.Windows.Forms.Button BtnRelatorio;
        private System.Windows.Forms.Panel PainelForms;
        private Tools.myGroupBox GbUsuarioLogado;
        private System.Windows.Forms.Label LblUsuarioLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PainelConsultarSubMenu;
        private System.Windows.Forms.Button BtnConsultarVenda;
        private System.Windows.Forms.Button BtnConsultas;
        private System.Windows.Forms.Button BtnRelatorioVendas;
        private System.Windows.Forms.Button BtnConsultarEstoque;
        private System.Windows.Forms.Button BtnVendas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}