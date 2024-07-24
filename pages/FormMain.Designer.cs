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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            pnlHeader = new Panel();
            lblUserName = new Label();
            pcbUserIcon = new PictureBox();
            pcbLogo = new PictureBox();
            pnlNav = new FlowLayoutPanel();
            btnMenuEvenOdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnMenuSortList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnMenuCalcArea = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnMenuMultOfTree = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            btnMenuPersonClass = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            pnlSidebar = new Panel();
            btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            pnlMain = new Panel();
            lblTextGuide = new Label();
            lblLogical = new Label();
            lblWelcome = new Label();
            pictureBox1 = new PictureBox();
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
            lblUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(830, 23);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(174, 25);
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
            pnlNav.Size = new Size(202, 252);
            pnlNav.TabIndex = 11;
            // 
            // btnMenuEvenOdd
            // 
            btnMenuEvenOdd.AllowAnimations = true;
            btnMenuEvenOdd.AllowMouseEffects = true;
            btnMenuEvenOdd.AllowToggling = false;
            btnMenuEvenOdd.AnimationSpeed = 25;
            btnMenuEvenOdd.AutoGenerateColors = false;
            btnMenuEvenOdd.AutoRoundBorders = false;
            btnMenuEvenOdd.AutoSizeLeftIcon = true;
            btnMenuEvenOdd.AutoSizeRightIcon = true;
            btnMenuEvenOdd.BackColor = Color.Transparent;
            btnMenuEvenOdd.BackColor1 = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.BackgroundImage = (Image)resources.GetObject("btnMenuEvenOdd.BackgroundImage");
            btnMenuEvenOdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuEvenOdd.ButtonText = "Par ou Ímpar";
            btnMenuEvenOdd.ButtonTextMarginLeft = 0;
            btnMenuEvenOdd.ColorContrastOnClick = 45;
            btnMenuEvenOdd.ColorContrastOnHover = 45;
            btnMenuEvenOdd.Cursor = Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnMenuEvenOdd.CustomizableEdges = borderEdges1;
            btnMenuEvenOdd.DialogResult = DialogResult.None;
            btnMenuEvenOdd.DisabledBorderColor = Color.Transparent;
            btnMenuEvenOdd.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnMenuEvenOdd.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnMenuEvenOdd.Dock = DockStyle.Left;
            btnMenuEvenOdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnMenuEvenOdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuEvenOdd.ForeColor = Color.White;
            btnMenuEvenOdd.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnMenuEvenOdd.IconLeftCursor = Cursors.Default;
            btnMenuEvenOdd.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnMenuEvenOdd.IconMarginLeft = 11;
            btnMenuEvenOdd.IconPadding = 10;
            btnMenuEvenOdd.IconRightAlign = ContentAlignment.MiddleRight;
            btnMenuEvenOdd.IconRightCursor = Cursors.Default;
            btnMenuEvenOdd.IconRightPadding = new Padding(3, 3, 7, 3);
            btnMenuEvenOdd.IconSize = 25;
            btnMenuEvenOdd.IdleBorderColor = Color.Transparent;
            btnMenuEvenOdd.IdleBorderRadius = 8;
            btnMenuEvenOdd.IdleBorderThickness = 1;
            btnMenuEvenOdd.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.IdleIconLeftImage = Properties.Resources.file_digit;
            btnMenuEvenOdd.IdleIconRightImage = null;
            btnMenuEvenOdd.IndicateFocus = false;
            btnMenuEvenOdd.Location = new Point(16, 20);
            btnMenuEvenOdd.Margin = new Padding(0, 4, 0, 4);
            btnMenuEvenOdd.Name = "btnMenuEvenOdd";
            btnMenuEvenOdd.OnDisabledState.BorderColor = Color.Transparent;
            btnMenuEvenOdd.OnDisabledState.BorderRadius = 8;
            btnMenuEvenOdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuEvenOdd.OnDisabledState.BorderThickness = 1;
            btnMenuEvenOdd.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnMenuEvenOdd.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnMenuEvenOdd.OnDisabledState.IconLeftImage = null;
            btnMenuEvenOdd.OnDisabledState.IconRightImage = null;
            btnMenuEvenOdd.onHoverState.BorderColor = Color.Transparent;
            btnMenuEvenOdd.onHoverState.BorderRadius = 8;
            btnMenuEvenOdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuEvenOdd.onHoverState.BorderThickness = 1;
            btnMenuEvenOdd.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuEvenOdd.onHoverState.ForeColor = Color.White;
            btnMenuEvenOdd.onHoverState.IconLeftImage = null;
            btnMenuEvenOdd.onHoverState.IconRightImage = null;
            btnMenuEvenOdd.OnIdleState.BorderColor = Color.Transparent;
            btnMenuEvenOdd.OnIdleState.BorderRadius = 8;
            btnMenuEvenOdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuEvenOdd.OnIdleState.BorderThickness = 1;
            btnMenuEvenOdd.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnMenuEvenOdd.OnIdleState.ForeColor = Color.White;
            btnMenuEvenOdd.OnIdleState.IconLeftImage = Properties.Resources.file_digit;
            btnMenuEvenOdd.OnIdleState.IconRightImage = null;
            btnMenuEvenOdd.OnPressedState.BorderColor = Color.Transparent;
            btnMenuEvenOdd.OnPressedState.BorderRadius = 8;
            btnMenuEvenOdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuEvenOdd.OnPressedState.BorderThickness = 1;
            btnMenuEvenOdd.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuEvenOdd.OnPressedState.ForeColor = Color.White;
            btnMenuEvenOdd.OnPressedState.IconLeftImage = null;
            btnMenuEvenOdd.OnPressedState.IconRightImage = null;
            btnMenuEvenOdd.Size = new Size(171, 36);
            btnMenuEvenOdd.TabIndex = 11;
            btnMenuEvenOdd.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuEvenOdd.TextAlignment = HorizontalAlignment.Center;
            btnMenuEvenOdd.TextMarginLeft = 0;
            btnMenuEvenOdd.TextPadding = new Padding(36, 0, 0, 0);
            btnMenuEvenOdd.UseDefaultRadiusAndThickness = true;
            btnMenuEvenOdd.Click += btnMenuEvenOdd_Click;
            // 
            // btnMenuSortList
            // 
            btnMenuSortList.AllowAnimations = true;
            btnMenuSortList.AllowMouseEffects = true;
            btnMenuSortList.AllowToggling = false;
            btnMenuSortList.AnimationSpeed = 25;
            btnMenuSortList.AutoGenerateColors = false;
            btnMenuSortList.AutoRoundBorders = false;
            btnMenuSortList.AutoSizeLeftIcon = true;
            btnMenuSortList.AutoSizeRightIcon = true;
            btnMenuSortList.BackColor = Color.Transparent;
            btnMenuSortList.BackColor1 = Color.FromArgb(24, 22, 27);
            btnMenuSortList.BackgroundImage = (Image)resources.GetObject("btnMenuSortList.BackgroundImage");
            btnMenuSortList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuSortList.ButtonText = "Organizar Lista";
            btnMenuSortList.ButtonTextMarginLeft = 0;
            btnMenuSortList.ColorContrastOnClick = 45;
            btnMenuSortList.ColorContrastOnHover = 45;
            btnMenuSortList.Cursor = Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnMenuSortList.CustomizableEdges = borderEdges2;
            btnMenuSortList.DialogResult = DialogResult.None;
            btnMenuSortList.DisabledBorderColor = Color.Transparent;
            btnMenuSortList.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnMenuSortList.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnMenuSortList.Dock = DockStyle.Left;
            btnMenuSortList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnMenuSortList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuSortList.ForeColor = Color.White;
            btnMenuSortList.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnMenuSortList.IconLeftCursor = Cursors.Default;
            btnMenuSortList.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnMenuSortList.IconMarginLeft = 11;
            btnMenuSortList.IconPadding = 10;
            btnMenuSortList.IconRightAlign = ContentAlignment.MiddleRight;
            btnMenuSortList.IconRightCursor = Cursors.Default;
            btnMenuSortList.IconRightPadding = new Padding(3, 3, 7, 3);
            btnMenuSortList.IconSize = 25;
            btnMenuSortList.IdleBorderColor = Color.Transparent;
            btnMenuSortList.IdleBorderRadius = 8;
            btnMenuSortList.IdleBorderThickness = 1;
            btnMenuSortList.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnMenuSortList.IdleIconLeftImage = Properties.Resources.list;
            btnMenuSortList.IdleIconRightImage = null;
            btnMenuSortList.IndicateFocus = false;
            btnMenuSortList.Location = new Point(16, 64);
            btnMenuSortList.Margin = new Padding(0, 4, 0, 4);
            btnMenuSortList.Name = "btnMenuSortList";
            btnMenuSortList.OnDisabledState.BorderColor = Color.Transparent;
            btnMenuSortList.OnDisabledState.BorderRadius = 8;
            btnMenuSortList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuSortList.OnDisabledState.BorderThickness = 1;
            btnMenuSortList.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnMenuSortList.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnMenuSortList.OnDisabledState.IconLeftImage = null;
            btnMenuSortList.OnDisabledState.IconRightImage = null;
            btnMenuSortList.onHoverState.BorderColor = Color.Transparent;
            btnMenuSortList.onHoverState.BorderRadius = 8;
            btnMenuSortList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuSortList.onHoverState.BorderThickness = 1;
            btnMenuSortList.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuSortList.onHoverState.ForeColor = Color.White;
            btnMenuSortList.onHoverState.IconLeftImage = null;
            btnMenuSortList.onHoverState.IconRightImage = null;
            btnMenuSortList.OnIdleState.BorderColor = Color.Transparent;
            btnMenuSortList.OnIdleState.BorderRadius = 8;
            btnMenuSortList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuSortList.OnIdleState.BorderThickness = 1;
            btnMenuSortList.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnMenuSortList.OnIdleState.ForeColor = Color.White;
            btnMenuSortList.OnIdleState.IconLeftImage = Properties.Resources.list;
            btnMenuSortList.OnIdleState.IconRightImage = null;
            btnMenuSortList.OnPressedState.BorderColor = Color.Transparent;
            btnMenuSortList.OnPressedState.BorderRadius = 8;
            btnMenuSortList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuSortList.OnPressedState.BorderThickness = 1;
            btnMenuSortList.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuSortList.OnPressedState.ForeColor = Color.White;
            btnMenuSortList.OnPressedState.IconLeftImage = null;
            btnMenuSortList.OnPressedState.IconRightImage = null;
            btnMenuSortList.Size = new Size(171, 36);
            btnMenuSortList.TabIndex = 12;
            btnMenuSortList.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSortList.TextAlignment = HorizontalAlignment.Center;
            btnMenuSortList.TextMarginLeft = 0;
            btnMenuSortList.TextPadding = new Padding(36, 0, 0, 0);
            btnMenuSortList.UseDefaultRadiusAndThickness = true;
            btnMenuSortList.Click += btnMenuSortList_Click;
            // 
            // btnMenuCalcArea
            // 
            btnMenuCalcArea.AllowAnimations = true;
            btnMenuCalcArea.AllowMouseEffects = true;
            btnMenuCalcArea.AllowToggling = false;
            btnMenuCalcArea.AnimationSpeed = 25;
            btnMenuCalcArea.AutoGenerateColors = false;
            btnMenuCalcArea.AutoRoundBorders = false;
            btnMenuCalcArea.AutoSizeLeftIcon = true;
            btnMenuCalcArea.AutoSizeRightIcon = true;
            btnMenuCalcArea.BackColor = Color.Transparent;
            btnMenuCalcArea.BackColor1 = Color.FromArgb(24, 22, 27);
            btnMenuCalcArea.BackgroundImage = (Image)resources.GetObject("btnMenuCalcArea.BackgroundImage");
            btnMenuCalcArea.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuCalcArea.ButtonText = "Calcular Área";
            btnMenuCalcArea.ButtonTextMarginLeft = 0;
            btnMenuCalcArea.ColorContrastOnClick = 45;
            btnMenuCalcArea.ColorContrastOnHover = 45;
            btnMenuCalcArea.Cursor = Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            btnMenuCalcArea.CustomizableEdges = borderEdges3;
            btnMenuCalcArea.DialogResult = DialogResult.None;
            btnMenuCalcArea.DisabledBorderColor = Color.Transparent;
            btnMenuCalcArea.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnMenuCalcArea.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnMenuCalcArea.Dock = DockStyle.Left;
            btnMenuCalcArea.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnMenuCalcArea.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuCalcArea.ForeColor = Color.White;
            btnMenuCalcArea.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnMenuCalcArea.IconLeftCursor = Cursors.Default;
            btnMenuCalcArea.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnMenuCalcArea.IconMarginLeft = 11;
            btnMenuCalcArea.IconPadding = 10;
            btnMenuCalcArea.IconRightAlign = ContentAlignment.MiddleRight;
            btnMenuCalcArea.IconRightCursor = Cursors.Default;
            btnMenuCalcArea.IconRightPadding = new Padding(3, 3, 7, 3);
            btnMenuCalcArea.IconSize = 25;
            btnMenuCalcArea.IdleBorderColor = Color.Transparent;
            btnMenuCalcArea.IdleBorderRadius = 8;
            btnMenuCalcArea.IdleBorderThickness = 1;
            btnMenuCalcArea.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnMenuCalcArea.IdleIconLeftImage = Properties.Resources.square_dashed_bottom;
            btnMenuCalcArea.IdleIconRightImage = null;
            btnMenuCalcArea.IndicateFocus = false;
            btnMenuCalcArea.Location = new Point(16, 108);
            btnMenuCalcArea.Margin = new Padding(0, 4, 0, 4);
            btnMenuCalcArea.Name = "btnMenuCalcArea";
            btnMenuCalcArea.OnDisabledState.BorderColor = Color.Transparent;
            btnMenuCalcArea.OnDisabledState.BorderRadius = 8;
            btnMenuCalcArea.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuCalcArea.OnDisabledState.BorderThickness = 1;
            btnMenuCalcArea.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnMenuCalcArea.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnMenuCalcArea.OnDisabledState.IconLeftImage = null;
            btnMenuCalcArea.OnDisabledState.IconRightImage = null;
            btnMenuCalcArea.onHoverState.BorderColor = Color.Transparent;
            btnMenuCalcArea.onHoverState.BorderRadius = 8;
            btnMenuCalcArea.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuCalcArea.onHoverState.BorderThickness = 1;
            btnMenuCalcArea.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuCalcArea.onHoverState.ForeColor = Color.White;
            btnMenuCalcArea.onHoverState.IconLeftImage = null;
            btnMenuCalcArea.onHoverState.IconRightImage = null;
            btnMenuCalcArea.OnIdleState.BorderColor = Color.Transparent;
            btnMenuCalcArea.OnIdleState.BorderRadius = 8;
            btnMenuCalcArea.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuCalcArea.OnIdleState.BorderThickness = 1;
            btnMenuCalcArea.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnMenuCalcArea.OnIdleState.ForeColor = Color.White;
            btnMenuCalcArea.OnIdleState.IconLeftImage = Properties.Resources.square_dashed_bottom;
            btnMenuCalcArea.OnIdleState.IconRightImage = null;
            btnMenuCalcArea.OnPressedState.BorderColor = Color.Transparent;
            btnMenuCalcArea.OnPressedState.BorderRadius = 8;
            btnMenuCalcArea.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuCalcArea.OnPressedState.BorderThickness = 1;
            btnMenuCalcArea.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuCalcArea.OnPressedState.ForeColor = Color.White;
            btnMenuCalcArea.OnPressedState.IconLeftImage = null;
            btnMenuCalcArea.OnPressedState.IconRightImage = null;
            btnMenuCalcArea.Size = new Size(171, 36);
            btnMenuCalcArea.TabIndex = 13;
            btnMenuCalcArea.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCalcArea.TextAlignment = HorizontalAlignment.Center;
            btnMenuCalcArea.TextMarginLeft = 0;
            btnMenuCalcArea.TextPadding = new Padding(36, 0, 0, 0);
            btnMenuCalcArea.UseDefaultRadiusAndThickness = true;
            btnMenuCalcArea.Click += btnMenuCalcArea_Click;
            // 
            // btnMenuMultOfTree
            // 
            btnMenuMultOfTree.AllowAnimations = true;
            btnMenuMultOfTree.AllowMouseEffects = true;
            btnMenuMultOfTree.AllowToggling = false;
            btnMenuMultOfTree.AnimationSpeed = 25;
            btnMenuMultOfTree.AutoGenerateColors = false;
            btnMenuMultOfTree.AutoRoundBorders = false;
            btnMenuMultOfTree.AutoSizeLeftIcon = true;
            btnMenuMultOfTree.AutoSizeRightIcon = true;
            btnMenuMultOfTree.BackColor = Color.Transparent;
            btnMenuMultOfTree.BackColor1 = Color.FromArgb(24, 22, 27);
            btnMenuMultOfTree.BackgroundImage = (Image)resources.GetObject("btnMenuMultOfTree.BackgroundImage");
            btnMenuMultOfTree.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuMultOfTree.ButtonText = "Múltiplos de 3";
            btnMenuMultOfTree.ButtonTextMarginLeft = 0;
            btnMenuMultOfTree.ColorContrastOnClick = 45;
            btnMenuMultOfTree.ColorContrastOnHover = 45;
            btnMenuMultOfTree.Cursor = Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            btnMenuMultOfTree.CustomizableEdges = borderEdges4;
            btnMenuMultOfTree.DialogResult = DialogResult.None;
            btnMenuMultOfTree.DisabledBorderColor = Color.Transparent;
            btnMenuMultOfTree.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnMenuMultOfTree.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnMenuMultOfTree.Dock = DockStyle.Left;
            btnMenuMultOfTree.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnMenuMultOfTree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuMultOfTree.ForeColor = Color.White;
            btnMenuMultOfTree.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnMenuMultOfTree.IconLeftCursor = Cursors.Default;
            btnMenuMultOfTree.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnMenuMultOfTree.IconMarginLeft = 11;
            btnMenuMultOfTree.IconPadding = 10;
            btnMenuMultOfTree.IconRightAlign = ContentAlignment.MiddleRight;
            btnMenuMultOfTree.IconRightCursor = Cursors.Default;
            btnMenuMultOfTree.IconRightPadding = new Padding(3, 3, 7, 3);
            btnMenuMultOfTree.IconSize = 25;
            btnMenuMultOfTree.IdleBorderColor = Color.Transparent;
            btnMenuMultOfTree.IdleBorderRadius = 8;
            btnMenuMultOfTree.IdleBorderThickness = 1;
            btnMenuMultOfTree.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnMenuMultOfTree.IdleIconLeftImage = Properties.Resources.repeat;
            btnMenuMultOfTree.IdleIconRightImage = null;
            btnMenuMultOfTree.IndicateFocus = false;
            btnMenuMultOfTree.Location = new Point(16, 152);
            btnMenuMultOfTree.Margin = new Padding(0, 4, 0, 4);
            btnMenuMultOfTree.Name = "btnMenuMultOfTree";
            btnMenuMultOfTree.OnDisabledState.BorderColor = Color.Transparent;
            btnMenuMultOfTree.OnDisabledState.BorderRadius = 8;
            btnMenuMultOfTree.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuMultOfTree.OnDisabledState.BorderThickness = 1;
            btnMenuMultOfTree.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnMenuMultOfTree.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnMenuMultOfTree.OnDisabledState.IconLeftImage = null;
            btnMenuMultOfTree.OnDisabledState.IconRightImage = null;
            btnMenuMultOfTree.onHoverState.BorderColor = Color.Transparent;
            btnMenuMultOfTree.onHoverState.BorderRadius = 8;
            btnMenuMultOfTree.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuMultOfTree.onHoverState.BorderThickness = 1;
            btnMenuMultOfTree.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuMultOfTree.onHoverState.ForeColor = Color.White;
            btnMenuMultOfTree.onHoverState.IconLeftImage = null;
            btnMenuMultOfTree.onHoverState.IconRightImage = null;
            btnMenuMultOfTree.OnIdleState.BorderColor = Color.Transparent;
            btnMenuMultOfTree.OnIdleState.BorderRadius = 8;
            btnMenuMultOfTree.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuMultOfTree.OnIdleState.BorderThickness = 1;
            btnMenuMultOfTree.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnMenuMultOfTree.OnIdleState.ForeColor = Color.White;
            btnMenuMultOfTree.OnIdleState.IconLeftImage = Properties.Resources.repeat;
            btnMenuMultOfTree.OnIdleState.IconRightImage = null;
            btnMenuMultOfTree.OnPressedState.BorderColor = Color.Transparent;
            btnMenuMultOfTree.OnPressedState.BorderRadius = 8;
            btnMenuMultOfTree.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuMultOfTree.OnPressedState.BorderThickness = 1;
            btnMenuMultOfTree.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuMultOfTree.OnPressedState.ForeColor = Color.White;
            btnMenuMultOfTree.OnPressedState.IconLeftImage = null;
            btnMenuMultOfTree.OnPressedState.IconRightImage = null;
            btnMenuMultOfTree.Size = new Size(171, 36);
            btnMenuMultOfTree.TabIndex = 14;
            btnMenuMultOfTree.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuMultOfTree.TextAlignment = HorizontalAlignment.Center;
            btnMenuMultOfTree.TextMarginLeft = 0;
            btnMenuMultOfTree.TextPadding = new Padding(36, 0, 0, 0);
            btnMenuMultOfTree.UseDefaultRadiusAndThickness = true;
            btnMenuMultOfTree.Click += btnMenuMultOfTree_Click;
            // 
            // btnMenuPersonClass
            // 
            btnMenuPersonClass.AllowAnimations = true;
            btnMenuPersonClass.AllowMouseEffects = true;
            btnMenuPersonClass.AllowToggling = false;
            btnMenuPersonClass.AnimationSpeed = 25;
            btnMenuPersonClass.AutoGenerateColors = false;
            btnMenuPersonClass.AutoRoundBorders = false;
            btnMenuPersonClass.AutoSizeLeftIcon = true;
            btnMenuPersonClass.AutoSizeRightIcon = true;
            btnMenuPersonClass.BackColor = Color.Transparent;
            btnMenuPersonClass.BackColor1 = Color.FromArgb(24, 22, 27);
            btnMenuPersonClass.BackgroundImage = (Image)resources.GetObject("btnMenuPersonClass.BackgroundImage");
            btnMenuPersonClass.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuPersonClass.ButtonText = "Classe Pessoa";
            btnMenuPersonClass.ButtonTextMarginLeft = 0;
            btnMenuPersonClass.ColorContrastOnClick = 45;
            btnMenuPersonClass.ColorContrastOnHover = 45;
            btnMenuPersonClass.Cursor = Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            btnMenuPersonClass.CustomizableEdges = borderEdges5;
            btnMenuPersonClass.DialogResult = DialogResult.None;
            btnMenuPersonClass.DisabledBorderColor = Color.Transparent;
            btnMenuPersonClass.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnMenuPersonClass.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnMenuPersonClass.Dock = DockStyle.Left;
            btnMenuPersonClass.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnMenuPersonClass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuPersonClass.ForeColor = Color.White;
            btnMenuPersonClass.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnMenuPersonClass.IconLeftCursor = Cursors.Default;
            btnMenuPersonClass.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnMenuPersonClass.IconMarginLeft = 11;
            btnMenuPersonClass.IconPadding = 10;
            btnMenuPersonClass.IconRightAlign = ContentAlignment.MiddleRight;
            btnMenuPersonClass.IconRightCursor = Cursors.Default;
            btnMenuPersonClass.IconRightPadding = new Padding(3, 3, 7, 3);
            btnMenuPersonClass.IconSize = 25;
            btnMenuPersonClass.IdleBorderColor = Color.Transparent;
            btnMenuPersonClass.IdleBorderRadius = 8;
            btnMenuPersonClass.IdleBorderThickness = 1;
            btnMenuPersonClass.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnMenuPersonClass.IdleIconLeftImage = Properties.Resources.user;
            btnMenuPersonClass.IdleIconRightImage = null;
            btnMenuPersonClass.IndicateFocus = false;
            btnMenuPersonClass.Location = new Point(16, 196);
            btnMenuPersonClass.Margin = new Padding(0, 4, 0, 4);
            btnMenuPersonClass.Name = "btnMenuPersonClass";
            btnMenuPersonClass.OnDisabledState.BorderColor = Color.Transparent;
            btnMenuPersonClass.OnDisabledState.BorderRadius = 8;
            btnMenuPersonClass.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuPersonClass.OnDisabledState.BorderThickness = 1;
            btnMenuPersonClass.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnMenuPersonClass.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnMenuPersonClass.OnDisabledState.IconLeftImage = null;
            btnMenuPersonClass.OnDisabledState.IconRightImage = null;
            btnMenuPersonClass.onHoverState.BorderColor = Color.Transparent;
            btnMenuPersonClass.onHoverState.BorderRadius = 8;
            btnMenuPersonClass.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuPersonClass.onHoverState.BorderThickness = 1;
            btnMenuPersonClass.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuPersonClass.onHoverState.ForeColor = Color.White;
            btnMenuPersonClass.onHoverState.IconLeftImage = null;
            btnMenuPersonClass.onHoverState.IconRightImage = null;
            btnMenuPersonClass.OnIdleState.BorderColor = Color.Transparent;
            btnMenuPersonClass.OnIdleState.BorderRadius = 8;
            btnMenuPersonClass.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuPersonClass.OnIdleState.BorderThickness = 1;
            btnMenuPersonClass.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnMenuPersonClass.OnIdleState.ForeColor = Color.White;
            btnMenuPersonClass.OnIdleState.IconLeftImage = Properties.Resources.user;
            btnMenuPersonClass.OnIdleState.IconRightImage = null;
            btnMenuPersonClass.OnPressedState.BorderColor = Color.Transparent;
            btnMenuPersonClass.OnPressedState.BorderRadius = 8;
            btnMenuPersonClass.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnMenuPersonClass.OnPressedState.BorderThickness = 1;
            btnMenuPersonClass.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnMenuPersonClass.OnPressedState.ForeColor = Color.White;
            btnMenuPersonClass.OnPressedState.IconLeftImage = null;
            btnMenuPersonClass.OnPressedState.IconRightImage = null;
            btnMenuPersonClass.Size = new Size(171, 36);
            btnMenuPersonClass.TabIndex = 15;
            btnMenuPersonClass.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPersonClass.TextAlignment = HorizontalAlignment.Center;
            btnMenuPersonClass.TextMarginLeft = 0;
            btnMenuPersonClass.TextPadding = new Padding(36, 0, 0, 0);
            btnMenuPersonClass.UseDefaultRadiusAndThickness = true;
            btnMenuPersonClass.Click += btnMenuPersonClass_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(24, 22, 27);
            pnlSidebar.Controls.Add(btnExit);
            pnlSidebar.Controls.Add(pnlNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 88);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(202, 509);
            pnlSidebar.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.AllowAnimations = true;
            btnExit.AllowMouseEffects = true;
            btnExit.AllowToggling = false;
            btnExit.AnimationSpeed = 25;
            btnExit.AutoGenerateColors = false;
            btnExit.AutoRoundBorders = false;
            btnExit.AutoSizeLeftIcon = true;
            btnExit.AutoSizeRightIcon = true;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackColor1 = Color.FromArgb(24, 22, 27);
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnExit.ButtonText = "Sair";
            btnExit.ButtonTextMarginLeft = 0;
            btnExit.ColorContrastOnClick = 45;
            btnExit.ColorContrastOnHover = 45;
            btnExit.Cursor = Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            btnExit.CustomizableEdges = borderEdges6;
            btnExit.DialogResult = DialogResult.None;
            btnExit.DisabledBorderColor = Color.Transparent;
            btnExit.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnExit.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnExit.IconLeftCursor = Cursors.Default;
            btnExit.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnExit.IconMarginLeft = 11;
            btnExit.IconPadding = 10;
            btnExit.IconRightAlign = ContentAlignment.MiddleRight;
            btnExit.IconRightCursor = Cursors.Default;
            btnExit.IconRightPadding = new Padding(3, 3, 7, 3);
            btnExit.IconSize = 25;
            btnExit.IdleBorderColor = Color.Transparent;
            btnExit.IdleBorderRadius = 8;
            btnExit.IdleBorderThickness = 1;
            btnExit.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnExit.IdleIconLeftImage = Properties.Resources.exit;
            btnExit.IdleIconRightImage = null;
            btnExit.IndicateFocus = false;
            btnExit.Location = new Point(15, 461);
            btnExit.Name = "btnExit";
            btnExit.OnDisabledState.BorderColor = Color.Transparent;
            btnExit.OnDisabledState.BorderRadius = 8;
            btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnExit.OnDisabledState.BorderThickness = 1;
            btnExit.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnExit.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnExit.OnDisabledState.IconLeftImage = null;
            btnExit.OnDisabledState.IconRightImage = null;
            btnExit.onHoverState.BorderColor = Color.Transparent;
            btnExit.onHoverState.BorderRadius = 8;
            btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnExit.onHoverState.BorderThickness = 1;
            btnExit.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnExit.onHoverState.ForeColor = Color.White;
            btnExit.onHoverState.IconLeftImage = null;
            btnExit.onHoverState.IconRightImage = null;
            btnExit.OnIdleState.BorderColor = Color.Transparent;
            btnExit.OnIdleState.BorderRadius = 8;
            btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnExit.OnIdleState.BorderThickness = 1;
            btnExit.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnExit.OnIdleState.ForeColor = Color.White;
            btnExit.OnIdleState.IconLeftImage = Properties.Resources.exit;
            btnExit.OnIdleState.IconRightImage = null;
            btnExit.OnPressedState.BorderColor = Color.Transparent;
            btnExit.OnPressedState.BorderRadius = 8;
            btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnExit.OnPressedState.BorderThickness = 1;
            btnExit.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnExit.OnPressedState.ForeColor = Color.White;
            btnExit.OnPressedState.IconLeftImage = null;
            btnExit.OnPressedState.IconRightImage = null;
            btnExit.Size = new Size(172, 36);
            btnExit.TabIndex = 16;
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextAlignment = HorizontalAlignment.Center;
            btnExit.TextMarginLeft = 0;
            btnExit.TextPadding = new Padding(36, 0, 0, 0);
            btnExit.UseDefaultRadiusAndThickness = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lblTextGuide);
            pnlMain.Controls.Add(lblLogical);
            pnlMain.Controls.Add(lblWelcome);
            pnlMain.Controls.Add(pictureBox1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(202, 88);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(858, 509);
            pnlMain.TabIndex = 14;
            // 
            // lblTextGuide
            // 
            lblTextGuide.Font = new Font("Segoe UI", 11F);
            lblTextGuide.ForeColor = Color.FromArgb(33, 33, 33);
            lblTextGuide.Location = new Point(78, 246);
            lblTextGuide.Name = "lblTextGuide";
            lblTextGuide.Size = new Size(257, 75);
            lblTextGuide.TabIndex = 7;
            lblTextGuide.Text = "Você pode navegar pelos desafios através do menu lateral.";
            lblTextGuide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogical
            // 
            lblLogical.AutoSize = true;
            lblLogical.Font = new Font("Segoe UI", 14F);
            lblLogical.ForeColor = Color.FromArgb(113, 113, 113);
            lblLogical.Location = new Point(87, 198);
            lblLogical.Name = "lblLogical";
            lblLogical.Size = new Size(234, 25);
            lblLogical.TabIndex = 6;
            lblLogical.Text = "Desafios de lógica com C#";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(26, 26, 30);
            lblWelcome.Location = new Point(101, 151);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(206, 45);
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
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste - Atak Sistemas";
            FormClosed += FormMain_FormClosed;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuFlatButton1;
        private Label lblUserName;
        private Panel pnlSidebar;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private Label lblLogical;
        private Label lblWelcome;
        private Label lblTextGuide;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMenuEvenOdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMenuSortList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMenuCalcArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMenuMultOfTree;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnMenuPersonClass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnExit;
    }
}
