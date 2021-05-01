
namespace FarmaciaParcelar1.Frms
{
    partial class FrmClientes
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.DtpDataRegisto = new System.Windows.Forms.DateTimePicker();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtBI = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Género = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dataderegisto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.CmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 463);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 17);
            this.label.TabIndex = 9;
            this.label.Text = "Data de registo:";
            // 
            // DtpDataRegisto
            // 
            this.DtpDataRegisto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataRegisto.Location = new System.Drawing.Point(127, 458);
            this.DtpDataRegisto.Name = "DtpDataRegisto";
            this.DtpDataRegisto.Size = new System.Drawing.Size(128, 22);
            this.DtpDataRegisto.TabIndex = 10;
            // 
            // DtpData
            // 
            this.DtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpData.Location = new System.Drawing.Point(60, 271);
            this.DtpData.Name = "DtpData";
            this.DtpData.Size = new System.Drawing.Size(125, 22);
            this.DtpData.TabIndex = 11;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(87, 365);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(168, 22);
            this.TxtTelefone.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(65, 411);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(190, 22);
            this.TxtEmail.TabIndex = 13;
            // 
            // TxtBI
            // 
            this.TxtBI.Location = new System.Drawing.Point(43, 167);
            this.TxtBI.Name = "TxtBI";
            this.TxtBI.Size = new System.Drawing.Size(212, 22);
            this.TxtBI.TabIndex = 17;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(68, 122);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(187, 22);
            this.TxtNome.TabIndex = 18;
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.BI,
            this.Género,
            this.Data,
            this.EstadoCivil,
            this.Telefone,
            this.Email,
            this.Dataderegisto});
            this.DgvClientes.Location = new System.Drawing.Point(316, 271);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.RowHeadersWidth = 51;
            this.DgvClientes.RowTemplate.Height = 24;
            this.DgvClientes.Size = new System.Drawing.Size(857, 260);
            this.DgvClientes.TabIndex = 20;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idcliente";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
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
            // BI
            // 
            this.BI.DataPropertyName = "bi";
            this.BI.HeaderText = "BI";
            this.BI.MinimumWidth = 6;
            this.BI.Name = "BI";
            this.BI.ReadOnly = true;
            this.BI.Width = 125;
            // 
            // Género
            // 
            this.Género.DataPropertyName = "genero";
            this.Género.HeaderText = "Género";
            this.Género.MinimumWidth = 6;
            this.Género.Name = "Género";
            this.Género.ReadOnly = true;
            this.Género.Width = 125;
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
            // EstadoCivil
            // 
            this.EstadoCivil.DataPropertyName = "EstadoCivil";
            this.EstadoCivil.HeaderText = "Estado Civil";
            this.EstadoCivil.MinimumWidth = 6;
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.ReadOnly = true;
            this.EstadoCivil.Width = 125;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // Dataderegisto
            // 
            this.Dataderegisto.DataPropertyName = "DataRegisto";
            this.Dataderegisto.HeaderText = "Data de registo";
            this.Dataderegisto.MinimumWidth = 6;
            this.Dataderegisto.Name = "Dataderegisto";
            this.Dataderegisto.ReadOnly = true;
            this.Dataderegisto.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 38);
            this.label10.TabIndex = 21;
            this.label10.Text = "Clientes:";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.cleaning_broom;
            this.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpar.Location = new System.Drawing.Point(624, 26);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(148, 171);
            this.BtnLimpar.TabIndex = 25;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Estado Civil:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.binocular;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisar.Location = new System.Drawing.Point(470, 26);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(148, 171);
            this.BtnPesquisar.TabIndex = 29;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // CmbEstadoCivil
            // 
            this.CmbEstadoCivil.FormattingEnabled = true;
            this.CmbEstadoCivil.Location = new System.Drawing.Point(100, 316);
            this.CmbEstadoCivil.Name = "CmbEstadoCivil";
            this.CmbEstadoCivil.Size = new System.Drawing.Size(155, 24);
            this.CmbEstadoCivil.TabIndex = 30;
            // 
            // CmbGenero
            // 
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(87, 216);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(168, 24);
            this.CmbGenero.TabIndex = 31;
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.logout_1;
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnFechar.Location = new System.Drawing.Point(778, 26);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(148, 171);
            this.BtnFechar.TabIndex = 32;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.task_checklist_add;
            this.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNovo.Location = new System.Drawing.Point(316, 26);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(148, 171);
            this.BtnNovo.TabIndex = 33;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(43, 81);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(212, 22);
            this.TxtID.TabIndex = 35;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.task_checklist_remove;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCancelar.Location = new System.Drawing.Point(932, 537);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(148, 171);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AllowDrop = true;
            this.BtnEliminar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.bin_2;
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEliminar.Location = new System.Drawing.Point(778, 537);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(148, 171);
            this.BtnEliminar.TabIndex = 26;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.checklist;
            this.BtnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnConsultar.Location = new System.Drawing.Point(624, 537);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(148, 171);
            this.BtnConsultar.TabIndex = 24;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.pen_write_paper;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditar.Location = new System.Drawing.Point(470, 537);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(148, 171);
            this.BtnEditar.TabIndex = 23;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackgroundImage = global::FarmaciaParcelar1.Properties.Resources.add_bold;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalvar.Location = new System.Drawing.Point(316, 537);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(148, 171);
            this.BtnSalvar.TabIndex = 22;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1216, 775);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.CmbEstadoCivil);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.TxtBI);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.DtpData);
            this.Controls.Add(this.DtpDataRegisto);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker DtpDataRegisto;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtBI;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.ComboBox CmbEstadoCivil;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Género;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dataderegisto;
    }
}