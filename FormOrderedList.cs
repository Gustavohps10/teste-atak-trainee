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
    public partial class FormOrderedList : Form
    {
        public FormOrderedList()
        {
            InitializeComponent();
        }

        private void btnSortList_Click(object sender, EventArgs e)
        {
            string[] words = txtWords.Text.Split(',', StringSplitOptions.TrimEntries);
            Array.Sort(words);

            lbxSortedWords.Items.Clear();
            lbxSortedWords.Items.AddRange(words);
        }
    }
}
