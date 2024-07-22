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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            imgClose = new PictureBox();
            imgLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            lblTesteAtak = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            lblMadeBy = new Label();
            btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            // btnLogin
            // 
            btnLogin.AllowAnimations = true;
            btnLogin.AllowMouseEffects = true;
            btnLogin.AllowToggling = false;
            btnLogin.AnimationSpeed = 25;
            btnLogin.AutoGenerateColors = false;
            btnLogin.AutoRoundBorders = false;
            btnLogin.AutoSizeLeftIcon = true;
            btnLogin.AutoSizeRightIcon = true;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BackColor1 = Color.FromArgb(24, 22, 27);
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.ButtonText = "  Acessar";
            btnLogin.ButtonTextMarginLeft = 0;
            btnLogin.ColorContrastOnClick = 45;
            btnLogin.ColorContrastOnHover = 45;
            btnLogin.Cursor = Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnLogin.CustomizableEdges = borderEdges1;
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.DisabledBorderColor = Color.Transparent;
            btnLogin.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnLogin.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnLogin.IconLeftCursor = Cursors.Default;
            btnLogin.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnLogin.IconMarginLeft = 11;
            btnLogin.IconPadding = 10;
            btnLogin.IconRightAlign = ContentAlignment.MiddleRight;
            btnLogin.IconRightCursor = Cursors.Default;
            btnLogin.IconRightPadding = new Padding(3, 3, 7, 3);
            btnLogin.IconSize = 25;
            btnLogin.IdleBorderColor = Color.Transparent;
            btnLogin.IdleBorderRadius = 8;
            btnLogin.IdleBorderThickness = 1;
            btnLogin.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnLogin.IdleIconLeftImage = Properties.Resources.log_in;
            btnLogin.IdleIconRightImage = null;
            btnLogin.IndicateFocus = false;
            btnLogin.Location = new Point(74, 209);
            btnLogin.Name = "btnLogin";
            btnLogin.OnDisabledState.BorderColor = Color.Transparent;
            btnLogin.OnDisabledState.BorderRadius = 8;
            btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnDisabledState.BorderThickness = 1;
            btnLogin.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnLogin.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnLogin.OnDisabledState.IconLeftImage = null;
            btnLogin.OnDisabledState.IconRightImage = null;
            btnLogin.onHoverState.BorderColor = Color.Transparent;
            btnLogin.onHoverState.BorderRadius = 8;
            btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.onHoverState.BorderThickness = 1;
            btnLogin.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnLogin.onHoverState.ForeColor = Color.White;
            btnLogin.onHoverState.IconLeftImage = null;
            btnLogin.onHoverState.IconRightImage = null;
            btnLogin.OnIdleState.BorderColor = Color.Transparent;
            btnLogin.OnIdleState.BorderRadius = 8;
            btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnIdleState.BorderThickness = 1;
            btnLogin.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnLogin.OnIdleState.ForeColor = Color.White;
            btnLogin.OnIdleState.IconLeftImage = Properties.Resources.log_in;
            btnLogin.OnIdleState.IconRightImage = null;
            btnLogin.OnPressedState.BorderColor = Color.Transparent;
            btnLogin.OnPressedState.BorderRadius = 8;
            btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnLogin.OnPressedState.BorderThickness = 1;
            btnLogin.OnPressedState.FillColor = Color.FromArgb(24, 22, 27);
            btnLogin.OnPressedState.ForeColor = Color.White;
            btnLogin.OnPressedState.IconLeftImage = null;
            btnLogin.OnPressedState.IconRightImage = null;
            btnLogin.Size = new Size(115, 36);
            btnLogin.TabIndex = 9;
            btnLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnLogin.TextAlignment = HorizontalAlignment.Center;
            btnLogin.TextMarginLeft = 0;
            btnLogin.TextPadding = new Padding(0);
            btnLogin.UseDefaultRadiusAndThickness = true;
            btnLogin.Click += btnMenuEvenOdd_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(717, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblMadeBy);
            Controls.Add(linkLabel1);
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMenuEvenOdd;
        private LinkLabel linkLabel1;
        private Label lblMadeBy;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnLogin;
    }
}