using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste_atak.Entities;

namespace teste_atak
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Shown(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa { Id = "758c51bc-a038-4737-abad-d482a147ccfd", Nome = "John Doe", Idade = 20 };

            txtPersonId.Text = pessoa.Id;
            txtName.Text = pessoa.Nome;
            txtAge.Text = pessoa.Idade.ToString();
        }
    }
}
