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
    public partial class FormMultOfTree : Form
    {
        public FormMultOfTree()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) lbxFor.Items.Add(i.ToString());
            }

            int j = 1;
            while (j < 100)
            {
                if (j % 3 == 0) lbxWhile.Items.Add(j.ToString());
                j++;
            }

            int k = 1;
            do
            {
                if (k % 3 == 0) lbxDoWhile.Items.Add(k.ToString());
                k++;
            } while (k < 100);
        }
    }
}
