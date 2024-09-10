
namespace Projeto_Relatório.Formulários
{
    partial class frmInformaParametros
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
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbClassificacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet_Series = new Projeto_Relatório.Dados.DataSet_Series();
            this.classificacaoEtariaSeriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classificacaoEtaria_SeriesTableAdapter = new Projeto_Relatório.Dados.DataSet_SeriesTableAdapters.ClassificacaoEtaria_SeriesTableAdapter();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacaoEtariaSeriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(226, 30);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(78, 28);
            this.btnTodos.TabIndex = 10;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(142, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(78, 28);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbClassificacao
            // 
            this.cmbClassificacao.DataSource = this.classificacaoEtariaSeriesBindingSource;
            this.cmbClassificacao.DisplayMember = "CLASSIFICACAO";
            this.cmbClassificacao.FormattingEnabled = true;
            this.cmbClassificacao.Location = new System.Drawing.Point(15, 30);
            this.cmbClassificacao.Name = "cmbClassificacao";
            this.cmbClassificacao.Size = new System.Drawing.Size(121, 28);
            this.cmbClassificacao.TabIndex = 8;
            this.cmbClassificacao.ValueMember = "CLASSIFICACAO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtrar por Classificação";
            // 
            // dataSet_Series
            // 
            this.dataSet_Series.DataSetName = "DataSet_Series";
            this.dataSet_Series.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classificacaoEtariaSeriesBindingSource
            // 
            this.classificacaoEtariaSeriesBindingSource.DataMember = "ClassificacaoEtaria_Series";
            this.classificacaoEtariaSeriesBindingSource.DataSource = this.dataSet_Series;
            // 
            // classificacaoEtaria_SeriesTableAdapter
            // 
            this.classificacaoEtaria_SeriesTableAdapter.ClearBeforeFill = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(310, 30);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(78, 28);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmInformaParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 82);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbClassificacao);
            this.Controls.Add(this.label1);
            this.Name = "frmInformaParametros";
            this.Text = "frmInformaParametros";
            this.Load += new System.EventHandler(this.frmInformaParametros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Series)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classificacaoEtariaSeriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbClassificacao;
        private System.Windows.Forms.Label label1;
        private Dados.DataSet_Series dataSet_Series;
        private System.Windows.Forms.BindingSource classificacaoEtariaSeriesBindingSource;
        private Dados.DataSet_SeriesTableAdapters.ClassificacaoEtaria_SeriesTableAdapter classificacaoEtaria_SeriesTableAdapter;
        private System.Windows.Forms.Button btnFechar;
    }
}