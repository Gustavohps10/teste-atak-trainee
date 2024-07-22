namespace teste_atak
{
    partial class FormAbout
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            txtAbout = new RichTextBox();
            txtCopyright = new RichTextBox();
            lblAbout = new Label();
            lblLicense = new Label();
            txtLicense = new RichTextBox();
            lblVersion = new Label();
            txtVersion = new RichTextBox();
            lblAuthor = new Label();
            txtAuthor = new RichTextBox();
            lnkGithub = new LinkLabel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(24, 22, 27);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(375, 55);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(375, 55);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Sobre";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAbout
            // 
            txtAbout.BackColor = Color.FromArgb(251, 251, 251);
            txtAbout.BorderStyle = BorderStyle.None;
            txtAbout.Font = new Font("Segoe UI", 9F);
            txtAbout.Location = new Point(12, 95);
            txtAbout.Name = "txtAbout";
            txtAbout.Size = new Size(349, 44);
            txtAbout.TabIndex = 1;
            txtAbout.Text = "Esta é minha solução para o Teste de Desenvolvedor Trainee da Atak Sistemas";
            // 
            // txtCopyright
            // 
            txtCopyright.BackColor = Color.FromArgb(251, 251, 251);
            txtCopyright.BorderStyle = BorderStyle.None;
            txtCopyright.Location = new Point(12, 375);
            txtCopyright.Name = "txtCopyright";
            txtCopyright.Size = new Size(314, 17);
            txtCopyright.TabIndex = 2;
            txtCopyright.Text = "Gustavo Henrique 2024. Todos os Direitos Reservados";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbout.Location = new Point(12, 77);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(82, 15);
            lblAbout.TabIndex = 3;
            lblAbout.Text = "Sobre o teste";
            // 
            // lblLicense
            // 
            lblLicense.AutoSize = true;
            lblLicense.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicense.Location = new Point(10, 178);
            lblLicense.Name = "lblLicense";
            lblLicense.Size = new Size(125, 15);
            lblLicense.TabIndex = 5;
            lblLicense.Text = "Licença e Repositório";
            // 
            // txtLicense
            // 
            txtLicense.BackColor = Color.FromArgb(251, 251, 251);
            txtLicense.BorderStyle = BorderStyle.None;
            txtLicense.Font = new Font("Segoe UI", 9F);
            txtLicense.Location = new Point(11, 196);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(349, 38);
            txtLicense.TabIndex = 4;
            txtLicense.Text = "Este projeto possui licença MIT. O código fonte pode ser encontrado no Github.";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersion.Location = new Point(12, 325);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(51, 15);
            lblVersion.TabIndex = 7;
            lblVersion.Text = "Versão";
            // 
            // txtVersion
            // 
            txtVersion.BackColor = Color.FromArgb(251, 251, 251);
            txtVersion.BorderStyle = BorderStyle.None;
            txtVersion.Location = new Point(13, 343);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(38, 26);
            txtVersion.TabIndex = 6;
            txtVersion.Text = "1.1";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(11, 277);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(39, 15);
            lblAuthor.TabIndex = 9;
            lblAuthor.Text = "Autor";
            // 
            // txtAuthor
            // 
            txtAuthor.BackColor = Color.FromArgb(251, 251, 251);
            txtAuthor.BorderStyle = BorderStyle.None;
            txtAuthor.Font = new Font("Segoe UI", 9F);
            txtAuthor.Location = new Point(12, 295);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(123, 19);
            txtAuthor.TabIndex = 8;
            txtAuthor.Text = "Gustavo Henrique";
            // 
            // lnkGithub
            // 
            lnkGithub.ActiveLinkColor = Color.FromArgb(24, 22, 27);
            lnkGithub.AutoSize = true;
            lnkGithub.Cursor = Cursors.Hand;
            lnkGithub.Font = new Font("Segoe UI", 9F);
            lnkGithub.LinkColor = Color.FromArgb(33, 33, 33);
            lnkGithub.Location = new Point(10, 237);
            lnkGithub.Name = "lnkGithub";
            lnkGithub.Size = new Size(245, 15);
            lnkGithub.TabIndex = 10;
            lnkGithub.TabStop = true;
            lnkGithub.Text = "https://github.com/Gustavohps10/teste-atak";
            lnkGithub.LinkClicked += lnkGithub_LinkClicked;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(375, 404);
            Controls.Add(lnkGithub);
            Controls.Add(lblAuthor);
            Controls.Add(txtAuthor);
            Controls.Add(lblVersion);
            Controls.Add(txtVersion);
            Controls.Add(lblLicense);
            Controls.Add(txtLicense);
            Controls.Add(lblAbout);
            Controls.Add(txtCopyright);
            Controls.Add(txtAbout);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private RichTextBox txtAbout;
        private RichTextBox txtCopyright;
        private Label lblAbout;
        private Label lblLicense;
        private RichTextBox txtLicense;
        private Label lblVersion;
        private RichTextBox txtVersion;
        private Label lblAuthor;
        private RichTextBox txtAuthor;
        private LinkLabel lnkGithub;
    }
}