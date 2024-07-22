namespace teste_atak
{
    partial class FormLogin
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
            imgClose = new PictureBox();
            imgLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTesteAtak = new Label();
            label1 = new Label();
            btnMenuEvenOdd = new Bunifu.Framework.UI.BunifuFlatButton();
            linkLabel1 = new LinkLabel();
            lblMadeBy = new Label();
            ((System.ComponentModel.ISupportInitialize)imgClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imgClose
            // 
            imgClose.Cursor = Cursors.Hand;
            imgClose.Image = Properties.Resources.x;
            imgClose.Location = new Point(677, 21);
            imgClose.Name = "imgClose";
            imgClose.Size = new Size(24, 24);
            imgClose.TabIndex = 0;
            imgClose.TabStop = false;
            imgClose.Click += imgClose_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.atak_logo;
            imgLogo.Location = new Point(16, 12);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(135, 50);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 1;
            imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(363, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 233);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTesteAtak
            // 
            lblTesteAtak.AutoSize = true;
            lblTesteAtak.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTesteAtak.ForeColor = Color.FromArgb(26, 26, 30);
            lblTesteAtak.Location = new Point(74, 121);
            lblTesteAtak.Name = "lblTesteAtak";
            lblTesteAtak.Size = new Size(201, 45);
            lblTesteAtak.TabIndex = 3;
            lblTesteAtak.Text = "TESTE ATAK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(113, 113, 113);
            label1.Location = new Point(74, 166);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 4;
            label1.Text = "Desenvolvedor Trainee";
            // 
            // btnMenuEvenOdd
            // 
            btnMenuEvenOdd.Active = false;
            btnMenuEvenOdd.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuEvenOdd.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuEvenOdd.BorderRadius = 5;
            btnMenuEvenOdd.ButtonText = "  Acessar";
            btnMenuEvenOdd.DisabledColor = Color.Gray;
            btnMenuEvenOdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuEvenOdd.Iconcolor = Color.Transparent;
            btnMenuEvenOdd.Iconimage = Properties.Resources.log_in;
            btnMenuEvenOdd.Iconimage_right = null;
            btnMenuEvenOdd.Iconimage_right_Selected = null;
            btnMenuEvenOdd.Iconimage_Selected = null;
            btnMenuEvenOdd.IconMarginLeft = 0;
            btnMenuEvenOdd.IconMarginRight = 16;
            btnMenuEvenOdd.IconRightVisible = false;
            btnMenuEvenOdd.IconRightZoom = 0D;
            btnMenuEvenOdd.IconVisible = true;
            btnMenuEvenOdd.IconZoom = 38D;
            btnMenuEvenOdd.IsTab = false;
            btnMenuEvenOdd.Location = new Point(74, 212);
            btnMenuEvenOdd.Margin = new Padding(0, 0, 0, 8);
            btnMenuEvenOdd.Name = "btnMenuEvenOdd";
            btnMenuEvenOdd.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuEvenOdd.OnHoverTextColor = Color.White;
            btnMenuEvenOdd.selected = false;
            btnMenuEvenOdd.Size = new Size(114, 40);
            btnMenuEvenOdd.TabIndex = 6;
            btnMenuEvenOdd.Text = "  Acessar";
            btnMenuEvenOdd.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEvenOdd.Textcolor = Color.White;
            btnMenuEvenOdd.TextFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuEvenOdd.Click += btnMenuEvenOdd_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.FromArgb(113, 113, 113);
            linkLabel1.Font = new Font("Segoe UI", 9F);
            linkLabel1.Image = Properties.Resources.rounded_github_24;
            linkLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            linkLabel1.LinkColor = Color.FromArgb(24, 22, 27);
            linkLabel1.Location = new Point(73, 323);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(245, 31);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/Gustavohps10";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblMadeBy
            // 
            lblMadeBy.AutoSize = true;
            lblMadeBy.Font = new Font("Segoe UI", 9F);
            lblMadeBy.ForeColor = Color.FromArgb(33, 33, 33);
            lblMadeBy.Location = new Point(73, 308);
            lblMadeBy.Name = "lblMadeBy";
            lblMadeBy.Size = new Size(197, 15);
            lblMadeBy.TabIndex = 8;
            lblMadeBy.Text = "Feito com ☕ por Gustavo Henrique.";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(717, 450);
            Controls.Add(lblMadeBy);
            Controls.Add(linkLabel1);
            Controls.Add(btnMenuEvenOdd);
            Controls.Add(label1);
            Controls.Add(lblTesteAtak);
            Controls.Add(pictureBox1);
            Controls.Add(imgLogo);
            Controls.Add(imgClose);
            Font = new Font("Microsoft Sans Serif", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)imgClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgClose;
        private PictureBox imgLogo;
        private PictureBox pictureBox1;
        private Label lblTesteAtak;
        private Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuEvenOdd;
        private LinkLabel linkLabel1;
        private Label lblMadeBy;
    }
}