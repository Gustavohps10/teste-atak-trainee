namespace teste_atak
{
    partial class FormEvenOdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNumber = new Label();
            lblResult = new Label();
            txtNumber = new TextBox();
            panel1 = new Panel();
            btnCheckEvenOdd = new Bunifu.Framework.UI.BunifuFlatButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(251, 251, 251);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(8);
            label1.Size = new Size(800, 58);
            label1.TabIndex = 0;
            label1.Text = "Par ou Ímpar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(62, 30);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(104, 15);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Digite um número";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(33, 33, 33);
            lblResult.Location = new Point(62, 133);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 24);
            lblResult.TabIndex = 4;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.Location = new Point(62, 48);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(226, 33);
            txtNumber.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCheckEvenOdd);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(lblNumber);
            panel1.Location = new Point(191, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 207);
            panel1.TabIndex = 5;
            // 
            // btnCheckEvenOdd
            // 
            btnCheckEvenOdd.Active = false;
            btnCheckEvenOdd.Activecolor = Color.FromArgb(46, 44, 50);
            btnCheckEvenOdd.BackColor = Color.FromArgb(24, 22, 27);
            btnCheckEvenOdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheckEvenOdd.BorderRadius = 5;
            btnCheckEvenOdd.ButtonText = "  Verificar";
            btnCheckEvenOdd.DisabledColor = Color.Gray;
            btnCheckEvenOdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckEvenOdd.Iconcolor = Color.Transparent;
            btnCheckEvenOdd.Iconimage = null;
            btnCheckEvenOdd.Iconimage_right = null;
            btnCheckEvenOdd.Iconimage_right_Selected = null;
            btnCheckEvenOdd.Iconimage_Selected = null;
            btnCheckEvenOdd.IconMarginLeft = 0;
            btnCheckEvenOdd.IconMarginRight = 16;
            btnCheckEvenOdd.IconRightVisible = false;
            btnCheckEvenOdd.IconRightZoom = 0D;
            btnCheckEvenOdd.IconVisible = true;
            btnCheckEvenOdd.IconZoom = 38D;
            btnCheckEvenOdd.IsTab = false;
            btnCheckEvenOdd.Location = new Point(62, 84);
            btnCheckEvenOdd.Margin = new Padding(0, 0, 0, 8);
            btnCheckEvenOdd.Name = "btnCheckEvenOdd";
            btnCheckEvenOdd.Normalcolor = Color.FromArgb(24, 22, 27);
            btnCheckEvenOdd.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnCheckEvenOdd.OnHoverTextColor = Color.White;
            btnCheckEvenOdd.selected = false;
            btnCheckEvenOdd.Size = new Size(105, 33);
            btnCheckEvenOdd.TabIndex = 6;
            btnCheckEvenOdd.Text = "  Verificar";
            btnCheckEvenOdd.TextAlign = ContentAlignment.MiddleCenter;
            btnCheckEvenOdd.Textcolor = Color.White;
            btnCheckEvenOdd.TextFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCheckEvenOdd.Click += btnMenuEvenOdd_Click;
            // 
            // FormEvenOdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEvenOdd";
            Text = "Par ou Ímpar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblNumber;
        private Label lblResult;
        private TextBox txtNumber;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckEvenOdd;
    }
}