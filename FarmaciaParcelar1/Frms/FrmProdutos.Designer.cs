
namespace FarmaciaParcelar1.Frms
{
    partial class FrmProdutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpDataValidade = new System.Windows.Forms.DateTimePicker();
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.TxtValorFinal = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiadeMinima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtFabricante = new System.Windows.Forms.TextBox();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            this.TxtQuantidadeMinima = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fabricante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fornecedor:";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(126, 84);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(234, 26);
            this.TxtID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 431);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Valor:";
            // 
            // DtpDataValidade
            // 
            this.DtpDataValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataValidade.Location = new System.Drawing.Point(73, 255);
            this.DtpDataValidade.Margin = new System.Windows.Forms.Padding(4);
            this.DtpDataValidade.Name = "DtpDataValidade";
            this.DtpDataValidade.Size = new System.Drawing.Size(156, 26);
            this.DtpDataValidade.TabIndex = 12;
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(126, 310);
            this.TxtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(234, 26);
            this.TxtDescricao.TabIndex = 13;
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Location = new System.Drawing.Point(127, 367);
            this.TxtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(233, 26);
            this.TxtQuantidade.TabIndex = 14;
            // 
            // TxtValorFinal
            // 
            this.TxtValorFinal.Location = new System.Drawing.Point(113, 425);
            this.TxtValorFinal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtValorFinal.Name = "TxtValorFinal";
            this.TxtValorFinal.Size = new System.Drawing.Size(246, 26);
            this.TxtValorFinal.TabIndex = 16;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(81, 208);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(279, 26);
            this.TxtNome.TabIndex = 17;
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.quantiadeMinima,
            this.Fabricante,
            this.Fornecedor,
            this.Nome,
            this.Data,
            this.Descrição,
            this.Quantidade,
            this.ValorFinal});
            this.DgvProdutos.Location = new System.Drawing.Point(417, 118);
            this.DgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.RowHeadersWidth = 51;
            this.DgvProdutos.RowTemplate.Height = 24;
            this.DgvProdutos.Size = new System.Drawing.Size(735, 276);
            this.DgvProdutos.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idproduto";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // quantiadeMinima
            // 
            this.quantiadeMinima.DataPropertyName = "quantidademinima";
            this.quantiadeMinima.HeaderText = "Quantidade Minima";
            this.quantiadeMinima.MinimumWidth = 6;
            this.quantiadeMinima.Name = "quantiadeMinima";
            this.quantiadeMinima.ReadOnly = true;
            this.quantiadeMinima.Width = 125;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.MinimumWidth = 6;
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            this.Fabricante.Width = 125;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.MinimumWidth = 6;
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 125;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "data";
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // Descrição
            // 
            this.Descrição.DataPropertyName = "descricao";
            this.Descrição.HeaderText = "Descrição";
            this.Descrição.MinimumWidth = 6;
            this.Descrição.Name = "Descrição";
            this.Descrição.ReadOnly = true;
            this.Descrição.Width = 125;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 125;
            // 
            // ValorFinal
            // 
            this.ValorFinal.DataPropertyName = "ValorFinal";
            this.ValorFinal.HeaderText = "Valor final";
            this.ValorFinal.MinimumWidth = 6;
            this.ValorFinal.Name = "ValorFinal";
            this.ValorFinal.ReadOnly = true;
            this.ValorFinal.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(689, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 38);
            this.label10.TabIndex = 19;
            this.label10.Text = "Produtos:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(417, 13);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(119, 46);
            this.BtnLimpar.TabIndex = 24;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(891, 408);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(100, 100);
            this.BtnConsultar.TabIndex = 23;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(729, 408);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 100);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(574, 408);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 100);
            this.BtnEditar.TabIndex = 21;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(417, 408);
            this.BtnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(100, 100);
            this.BtnSalvar.TabIndex = 20;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(417, 64);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(119, 46);
            this.BtnPesquisar.TabIndex = 25;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtFabricante
            // 
            this.TxtFabricante.Location = new System.Drawing.Point(126, 125);
            this.TxtFabricante.Name = "TxtFabricante";
            this.TxtFabricante.Size = new System.Drawing.Size(233, 26);
            this.TxtFabricante.TabIndex = 26;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.Location = new System.Drawing.Point(126, 167);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(233, 26);
            this.TxtFornecedor.TabIndex = 27;
            // 
            // TxtQuantidadeMinima
            // 
            this.TxtQuantidadeMinima.Location = new System.Drawing.Point(172, 482);
            this.TxtQuantidadeMinima.Margin = new System.Windows.Forms.Padding(4);
            this.TxtQuantidadeMinima.Name = "TxtQuantidadeMinima";
            this.TxtQuantidadeMinima.Size = new System.Drawing.Size(187, 26);
            this.TxtQuantidadeMinima.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 488);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantidade Minima:";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(543, 13);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(119, 46);
            this.BtnFechar.TabIndex = 33;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1052, 408);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 100);
            this.BtnCancelar.TabIndex = 36;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(543, 65);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(119, 46);
            this.BtnNovo.TabIndex = 35;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1162, 579);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.TxtQuantidadeMinima);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.TxtFabricante);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtValorFinal);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.DtpDataValidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpDataValidade;
        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtValorFinal;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtFabricante;
        private System.Windows.Forms.TextBox TxtFornecedor;
        private System.Windows.Forms.TextBox TxtQuantidadeMinima;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiadeMinima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrição;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFinal;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnNovo;
    }
}