
namespace FarmaciaParcelar1.Frms
{
    partial class FrmVendas
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
            this.components = new System.ComponentModel.Container();
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TxtClienteSelecionado = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPesquisarCliente = new System.Windows.Forms.TextBox();
            this.GbProduto = new System.Windows.Forms.GroupBox();
            this.TxtQuantidadeVenda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtQuantidadeMinima = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BtnRemoverItem = new System.Windows.Forms.Button();
            this.BtnAdicionarItem = new System.Windows.Forms.Button();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtProdutoSelecionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPesquisarProduto = new System.Windows.Forms.TextBox();
            this.GbTotal = new System.Windows.Forms.GroupBox();
            this.TxtTroco = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtDinheiro = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtDescontoValorEmKZ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtDescontoPercentagem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtImpostoValorEmKZ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtImpostoPercentagem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.GbPedidos = new System.Windows.Forms.GroupBox();
            this.LvItemsVenda = new System.Windows.Forms.ListView();
            this.IdProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantidadeVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblData = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GbDataHora = new System.Windows.Forms.GroupBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.GbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.GbTotal.SuspendLayout();
            this.GbPedidos.SuspendLayout();
            this.GbDataHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TxtClienteSelecionado);
            this.GbCliente.Controls.Add(this.label);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.DgvClientes);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Controls.Add(this.TxtPesquisarCliente);
            this.GbCliente.Location = new System.Drawing.Point(51, 23);
            this.GbCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbCliente.Size = new System.Drawing.Size(1513, 279);
            this.GbCliente.TabIndex = 0;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
            this.GbCliente.Enter += new System.EventHandler(this.GbCliente_Enter);
            // 
            // TxtClienteSelecionado
            // 
            this.TxtClienteSelecionado.Location = new System.Drawing.Point(24, 180);
            this.TxtClienteSelecionado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtClienteSelecionado.Name = "TxtClienteSelecionado";
            this.TxtClienteSelecionado.ReadOnly = true;
            this.TxtClienteSelecionado.Size = new System.Drawing.Size(276, 22);
            this.TxtClienteSelecionado.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(88, 159);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(137, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Cliente Selecionado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes:";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(320, 54);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 51;
            this.DgvClientes.RowTemplate.Height = 24;
            this.DgvClientes.Size = new System.Drawing.Size(696, 196);
            this.DgvClientes.TabIndex = 2;
            this.DgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar:";
            // 
            // TxtPesquisarCliente
            // 
            this.TxtPesquisarCliente.Location = new System.Drawing.Point(24, 86);
            this.TxtPesquisarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPesquisarCliente.Name = "TxtPesquisarCliente";
            this.TxtPesquisarCliente.Size = new System.Drawing.Size(276, 22);
            this.TxtPesquisarCliente.TabIndex = 0;
            this.TxtPesquisarCliente.TextChanged += new System.EventHandler(this.TxtPesquisarCliente_TextChanged);
            // 
            // GbProduto
            // 
            this.GbProduto.Controls.Add(this.TxtQuantidadeVenda);
            this.GbProduto.Controls.Add(this.label8);
            this.GbProduto.Controls.Add(this.TxtQuantidadeMinima);
            this.GbProduto.Controls.Add(this.label19);
            this.GbProduto.Controls.Add(this.BtnRemoverItem);
            this.GbProduto.Controls.Add(this.BtnAdicionarItem);
            this.GbProduto.Controls.Add(this.TxtQuantidade);
            this.GbProduto.Controls.Add(this.label7);
            this.GbProduto.Controls.Add(this.TxtValor);
            this.GbProduto.Controls.Add(this.label6);
            this.GbProduto.Controls.Add(this.TxtProdutoSelecionado);
            this.GbProduto.Controls.Add(this.label3);
            this.GbProduto.Controls.Add(this.label4);
            this.GbProduto.Controls.Add(this.DgvProdutos);
            this.GbProduto.Controls.Add(this.label5);
            this.GbProduto.Controls.Add(this.TxtPesquisarProduto);
            this.GbProduto.Location = new System.Drawing.Point(51, 308);
            this.GbProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbProduto.Name = "GbProduto";
            this.GbProduto.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbProduto.Size = new System.Drawing.Size(1129, 340);
            this.GbProduto.TabIndex = 1;
            this.GbProduto.TabStop = false;
            this.GbProduto.Text = "Produto";
            // 
            // TxtQuantidadeVenda
            // 
            this.TxtQuantidadeVenda.Location = new System.Drawing.Point(24, 310);
            this.TxtQuantidadeVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtQuantidadeVenda.Name = "TxtQuantidadeVenda";
            this.TxtQuantidadeVenda.Size = new System.Drawing.Size(276, 22);
            this.TxtQuantidadeVenda.TabIndex = 25;
            this.TxtQuantidadeVenda.TextChanged += new System.EventHandler(this.TxtQuantidadeVenda_TextChanged);
            this.TxtQuantidadeVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidadeVenda_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Quantidade Venda:";
            // 
            // TxtQuantidadeMinima
            // 
            this.TxtQuantidadeMinima.Location = new System.Drawing.Point(24, 252);
            this.TxtQuantidadeMinima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtQuantidadeMinima.Name = "TxtQuantidadeMinima";
            this.TxtQuantidadeMinima.ReadOnly = true;
            this.TxtQuantidadeMinima.Size = new System.Drawing.Size(276, 22);
            this.TxtQuantidadeMinima.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(89, 231);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Quantidade Minima:";
            // 
            // BtnRemoverItem
            // 
            this.BtnRemoverItem.Location = new System.Drawing.Point(742, 270);
            this.BtnRemoverItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemoverItem.Name = "BtnRemoverItem";
            this.BtnRemoverItem.Size = new System.Drawing.Size(112, 52);
            this.BtnRemoverItem.TabIndex = 19;
            this.BtnRemoverItem.Text = "Remover Item";
            this.BtnRemoverItem.UseVisualStyleBackColor = true;
            this.BtnRemoverItem.Click += new System.EventHandler(this.BtnRemoverItem_Click);
            // 
            // BtnAdicionarItem
            // 
            this.BtnAdicionarItem.Location = new System.Drawing.Point(446, 270);
            this.BtnAdicionarItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdicionarItem.Name = "BtnAdicionarItem";
            this.BtnAdicionarItem.Size = new System.Drawing.Size(112, 52);
            this.BtnAdicionarItem.TabIndex = 18;
            this.BtnAdicionarItem.Text = "Adicionar Item";
            this.BtnAdicionarItem.UseVisualStyleBackColor = true;
            this.BtnAdicionarItem.Click += new System.EventHandler(this.BtnAdicionarItem_Click);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(24, 196);
            this.TxtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.ReadOnly = true;
            this.TxtQuantidade.Size = new System.Drawing.Size(276, 22);
            this.TxtQuantidade.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantidade:";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(24, 137);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(276, 22);
            this.TxtValor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor:";
            // 
            // TxtProdutoSelecionado
            // 
            this.TxtProdutoSelecionado.Location = new System.Drawing.Point(24, 88);
            this.TxtProdutoSelecionado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtProdutoSelecionado.Name = "TxtProdutoSelecionado";
            this.TxtProdutoSelecionado.ReadOnly = true;
            this.TxtProdutoSelecionado.Size = new System.Drawing.Size(276, 22);
            this.TxtProdutoSelecionado.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Produto Selecionado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Produtos:";
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(320, 57);
            this.DgvProdutos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.RowHeadersWidth = 51;
            this.DgvProdutos.RowTemplate.Height = 24;
            this.DgvProdutos.Size = new System.Drawing.Size(696, 196);
            this.DgvProdutos.TabIndex = 8;
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pesquisar:";
            // 
            // TxtPesquisarProduto
            // 
            this.TxtPesquisarProduto.Location = new System.Drawing.Point(24, 35);
            this.TxtPesquisarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtPesquisarProduto.Name = "TxtPesquisarProduto";
            this.TxtPesquisarProduto.Size = new System.Drawing.Size(276, 22);
            this.TxtPesquisarProduto.TabIndex = 6;
            this.TxtPesquisarProduto.TextChanged += new System.EventHandler(this.TxtPesquisarProduto_TextChanged);
            // 
            // GbTotal
            // 
            this.GbTotal.Controls.Add(this.TxtTroco);
            this.GbTotal.Controls.Add(this.label18);
            this.GbTotal.Controls.Add(this.TxtDinheiro);
            this.GbTotal.Controls.Add(this.label17);
            this.GbTotal.Controls.Add(this.TxtTotal);
            this.GbTotal.Controls.Add(this.label16);
            this.GbTotal.Controls.Add(this.TxtDescontoValorEmKZ);
            this.GbTotal.Controls.Add(this.label14);
            this.GbTotal.Controls.Add(this.TxtDescontoPercentagem);
            this.GbTotal.Controls.Add(this.label15);
            this.GbTotal.Controls.Add(this.TxtImpostoValorEmKZ);
            this.GbTotal.Controls.Add(this.label13);
            this.GbTotal.Controls.Add(this.TxtImpostoPercentagem);
            this.GbTotal.Controls.Add(this.label12);
            this.GbTotal.Controls.Add(this.TxtSubTotal);
            this.GbTotal.Controls.Add(this.label9);
            this.GbTotal.Location = new System.Drawing.Point(524, 21);
            this.GbTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbTotal.Name = "GbTotal";
            this.GbTotal.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbTotal.Size = new System.Drawing.Size(389, 244);
            this.GbTotal.TabIndex = 3;
            this.GbTotal.TabStop = false;
            this.GbTotal.Text = "Total";
            // 
            // TxtTroco
            // 
            this.TxtTroco.Location = new System.Drawing.Point(87, 209);
            this.TxtTroco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTroco.Name = "TxtTroco";
            this.TxtTroco.ReadOnly = true;
            this.TxtTroco.Size = new System.Drawing.Size(100, 22);
            this.TxtTroco.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "Troco:";
            // 
            // TxtDinheiro
            // 
            this.TxtDinheiro.Location = new System.Drawing.Point(87, 176);
            this.TxtDinheiro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDinheiro.Name = "TxtDinheiro";
            this.TxtDinheiro.Size = new System.Drawing.Size(100, 22);
            this.TxtDinheiro.TabIndex = 13;
            this.TxtDinheiro.TextChanged += new System.EventHandler(this.TxtDinheiro_TextChanged);
            this.TxtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDinheiro_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Dinheiro:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(87, 144);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 10;
            this.label16.Text = "Total KZ:";
            // 
            // TxtDescontoValorEmKZ
            // 
            this.TxtDescontoValorEmKZ.Location = new System.Drawing.Point(279, 91);
            this.TxtDescontoValorEmKZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescontoValorEmKZ.Name = "TxtDescontoValorEmKZ";
            this.TxtDescontoValorEmKZ.ReadOnly = true;
            this.TxtDescontoValorEmKZ.Size = new System.Drawing.Size(100, 22);
            this.TxtDescontoValorEmKZ.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "% =";
            // 
            // TxtDescontoPercentagem
            // 
            this.TxtDescontoPercentagem.Location = new System.Drawing.Point(97, 91);
            this.TxtDescontoPercentagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtDescontoPercentagem.Name = "TxtDescontoPercentagem";
            this.TxtDescontoPercentagem.Size = new System.Drawing.Size(135, 22);
            this.TxtDescontoPercentagem.TabIndex = 7;
            this.TxtDescontoPercentagem.TextChanged += new System.EventHandler(this.TxtDescontoPercentagem_TextChanged);
            this.TxtDescontoPercentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescontoPercentagem_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "Desconto:";
            // 
            // TxtImpostoValorEmKZ
            // 
            this.TxtImpostoValorEmKZ.Location = new System.Drawing.Point(279, 49);
            this.TxtImpostoValorEmKZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtImpostoValorEmKZ.Name = "TxtImpostoValorEmKZ";
            this.TxtImpostoValorEmKZ.ReadOnly = true;
            this.TxtImpostoValorEmKZ.Size = new System.Drawing.Size(100, 22);
            this.TxtImpostoValorEmKZ.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "% =";
            // 
            // TxtImpostoPercentagem
            // 
            this.TxtImpostoPercentagem.Location = new System.Drawing.Point(97, 55);
            this.TxtImpostoPercentagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtImpostoPercentagem.Name = "TxtImpostoPercentagem";
            this.TxtImpostoPercentagem.Size = new System.Drawing.Size(135, 22);
            this.TxtImpostoPercentagem.TabIndex = 3;
            this.TxtImpostoPercentagem.TextChanged += new System.EventHandler(this.TxtImpostoPercentagem_TextChanged);
            this.TxtImpostoPercentagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImpostoPercentagem_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Imposto:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(99, 21);
            this.TxtSubTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.ReadOnly = true;
            this.TxtSubTotal.Size = new System.Drawing.Size(133, 22);
            this.TxtSubTotal.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sub total KZ:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(524, 272);
            this.BtnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(153, 84);
            this.BtnGravar.TabIndex = 4;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // GbPedidos
            // 
            this.GbPedidos.Controls.Add(this.LvItemsVenda);
            this.GbPedidos.Controls.Add(this.BtnCancelar);
            this.GbPedidos.Controls.Add(this.BtnGravar);
            this.GbPedidos.Controls.Add(this.GbTotal);
            this.GbPedidos.Location = new System.Drawing.Point(51, 655);
            this.GbPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbPedidos.Name = "GbPedidos";
            this.GbPedidos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GbPedidos.Size = new System.Drawing.Size(922, 375);
            this.GbPedidos.TabIndex = 5;
            this.GbPedidos.TabStop = false;
            this.GbPedidos.Text = "items venda";
            // 
            // LvItemsVenda
            // 
            this.LvItemsVenda.BackColor = System.Drawing.SystemColors.Window;
            this.LvItemsVenda.CheckBoxes = true;
            this.LvItemsVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdProduto,
            this.Produto,
            this.ValorProduto,
            this.QuantidadeVenda,
            this.ValorTotal});
            this.LvItemsVenda.FullRowSelect = true;
            this.LvItemsVenda.GridLines = true;
            this.LvItemsVenda.HideSelection = false;
            this.LvItemsVenda.Location = new System.Drawing.Point(7, 23);
            this.LvItemsVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LvItemsVenda.Name = "LvItemsVenda";
            this.LvItemsVenda.Size = new System.Drawing.Size(511, 347);
            this.LvItemsVenda.TabIndex = 6;
            this.LvItemsVenda.UseCompatibleStateImageBehavior = false;
            this.LvItemsVenda.View = System.Windows.Forms.View.Details;
            // 
            // IdProduto
            // 
            this.IdProduto.Text = "ID Produto";
            this.IdProduto.Width = 121;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 144;
            // 
            // ValorProduto
            // 
            this.ValorProduto.Text = "Preço Produto";
            this.ValorProduto.Width = 125;
            // 
            // QuantidadeVenda
            // 
            this.QuantidadeVenda.Text = "Quantidade Venda";
            this.QuantidadeVenda.Width = 139;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Text = "Valor Total";
            this.ValorTotal.Width = 87;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(762, 272);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(153, 84);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(37, 33);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(118, 17);
            this.LblData.TabIndex = 20;
            this.LblData.Text = "Data: 12/12/1212";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(37, 90);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(129, 17);
            this.LblHora.TabIndex = 21;
            this.LblHora.Text = "Hora: 24h:24m.24s";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GbDataHora
            // 
            this.GbDataHora.Controls.Add(this.LblData);
            this.GbDataHora.Controls.Add(this.LblHora);
            this.GbDataHora.Location = new System.Drawing.Point(979, 661);
            this.GbDataHora.Name = "GbDataHora";
            this.GbDataHora.Size = new System.Drawing.Size(201, 128);
            this.GbDataHora.TabIndex = 24;
            this.GbDataHora.TabStop = false;
            this.GbDataHora.Text = "Data e Hora";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BtnFechar.Location = new System.Drawing.Point(979, 862);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(201, 163);
            this.BtnFechar.TabIndex = 33;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1055);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GbDataHora);
            this.Controls.Add(this.GbPedidos);
            this.Controls.Add(this.GbProduto);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVendas";
            this.Text = "Vendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVendas_FormClosed);
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.GbProduto.ResumeLayout(false);
            this.GbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.GbTotal.ResumeLayout(false);
            this.GbTotal.PerformLayout();
            this.GbPedidos.ResumeLayout(false);
            this.GbDataHora.ResumeLayout(false);
            this.GbDataHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPesquisarCliente;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.TextBox TxtClienteSelecionado;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GbProduto;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtProdutoSelecionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPesquisarProduto;
        private System.Windows.Forms.Button BtnAdicionarItem;
        private System.Windows.Forms.GroupBox GbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.GroupBox GbPedidos;
        private System.Windows.Forms.Button BtnRemoverItem;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.TextBox TxtDinheiro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtDescontoValorEmKZ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtDescontoPercentagem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtImpostoValorEmKZ;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtImpostoPercentagem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.TextBox TxtTroco;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListView LvItemsVenda;
        private System.Windows.Forms.TextBox TxtQuantidadeMinima;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox GbDataHora;
        private System.Windows.Forms.TextBox TxtQuantidadeVenda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader IdProduto;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader ValorProduto;
        private System.Windows.Forms.ColumnHeader QuantidadeVenda;
        private System.Windows.Forms.ColumnHeader ValorTotal;
        private System.Windows.Forms.Button BtnFechar;
    }
}