
namespace Projeto_Relatório.Formulários
{
    partial class frmVisualizaSeriesAgrupadas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Series = new Projeto_Relatório.Dados.DataSet_Series();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SeriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SeriesBindingSource
            // 
            this.SeriesBindingSource.DataMember = "Series";
            this.SeriesBindingSource.DataSource = this.dataSet_Series;
            // 
            // dataSet_Series
            // 
            this.dataSet_Series.DataSetName = "DataSet_Series";
            this.dataSet_Series.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Series_AgruClassificacao";
            reportDataSource1.Value = this.SeriesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Relatório.Relatórios.Relatorio_Series_Agrupado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // dataSetSeriesBindingSource
            // 
            this.dataSetSeriesBindingSource.DataSource = this.dataSet_Series;
            this.dataSetSeriesBindingSource.Position = 0;
            // 
            // frmVisualizaSeriesAgrupadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaSeriesAgrupadas";
            this.Text = "frmVisualizaSeriesAgrupadas";
            this.Load += new System.EventHandler(this.frmVisualizaSeriesAgrupadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SeriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetSeriesBindingSource;
        private Dados.DataSet_Series dataSet_Series;
        private System.Windows.Forms.BindingSource SeriesBindingSource;
    }
}