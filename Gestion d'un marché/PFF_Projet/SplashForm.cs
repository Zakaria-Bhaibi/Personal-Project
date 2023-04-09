using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFF_Projet
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            monProgressBar.Value = startpoint;
            if(monProgressBar.Value == 100)
            {
                monProgressBar.Value = 0;
                timer1.Stop();
                PFF_Projet.LoginForm loginForm = new PFF_Projet.LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
