
namespace FarmaciaParcelar1.Frms
{
    partial class FrmRelatorioVendas
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
            this.crystalReportViewerVendas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerVendas
            // 
            this.crystalReportViewerVendas.ActiveViewIndex = -1;
            this.crystalReportViewerVendas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerVendas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerVendas.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerVendas.Name = "crystalReportViewerVendas";
            this.crystalReportViewerVendas.Size = new System.Drawing.Size(954, 688);
            this.crystalReportViewerVendas.TabIndex = 0;
            this.crystalReportViewerVendas.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 688);
            this.Controls.Add(this.crystalReportViewerVendas);
            this.Name = "FrmRelatorioVendas";
            this.Text = "Relatório vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerVendas;
    }
}