
namespace Projeto_Relatório.Formulários
{
    partial class frmVisualizaSeriesFiltradas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.seriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Series = new Projeto_Relatório.Dados.DataSet_Series();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClassificacao = new System.Windows.Forms.ComboBox();
            this.classificacaoEtariaSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.seriesTableAdapter = new Projeto_Relatório.Dados.DataSet_SeriesTableAdapters.SeriesTableAdapter();
            this.classificacaoEtaria_SeriesTableAdapter = new Projeto_Relatório.Dados.DataSet_SeriesTableAdapters.ClassificacaoEtaria_SeriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacaoEtariaSeriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // seriesBindingSource
            // 
            this.seriesBindingSource.DataMember = "Series";
            this.seriesBindingSource.DataSource = this.dataSet_Series;
            // 
            // dataSet_Series
            // 
            this.dataSet_Series.DataSetName = "DataSet_Series";
            this.dataSet_Series.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSetSeriesFiltradas";
            reportDataSource2.Value = this.seriesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Projeto_Relatório.Relatórios.Relatorio_Series_Filtrado.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 89);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 361);
            this.reportViewer2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por Classificação";
            // 
            // cmbClassificacao
            // 
            this.cmbClassificacao.DataSource = this.classificacaoEtariaSeriesBindingSource;
            this.cmbClassificacao.DisplayMember = "CLASSIFICACAO";
            this.cmbClassificacao.Location = new System.Drawing.Point(30, 30);
            this.cmbClassificacao.Name = "cmbClassificacao";
            this.cmbClassificacao.Size = new System.Drawing.Size(121, 28);
            this.cmbClassificacao.TabIndex = 4;
            this.cmbClassificacao.ValueMember = "CLASSIFICACAO";
            // 
            // classificacaoEtariaSeriesBindingSource
            // 
            this.classificacaoEtariaSeriesBindingSource.DataMember = "ClassificacaoEtaria_Series";
            this.classificacaoEtariaSeriesBindingSource.DataSource = this.dataSet_Series;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(157, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(78, 28);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(241, 30);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(78, 28);
            this.btnTodos.TabIndex = 6;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // seriesTableAdapter
            // 
            this.seriesTableAdapter.ClearBeforeFill = true;
            // 
            // classificacaoEtaria_SeriesTableAdapter
            // 
            this.classificacaoEtaria_SeriesTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaSeriesFiltradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbClassificacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmVisualizaSeriesFiltradas";
            this.Text = "frmVisualizaSeriesFiltradas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizaSeriesFiltradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacaoEtariaSeriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Dados.DataSet_Series dataSet_Series;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClassificacao;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.BindingSource seriesBindingSource;
        private Dados.DataSet_SeriesTableAdapters.SeriesTableAdapter seriesTableAdapter;
        private System.Windows.Forms.BindingSource classificacaoEtariaSeriesBindingSource;
        private Dados.DataSet_SeriesTableAdapters.ClassificacaoEtaria_SeriesTableAdapter classificacaoEtaria_SeriesTableAdapter;
    }
}