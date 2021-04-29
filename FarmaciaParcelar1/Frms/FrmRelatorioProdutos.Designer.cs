
namespace FarmaciaParcelar1.Frms
{
    partial class FrmRelatorioProdutos
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
            this.crystalReportViewerProdutos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerProdutos
            // 
            this.crystalReportViewerProdutos.ActiveViewIndex = -1;
            this.crystalReportViewerProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerProdutos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerProdutos.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerProdutos.Name = "crystalReportViewerProdutos";
            this.crystalReportViewerProdutos.Size = new System.Drawing.Size(954, 688);
            this.crystalReportViewerProdutos.TabIndex = 0;
            this.crystalReportViewerProdutos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewerProdutos.Load += new System.EventHandler(this.crystalReportViewerProdutos_Load);
            // 
            // FrmRelatorioProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 688);
            this.Controls.Add(this.crystalReportViewerProdutos);
            this.Name = "FrmRelatorioProdutos";
            this.Text = "Relatório produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProdutos;
    }
}