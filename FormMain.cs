namespace teste_atak
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMenuEvenOdd_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormEvenOdd myForm = new FormEvenOdd();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnMenuSortList_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormOrderedList myForm = new FormOrderedList();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnMenuCalcArea_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormCalcArea myForm = new FormCalcArea();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnMenuMultOfTree_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormMultOfTree myForm = new FormMultOfTree();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnMenuPersonClass_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormPerson myForm = new FormPerson();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            this.pnlMain.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
