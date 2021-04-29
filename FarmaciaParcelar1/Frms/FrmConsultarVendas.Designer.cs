
namespace FarmaciaParcelar1.Frms
{
    partial class FrmConsultarVendas
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
            this.GbCliente = new System.Windows.Forms.GroupBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.GbVenda = new System.Windows.Forms.GroupBox();
            this.DgvVendas = new System.Windows.Forms.DataGridView();
            this.GbItemsVenda = new System.Windows.Forms.GroupBox();
            this.DgvItemsVenda = new System.Windows.Forms.DataGridView();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.GbCliente.SuspendLayout();
            this.GbVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).BeginInit();
            this.GbItemsVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemsVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCliente
            // 
            this.GbCliente.Controls.Add(this.TxtTelefone);
            this.GbCliente.Controls.Add(this.label2);
            this.GbCliente.Controls.Add(this.label1);
            this.GbCliente.Controls.Add(this.CmbCliente);
            this.GbCliente.Location = new System.Drawing.Point(15, 15);
            this.GbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.GbCliente.Size = new System.Drawing.Size(1101, 107);
            this.GbCliente.TabIndex = 0;
            this.GbCliente.TabStop = false;
            this.GbCliente.Text = "Cliente";
            this.GbCliente.Enter += new System.EventHandler(this.GbCliente_Enter);
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(694, 41);
            this.TxtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(332, 26);
            this.TxtTelefone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // CmbCliente
            // 
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(109, 40);
            this.CmbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(422, 28);
            this.CmbCliente.TabIndex = 0;
            this.CmbCliente.SelectedValueChanged += new System.EventHandler(this.CmbCliente_SelectedValueChanged);
            // 
            // GbVenda
            // 
            this.GbVenda.Controls.Add(this.DgvVendas);
            this.GbVenda.Location = new System.Drawing.Point(15, 129);
            this.GbVenda.Name = "GbVenda";
            this.GbVenda.Size = new System.Drawing.Size(1035, 350);
            this.GbVenda.TabIndex = 1;
            this.GbVenda.TabStop = false;
            this.GbVenda.Text = "Vendas";
            // 
            // DgvVendas
            // 
            this.DgvVendas.AllowUserToAddRows = false;
            this.DgvVendas.AllowUserToDeleteRows = false;
            this.DgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVendas.Location = new System.Drawing.Point(7, 26);
            this.DgvVendas.Name = "DgvVendas";
            this.DgvVendas.ReadOnly = true;
            this.DgvVendas.RowHeadersWidth = 51;
            this.DgvVendas.RowTemplate.Height = 24;
            this.DgvVendas.Size = new System.Drawing.Size(1019, 318);
            this.DgvVendas.TabIndex = 0;
            this.DgvVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendas_CellDoubleClick);
            // 
            // GbItemsVenda
            // 
            this.GbItemsVenda.Controls.Add(this.DgvItemsVenda);
            this.GbItemsVenda.Location = new System.Drawing.Point(22, 485);
            this.GbItemsVenda.Name = "GbItemsVenda";
            this.GbItemsVenda.Size = new System.Drawing.Size(1035, 363);
            this.GbItemsVenda.TabIndex = 2;
            this.GbItemsVenda.TabStop = false;
            this.GbItemsVenda.Text = "Items venda";
            // 
            // DgvItemsVenda
            // 
            this.DgvItemsVenda.AllowUserToAddRows = false;
            this.DgvItemsVenda.AllowUserToDeleteRows = false;
            this.DgvItemsVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItemsVenda.Location = new System.Drawing.Point(7, 26);
            this.DgvItemsVenda.Name = "DgvItemsVenda";
            this.DgvItemsVenda.ReadOnly = true;
            this.DgvItemsVenda.RowHeadersWidth = 51;
            this.DgvItemsVenda.RowTemplate.Height = 24;
            this.DgvItemsVenda.Size = new System.Drawing.Size(1019, 331);
            this.DgvItemsVenda.TabIndex = 0;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(484, 854);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(224, 108);
            this.BtnFechar.TabIndex = 6;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 974);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GbItemsVenda);
            this.Controls.Add(this.GbVenda);
            this.Controls.Add(this.GbCliente);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultarVendas";
            this.Text = "Consultar vendas";
            this.Load += new System.EventHandler(this.FrmConsultarVendas_Load);
            this.GbCliente.ResumeLayout(false);
            this.GbCliente.PerformLayout();
            this.GbVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVendas)).EndInit();
            this.GbItemsVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvItemsVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCliente;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.GroupBox GbVenda;
        private System.Windows.Forms.DataGridView DgvVendas;
        private System.Windows.Forms.GroupBox GbItemsVenda;
        private System.Windows.Forms.DataGridView DgvItemsVenda;
        private System.Windows.Forms.Button BtnFechar;
    }
}