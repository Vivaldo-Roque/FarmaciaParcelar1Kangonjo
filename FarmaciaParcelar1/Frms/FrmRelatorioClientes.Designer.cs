
namespace FarmaciaParcelar1.Frms
{
    partial class FrmRelatorioClientes
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
            this.crystalReportViewerClientes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerClientes
            // 
            this.crystalReportViewerClientes.ActiveViewIndex = -1;
            this.crystalReportViewerClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerClientes.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerClientes.Name = "crystalReportViewerClientes";
            this.crystalReportViewerClientes.Size = new System.Drawing.Size(954, 688);
            this.crystalReportViewerClientes.TabIndex = 0;
            this.crystalReportViewerClientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerClientes.Load += new System.EventHandler(this.crystalReportViewerClientes_Load);
            // 
            // FrmRelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 688);
            this.Controls.Add(this.crystalReportViewerClientes);
            this.Name = "FrmRelatorioClientes";
            this.Text = "Relatório clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerClientes;
    }
}