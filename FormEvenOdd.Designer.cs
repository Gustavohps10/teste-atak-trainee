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
            btnCheck = new Button();
            lblResult = new Label();
            txtNumber = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(251, 251, 251);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lblNumber.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(62, 30);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(105, 15);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Digite um número";
            // 
            // btnCheck
            // 
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Location = new Point(62, 84);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 3;
            btnCheck.Text = "Verificar";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(33, 33, 33);
            lblResult.Location = new Point(62, 133);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(190, 23);
            lblResult.TabIndex = 4;
            lblResult.Text = "O número 3 é impar";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            txtNumber.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.Location = new Point(62, 48);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(226, 30);
            txtNumber.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(lblNumber);
            panel1.Location = new Point(191, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 207);
            panel1.TabIndex = 5;
            // 
            // FormEvenOdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Button btnCheck;
        private Label lblResult;
        private TextBox txtNumber;
        private Panel panel1;
    }
}