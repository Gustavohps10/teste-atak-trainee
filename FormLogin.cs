using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace teste_atak
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            ;
        }

        private void btnMenuEvenOdd_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://github.com/Gustavohps10";

            var info = new ProcessStartInfo
            {
                FileName = target,
                UseShellExecute = true
            };
            Process.Start(info);
        }
    }
}
