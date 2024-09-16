using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatório.Formulários
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            EfectTime();
        }
        private bool Efect = true;
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if (Efect)
            {
                this.Opacity -= 0.01D;
            }
            if(this.Opacity == 0)
            {
                Efect = false;

                SplashTimer.Enabled = false;
                frmMenu objMenu = new frmMenu();
                objMenu.Show();
                this.Hide();
            }
        }
        private void EfectTime()
        {
            SplashTimer.Interval = 190;
            SplashTimer.Tick += new EventHandler(SplashTimer_Tick);
            SplashTimer.Enabled = true;
            this.Opacity = 1;
        }
    }
}
