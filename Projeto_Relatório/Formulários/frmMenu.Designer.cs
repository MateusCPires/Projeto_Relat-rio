
namespace Projeto_Relatório
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.VisualizarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarRelatórioAgrupadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vilualizarRelatórioComFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioFiltradoPorPopupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisualizarRelatórioToolStripMenuItem,
            this.visualizarRelatórioAgrupadoToolStripMenuItem,
            this.vilualizarRelatórioComFiltrosToolStripMenuItem,
            this.relatórioFiltradoPorPopupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(804, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // VisualizarRelatórioToolStripMenuItem
            // 
            this.VisualizarRelatórioToolStripMenuItem.Name = "VisualizarRelatórioToolStripMenuItem";
            this.VisualizarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(154, 29);
            this.VisualizarRelatórioToolStripMenuItem.Text = "Relatório Inteiro";
            this.VisualizarRelatórioToolStripMenuItem.Click += new System.EventHandler(this.VisualizarRelatórioToolStripMenuItem_Click);
            // 
            // visualizarRelatórioAgrupadoToolStripMenuItem
            // 
            this.visualizarRelatórioAgrupadoToolStripMenuItem.Name = "visualizarRelatórioAgrupadoToolStripMenuItem";
            this.visualizarRelatórioAgrupadoToolStripMenuItem.Size = new System.Drawing.Size(184, 29);
            this.visualizarRelatórioAgrupadoToolStripMenuItem.Text = "Relatório Agrupado";
            // 
            // vilualizarRelatórioComFiltrosToolStripMenuItem
            // 
            this.vilualizarRelatórioComFiltrosToolStripMenuItem.Name = "vilualizarRelatórioComFiltrosToolStripMenuItem";
            this.vilualizarRelatórioComFiltrosToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.vilualizarRelatórioComFiltrosToolStripMenuItem.Text = "Relatório com Filtros";
            this.vilualizarRelatórioComFiltrosToolStripMenuItem.Click += new System.EventHandler(this.vilualizarRelatórioComFiltrosToolStripMenuItem_Click);
            // 
            // relatórioFiltradoPorPopupToolStripMenuItem
            // 
            this.relatórioFiltradoPorPopupToolStripMenuItem.Name = "relatórioFiltradoPorPopupToolStripMenuItem";
            this.relatórioFiltradoPorPopupToolStripMenuItem.Size = new System.Drawing.Size(260, 29);
            this.relatórioFiltradoPorPopupToolStripMenuItem.Text = "Relatório Filtrado por Pop-up";
            this.relatórioFiltradoPorPopupToolStripMenuItem.Click += new System.EventHandler(this.relatórioFiltradoPorPopupToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 449);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VisualizarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarRelatórioAgrupadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vilualizarRelatórioComFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioFiltradoPorPopupToolStripMenuItem;
    }
}