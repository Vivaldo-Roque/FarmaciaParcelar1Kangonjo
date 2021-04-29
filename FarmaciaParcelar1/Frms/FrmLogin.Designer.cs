
namespace FarmaciaParcelar1
{
    partial class FrmLogin
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
            this.myGroupBox1 = new FarmaciaParcelar1.Tools.myGroupBox();
            this.GbSenha = new FarmaciaParcelar1.Tools.myGroupBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.GbUsuario = new FarmaciaParcelar1.Tools.myGroupBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.myGroupBox1.SuspendLayout();
            this.GbSenha.SuspendLayout();
            this.GbUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.White;
            this.myGroupBox1.Controls.Add(this.GbSenha);
            this.myGroupBox1.Controls.Add(this.GbUsuario);
            this.myGroupBox1.Controls.Add(this.label1);
            this.myGroupBox1.Controls.Add(this.label2);
            this.myGroupBox1.ForeColor = System.Drawing.Color.White;
            this.myGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(492, 284);
            this.myGroupBox1.TabIndex = 0;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Login";
            // 
            // GbSenha
            // 
            this.GbSenha.BorderColor = System.Drawing.Color.White;
            this.GbSenha.Controls.Add(this.TxtSenha);
            this.GbSenha.ForeColor = System.Drawing.Color.White;
            this.GbSenha.Location = new System.Drawing.Point(114, 154);
            this.GbSenha.Name = "GbSenha";
            this.GbSenha.Size = new System.Drawing.Size(269, 68);
            this.GbSenha.TabIndex = 13;
            this.GbSenha.TabStop = false;
            this.GbSenha.Text = "Senha";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSenha.Location = new System.Drawing.Point(23, 26);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(230, 19);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // GbUsuario
            // 
            this.GbUsuario.BorderColor = System.Drawing.Color.White;
            this.GbUsuario.Controls.Add(this.TxtUsuario);
            this.GbUsuario.ForeColor = System.Drawing.Color.White;
            this.GbUsuario.Location = new System.Drawing.Point(114, 80);
            this.GbUsuario.Name = "GbUsuario";
            this.GbUsuario.Size = new System.Drawing.Size(269, 68);
            this.GbUsuario.TabIndex = 12;
            this.GbUsuario.TabStop = false;
            this.GbUsuario.Text = "Usuário";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Location = new System.Drawing.Point(23, 26);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(230, 19);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(78)))), ((int)(((byte)(55)))));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Location = new System.Drawing.Point(258, 303);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(246, 116);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(139)))), ((int)(((byte)(54)))));
            this.BtnEntrar.FlatAppearance.BorderSize = 0;
            this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntrar.ForeColor = System.Drawing.Color.White;
            this.BtnEntrar.Location = new System.Drawing.Point(12, 303);
            this.BtnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(247, 116);
            this.BtnEntrar.TabIndex = 10;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(516, 431);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.BtnEntrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(516, 431);
            this.MinimumSize = new System.Drawing.Size(516, 431);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.GbSenha.ResumeLayout(false);
            this.GbSenha.PerformLayout();
            this.GbUsuario.ResumeLayout(false);
            this.GbUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.myGroupBox myGroupBox1;
        private Tools.myGroupBox GbSenha;
        private System.Windows.Forms.TextBox TxtSenha;
        private Tools.myGroupBox GbUsuario;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEntrar;
    }
}

