
namespace FarmaciaParcelar1.Frms
{
    partial class FrmRelatorioFuncionarios
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
            this.crystalReportViewerFuncionarios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerFuncionarios
            // 
            this.crystalReportViewerFuncionarios.ActiveViewIndex = -1;
            this.crystalReportViewerFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerFuncionarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerFuncionarios.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerFuncionarios.Name = "crystalReportViewerFuncionarios";
            this.crystalReportViewerFuncionarios.Size = new System.Drawing.Size(954, 688);
            this.crystalReportViewerFuncionarios.TabIndex = 0;
            this.crystalReportViewerFuncionarios.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerFuncionarios.Load += new System.EventHandler(this.CrystalReportViewerFuncionarios_Load);
            // 
            // FrmRelatorioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 688);
            this.Controls.Add(this.crystalReportViewerFuncionarios);
            this.Name = "FrmRelatorioFuncionarios";
            this.Text = "Relatório funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioFuncionarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerFuncionarios;
    }
}