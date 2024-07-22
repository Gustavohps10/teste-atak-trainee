namespace teste_atak
{
    partial class FormPerson
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
            panel1 = new Panel();
            txtAge = new TextBox();
            lblAge = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtPersonId = new TextBox();
            lblPersonId = new Label();
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
            label1.TabIndex = 2;
            label1.Text = "Classe Pessoa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtPersonId);
            panel1.Controls.Add(lblPersonId);
            panel1.ForeColor = Color.FromArgb(26, 26, 30);
            panel1.Location = new Point(260, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 265);
            panel1.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(10, 140);
            txtAge.Name = "txtAge";
            txtAge.ReadOnly = true;
            txtAge.Size = new Size(244, 23);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(10, 122);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Idade";
            // 
            // txtName
            // 
            txtName.Location = new Point(10, 82);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(244, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Nome";
            // 
            // txtPersonId
            // 
            txtPersonId.Location = new Point(10, 30);
            txtPersonId.Name = "txtPersonId";
            txtPersonId.ReadOnly = true;
            txtPersonId.Size = new Size(244, 23);
            txtPersonId.TabIndex = 1;
            // 
            // lblPersonId
            // 
            lblPersonId.AutoSize = true;
            lblPersonId.Location = new Point(10, 12);
            lblPersonId.Name = "lblPersonId";
            lblPersonId.Size = new Size(18, 15);
            lblPersonId.TabIndex = 0;
            lblPersonId.Text = "ID";
            // 
            // FormPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormPerson";
            Text = "Pessoa";
            Shown += FormPerson_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtAge;
        private Label lblAge;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtPersonId;
        private Label lblPersonId;
    }
}