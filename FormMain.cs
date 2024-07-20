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
    }
}
