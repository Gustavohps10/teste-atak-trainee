namespace teste_atak
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnlHeader = new Panel();
            lblUserName = new Label();
            pcbUserIcon = new PictureBox();
            pcbLogo = new PictureBox();
            pnlNav = new FlowLayoutPanel();
            btnMenuEvenOdd = new Bunifu.Framework.UI.BunifuFlatButton();
            btnMenuSortList = new Bunifu.Framework.UI.BunifuFlatButton();
            btnMenuCalcArea = new Bunifu.Framework.UI.BunifuFlatButton();
            btnMenuMultOfTree = new Bunifu.Framework.UI.BunifuFlatButton();
            btnMenuPersonClass = new Bunifu.Framework.UI.BunifuFlatButton();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            pnlSidebar = new Panel();
            pnlMain = new Panel();
            lblLogical = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
            lblTextGuide = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlNav.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblUserName);
            pnlHeader.Controls.Add(pcbUserIcon);
            pnlHeader.Controls.Add(pcbLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8, 0, 8, 0);
            pnlHeader.Size = new Size(1060, 64);
            pnlHeader.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Inter", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(830, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(177, 23);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Gustavo Henrique";
            // 
            // pcbUserIcon
            // 
            pcbUserIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbUserIcon.Image = Properties.Resources.circle_user_round;
            pcbUserIcon.Location = new Point(1013, 16);
            pcbUserIcon.Name = "pcbUserIcon";
            pcbUserIcon.Size = new Size(36, 36);
            pcbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUserIcon.TabIndex = 1;
            pcbUserIcon.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.atak_logo;
            pcbLogo.Location = new Point(15, 16);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(139, 34);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Transparent;
            pnlNav.Controls.Add(btnMenuEvenOdd);
            pnlNav.Controls.Add(btnMenuSortList);
            pnlNav.Controls.Add(btnMenuCalcArea);
            pnlNav.Controls.Add(btnMenuMultOfTree);
            pnlNav.Controls.Add(btnMenuPersonClass);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.FlowDirection = FlowDirection.TopDown;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Padding = new Padding(16);
            pnlNav.Size = new Size(200, 280);
            pnlNav.TabIndex = 11;
            // 
            // btnMenuEvenOdd
            // 
            btnMenuEvenOdd.Active = false;
            btnMenuEvenOdd.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuEvenOdd.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuEvenOdd.BorderRadius = 5;
            btnMenuEvenOdd.ButtonText = "  Par ou Ímpar";
            btnMenuEvenOdd.DisabledColor = Color.Gray;
            btnMenuEvenOdd.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuEvenOdd.Iconcolor = Color.Transparent;
            btnMenuEvenOdd.Iconimage = Properties.Resources.file_digit;
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
            btnMenuEvenOdd.Location = new Point(16, 16);
            btnMenuEvenOdd.Margin = new Padding(0, 0, 0, 8);
            btnMenuEvenOdd.Name = "btnMenuEvenOdd";
            btnMenuEvenOdd.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuEvenOdd.OnHoverTextColor = Color.White;
            btnMenuEvenOdd.selected = false;
            btnMenuEvenOdd.Size = new Size(171, 40);
            btnMenuEvenOdd.TabIndex = 5;
            btnMenuEvenOdd.Text = "  Par ou Ímpar";
            btnMenuEvenOdd.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEvenOdd.Textcolor = Color.White;
            btnMenuEvenOdd.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuEvenOdd.Click += btnMenuEvenOdd_Click;
            // 
            // btnMenuSortList
            // 
            btnMenuSortList.Active = false;
            btnMenuSortList.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuSortList.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuSortList.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuSortList.BorderRadius = 5;
            btnMenuSortList.ButtonText = "  Lista ordenada";
            btnMenuSortList.DisabledColor = Color.Gray;
            btnMenuSortList.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuSortList.Iconcolor = Color.Transparent;
            btnMenuSortList.Iconimage = Properties.Resources.list;
            btnMenuSortList.Iconimage_right = null;
            btnMenuSortList.Iconimage_right_Selected = null;
            btnMenuSortList.Iconimage_Selected = null;
            btnMenuSortList.IconMarginLeft = 0;
            btnMenuSortList.IconMarginRight = 16;
            btnMenuSortList.IconRightVisible = false;
            btnMenuSortList.IconRightZoom = 0D;
            btnMenuSortList.IconVisible = true;
            btnMenuSortList.IconZoom = 38D;
            btnMenuSortList.IsTab = false;
            btnMenuSortList.Location = new Point(16, 64);
            btnMenuSortList.Margin = new Padding(0, 0, 0, 8);
            btnMenuSortList.Name = "btnMenuSortList";
            btnMenuSortList.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuSortList.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuSortList.OnHoverTextColor = Color.White;
            btnMenuSortList.selected = false;
            btnMenuSortList.Size = new Size(171, 40);
            btnMenuSortList.TabIndex = 10;
            btnMenuSortList.Text = "  Lista ordenada";
            btnMenuSortList.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSortList.Textcolor = Color.White;
            btnMenuSortList.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuSortList.Click += btnMenuSortList_Click;
            // 
            // btnMenuCalcArea
            // 
            btnMenuCalcArea.Active = false;
            btnMenuCalcArea.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuCalcArea.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuCalcArea.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuCalcArea.BorderRadius = 5;
            btnMenuCalcArea.ButtonText = "  Calcular Área";
            btnMenuCalcArea.DisabledColor = Color.Gray;
            btnMenuCalcArea.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuCalcArea.Iconcolor = Color.Transparent;
            btnMenuCalcArea.Iconimage = Properties.Resources.square_dashed_bottom;
            btnMenuCalcArea.Iconimage_right = null;
            btnMenuCalcArea.Iconimage_right_Selected = null;
            btnMenuCalcArea.Iconimage_Selected = null;
            btnMenuCalcArea.IconMarginLeft = 0;
            btnMenuCalcArea.IconMarginRight = 16;
            btnMenuCalcArea.IconRightVisible = false;
            btnMenuCalcArea.IconRightZoom = 0D;
            btnMenuCalcArea.IconVisible = true;
            btnMenuCalcArea.IconZoom = 38D;
            btnMenuCalcArea.IsTab = false;
            btnMenuCalcArea.Location = new Point(16, 112);
            btnMenuCalcArea.Margin = new Padding(0, 0, 0, 8);
            btnMenuCalcArea.Name = "btnMenuCalcArea";
            btnMenuCalcArea.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuCalcArea.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuCalcArea.OnHoverTextColor = Color.White;
            btnMenuCalcArea.selected = false;
            btnMenuCalcArea.Size = new Size(171, 40);
            btnMenuCalcArea.TabIndex = 7;
            btnMenuCalcArea.Text = "  Calcular Área";
            btnMenuCalcArea.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCalcArea.Textcolor = Color.White;
            btnMenuCalcArea.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuCalcArea.Click += btnMenuCalcArea_Click;
            // 
            // btnMenuMultOfTree
            // 
            btnMenuMultOfTree.Active = false;
            btnMenuMultOfTree.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuMultOfTree.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuMultOfTree.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuMultOfTree.BorderRadius = 5;
            btnMenuMultOfTree.ButtonText = "  Múltiplos de 3";
            btnMenuMultOfTree.DisabledColor = Color.Gray;
            btnMenuMultOfTree.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuMultOfTree.Iconcolor = Color.Transparent;
            btnMenuMultOfTree.Iconimage = Properties.Resources.repeat;
            btnMenuMultOfTree.Iconimage_right = null;
            btnMenuMultOfTree.Iconimage_right_Selected = null;
            btnMenuMultOfTree.Iconimage_Selected = null;
            btnMenuMultOfTree.IconMarginLeft = 0;
            btnMenuMultOfTree.IconMarginRight = 16;
            btnMenuMultOfTree.IconRightVisible = false;
            btnMenuMultOfTree.IconRightZoom = 0D;
            btnMenuMultOfTree.IconVisible = true;
            btnMenuMultOfTree.IconZoom = 38D;
            btnMenuMultOfTree.IsTab = false;
            btnMenuMultOfTree.Location = new Point(16, 160);
            btnMenuMultOfTree.Margin = new Padding(0, 0, 0, 8);
            btnMenuMultOfTree.Name = "btnMenuMultOfTree";
            btnMenuMultOfTree.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuMultOfTree.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuMultOfTree.OnHoverTextColor = Color.White;
            btnMenuMultOfTree.selected = false;
            btnMenuMultOfTree.Size = new Size(171, 40);
            btnMenuMultOfTree.TabIndex = 8;
            btnMenuMultOfTree.Text = "  Múltiplos de 3";
            btnMenuMultOfTree.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuMultOfTree.Textcolor = Color.White;
            btnMenuMultOfTree.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuMultOfTree.Click += btnMenuMultOfTree_Click;
            // 
            // btnMenuPersonClass
            // 
            btnMenuPersonClass.Active = false;
            btnMenuPersonClass.Activecolor = Color.FromArgb(46, 44, 50);
            btnMenuPersonClass.BackColor = Color.FromArgb(24, 22, 27);
            btnMenuPersonClass.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenuPersonClass.BorderRadius = 5;
            btnMenuPersonClass.ButtonText = "  Classe Pessoa";
            btnMenuPersonClass.DisabledColor = Color.Gray;
            btnMenuPersonClass.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPersonClass.Iconcolor = Color.Transparent;
            btnMenuPersonClass.Iconimage = Properties.Resources.user;
            btnMenuPersonClass.Iconimage_right = null;
            btnMenuPersonClass.Iconimage_right_Selected = null;
            btnMenuPersonClass.Iconimage_Selected = null;
            btnMenuPersonClass.IconMarginLeft = 0;
            btnMenuPersonClass.IconMarginRight = 16;
            btnMenuPersonClass.IconRightVisible = false;
            btnMenuPersonClass.IconRightZoom = 0D;
            btnMenuPersonClass.IconVisible = true;
            btnMenuPersonClass.IconZoom = 38D;
            btnMenuPersonClass.IsTab = false;
            btnMenuPersonClass.Location = new Point(16, 208);
            btnMenuPersonClass.Margin = new Padding(0, 0, 0, 8);
            btnMenuPersonClass.Name = "btnMenuPersonClass";
            btnMenuPersonClass.Normalcolor = Color.FromArgb(24, 22, 27);
            btnMenuPersonClass.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnMenuPersonClass.OnHoverTextColor = Color.White;
            btnMenuPersonClass.selected = false;
            btnMenuPersonClass.Size = new Size(171, 40);
            btnMenuPersonClass.TabIndex = 9;
            btnMenuPersonClass.Text = "  Classe Pessoa";
            btnMenuPersonClass.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPersonClass.Textcolor = Color.White;
            btnMenuPersonClass.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPersonClass.Click += btnMenuPersonClass_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1060, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Image = Properties.Resources.about;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(68, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // btnExit
            // 
            btnExit.Active = false;
            btnExit.Activecolor = Color.FromArgb(46, 44, 50);
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = Color.FromArgb(24, 22, 27);
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.BorderRadius = 5;
            btnExit.ButtonText = "  Sair";
            btnExit.DisabledColor = Color.Gray;
            btnExit.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Iconcolor = Color.Transparent;
            btnExit.Iconimage = (Image)resources.GetObject("btnExit.Iconimage");
            btnExit.Iconimage_right = null;
            btnExit.Iconimage_right_Selected = null;
            btnExit.Iconimage_Selected = null;
            btnExit.IconMarginLeft = 0;
            btnExit.IconMarginRight = 16;
            btnExit.IconRightVisible = false;
            btnExit.IconRightZoom = 0D;
            btnExit.IconVisible = true;
            btnExit.IconZoom = 38D;
            btnExit.IsTab = false;
            btnExit.Location = new Point(16, 452);
            btnExit.Margin = new Padding(0, 0, 0, 8);
            btnExit.Name = "btnExit";
            btnExit.Normalcolor = Color.FromArgb(24, 22, 27);
            btnExit.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnExit.OnHoverTextColor = Color.White;
            btnExit.selected = false;
            btnExit.Size = new Size(171, 40);
            btnExit.TabIndex = 11;
            btnExit.Text = "  Sair";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.Textcolor = Color.White;
            btnExit.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Click += btnExit_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(24, 22, 27);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(pnlNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 88);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 509);
            pnlSidebar.TabIndex = 13;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblTextGuide);
            pnlMain.Controls.Add(lblLogical);
            pnlMain.Controls.Add(lblWelcome);
            pnlMain.Controls.Add(pictureBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(200, 88);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(860, 509);
            pnlMain.TabIndex = 14;
            // 
            // lblLogical
            // 
            lblLogical.AutoSize = true;
            lblLogical.Font = new Font("Inter", 14F);
            lblLogical.ForeColor = Color.FromArgb(113, 113, 113);
            lblLogical.Location = new Point(82, 104);
            lblLogical.Name = "lblLogical";
            lblLogical.Size = new Size(252, 23);
            lblLogical.TabIndex = 6;
            lblLogical.Text = "Desafios de lógica com C#";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Inter", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(26, 26, 30);
            lblWelcome.Location = new Point(100, 65);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(206, 39);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "BEM-VINDO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.main_form;
            pictureBox1.Location = new Point(391, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 345);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTextGuide
            // 
            lblTextGuide.Font = new Font("Inter", 14F);
            lblTextGuide.ForeColor = Color.FromArgb(33, 33, 33);
            lblTextGuide.Location = new Point(77, 150);
            lblTextGuide.Name = "lblTextGuide";
            lblTextGuide.Size = new Size(257, 98);
            lblTextGuide.TabIndex = 7;
            lblTextGuide.Text = "Você pode navegar pelos desafios através do menu lateral.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(1060, 597);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(menuStrip1);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste - Atak Sistemas";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlNav.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private FlowLayoutPanel pnlNav;
        private PictureBox pcbLogo;
        private PictureBox pcbUserIcon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel pnlMenuEvenOdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuEvenOdd;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuCalcArea;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuMultOfTree;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuPersonClass;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuSortList;
        private Label lblUserName;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Panel pnlSidebar;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private Label lblLogical;
        private Label lblWelcome;
        private Label lblTextGuide;
    }
}
