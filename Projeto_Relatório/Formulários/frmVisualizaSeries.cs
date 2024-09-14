﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatório
{
    public partial class frmVisualizaSeries : Form
    {
        public string pClassificacao;
        public frmVisualizaSeries()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Series.Series'. Você pode movê-la ou removê-la conforme necessário.
            this.seriesTableAdapter.Fill(this.dataSet_Series.Series);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.seriesTableAdapter.Fill(this.dataSet_Series.Series);
            if(pClassificacao == (string)null)
            {
                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ClassificacaoEtaria", (string)null));
            }
            else
            {

                this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ClassificacaoEtaria", pClassificacao));
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
