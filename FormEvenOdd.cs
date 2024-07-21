using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_atak
{
    public partial class FormEvenOdd : Form
    {
        public FormEvenOdd()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txtNumber.Text, out _))
            {
                MessageBox.Show("Insira um número inteiro válido.", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int number = int.Parse(txtNumber.Text);
            if (number % 2 == 0)
            {
                lblResult.Text = "O número " + number + " é par";
                return;
            }

            lblResult.Text = "O número " + number + " é ímpar";
        }
    }
}
