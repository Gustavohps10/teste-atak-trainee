namespace teste_atak
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pnlMenuClass_MouseLeave(object sender, EventArgs e)
        {
            pnlMenuClass.BackColor = Color.FromArgb(24, 22, 27);

        }

        private void pnlMenuClass_MouseEnter(object sender, EventArgs e)
        {
            pnlMenuClass.BackColor = Color.FromArgb(46, 44, 50);
        }

        private void pnlMenuEvenOdd_Click(object sender, EventArgs e)
        {
            FormEvenOdd myForm = new FormEvenOdd();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
