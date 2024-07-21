using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_atak
{
    public partial class FormCalcArea : Form
    {
        public FormCalcArea()
        {
            InitializeComponent();
        }

        private void btnCalcArea_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string formattedWidth = txtWidth.Text.Replace(',', '.');
            string formattedHeight = txtHeight.Text.Replace(',', '.');

            if (!float.TryParse(formattedWidth, out float _) || !float.TryParse(formattedHeight, out float _))
            {
                MessageBox.Show("Preencha a altura e largura corretamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float width = float.Parse(formattedHeight, CultureInfo.InvariantCulture.NumberFormat);
            float height = float.Parse(formattedWidth, CultureInfo.InvariantCulture.NumberFormat);

            txtArea.Text = calcRetangleArea(width, height).ToString();
        }

        static public float calcRetangleArea(float width, float height)
        {
            return width * height;
        }
    }
}
