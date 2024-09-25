using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acropolis_Quest
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            if(loadingAppBar.Value < 100)
            {
                loadingAppBar.Value += 1;
                
                rate.Text = loadingAppBar.Value.ToString() + "%";
            }
            else
            {
                SplashTimer.Stop();
                loginScreen login = new loginScreen();
                login.Show();
                this.Hide();
            }
        }
    }
}
