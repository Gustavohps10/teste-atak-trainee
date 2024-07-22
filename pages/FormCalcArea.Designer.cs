namespace teste_atak
{
    partial class FormCalcArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalcArea));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            label1 = new Label();
            lblWidth = new Label();
            lblHeight = new Label();
            lblArea = new Label();
            btnCalculate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            txtWidth = new Bunifu.UI.WinForms.BunifuTextBox();
            txtHeight = new Bunifu.UI.WinForms.BunifuTextBox();
            txtArea = new Bunifu.UI.WinForms.BunifuTextBox();
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
            label1.Size = new Size(874, 58);
            label1.TabIndex = 1;
            label1.Text = "Calcular Área";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Segoe UI", 14.25F);
            lblWidth.Location = new Point(263, 108);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(119, 25);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Largura (cm)";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 14.25F);
            lblHeight.Location = new Point(446, 108);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(105, 25);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Altura (cm)";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(494, 226);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(106, 25);
            lblArea.TabIndex = 6;
            lblArea.Text = "Área (cm²)";
            lblArea.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            btnCalculate.AllowAnimations = true;
            btnCalculate.AllowMouseEffects = true;
            btnCalculate.AllowToggling = false;
            btnCalculate.AnimationSpeed = 25;
            btnCalculate.AutoGenerateColors = false;
            btnCalculate.AutoRoundBorders = false;
            btnCalculate.AutoSizeLeftIcon = true;
            btnCalculate.AutoSizeRightIcon = true;
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.BackColor1 = Color.FromArgb(24, 22, 27);
            btnCalculate.BackgroundImage = (Image)resources.GetObject("btnCalculate.BackgroundImage");
            btnCalculate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCalculate.ButtonText = "Calcular";
            btnCalculate.ButtonTextMarginLeft = 0;
            btnCalculate.ColorContrastOnClick = 45;
            btnCalculate.ColorContrastOnHover = 45;
            btnCalculate.Cursor = Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnCalculate.CustomizableEdges = borderEdges1;
            btnCalculate.DialogResult = DialogResult.None;
            btnCalculate.DisabledBorderColor = Color.Transparent;
            btnCalculate.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnCalculate.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnCalculate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnCalculate.IconLeftCursor = Cursors.Default;
            btnCalculate.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnCalculate.IconMarginLeft = 11;
            btnCalculate.IconPadding = 10;
            btnCalculate.IconRightAlign = ContentAlignment.MiddleRight;
            btnCalculate.IconRightCursor = Cursors.Default;
            btnCalculate.IconRightPadding = new Padding(3, 3, 7, 3);
            btnCalculate.IconSize = 25;
            btnCalculate.IdleBorderColor = Color.Transparent;
            btnCalculate.IdleBorderRadius = 8;
            btnCalculate.IdleBorderThickness = 1;
            btnCalculate.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnCalculate.IdleIconLeftImage = null;
            btnCalculate.IdleIconRightImage = null;
            btnCalculate.IndicateFocus = false;
            btnCalculate.Location = new Point(263, 194);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.OnDisabledState.BorderColor = Color.Transparent;
            btnCalculate.OnDisabledState.BorderRadius = 8;
            btnCalculate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCalculate.OnDisabledState.BorderThickness = 1;
            btnCalculate.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnCalculate.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnCalculate.OnDisabledState.IconLeftImage = null;
            btnCalculate.OnDisabledState.IconRightImage = null;
            btnCalculate.onHoverState.BorderColor = Color.Transparent;
            btnCalculate.onHoverState.BorderRadius = 8;
            btnCalculate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCalculate.onHoverState.BorderThickness = 1;
            btnCalculate.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnCalculate.onHoverState.ForeColor = Color.White;
            btnCalculate.onHoverState.IconLeftImage = null;
            btnCalculate.onHoverState.IconRightImage = null;
            btnCalculate.OnIdleState.BorderColor = Color.Transparent;
            btnCalculate.OnIdleState.BorderRadius = 8;
            btnCalculate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCalculate.OnIdleState.BorderThickness = 1;
            btnCalculate.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnCalculate.OnIdleState.ForeColor = Color.White;
            btnCalculate.OnIdleState.IconLeftImage = null;
            btnCalculate.OnIdleState.IconRightImage = null;
            btnCalculate.OnPressedState.BorderColor = Color.Transparent;
            btnCalculate.OnPressedState.BorderRadius = 8;
            btnCalculate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCalculate.OnPressedState.BorderThickness = 1;
            btnCalculate.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnCalculate.OnPressedState.ForeColor = Color.White;
            btnCalculate.OnPressedState.IconLeftImage = null;
            btnCalculate.OnPressedState.IconRightImage = null;
            btnCalculate.Size = new Size(114, 36);
            btnCalculate.TabIndex = 18;
            btnCalculate.TextAlign = ContentAlignment.MiddleCenter;
            btnCalculate.TextAlignment = HorizontalAlignment.Center;
            btnCalculate.TextMarginLeft = 0;
            btnCalculate.TextPadding = new Padding(0);
            btnCalculate.UseDefaultRadiusAndThickness = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtWidth
            // 
            txtWidth.AcceptsReturn = false;
            txtWidth.AcceptsTab = false;
            txtWidth.AnimationSpeed = 200;
            txtWidth.AutoCompleteMode = AutoCompleteMode.None;
            txtWidth.AutoCompleteSource = AutoCompleteSource.None;
            txtWidth.AutoSizeHeight = true;
            txtWidth.BackColor = Color.Transparent;
            txtWidth.BackgroundImage = (Image)resources.GetObject("txtWidth.BackgroundImage");
            txtWidth.BorderColorActive = Color.DodgerBlue;
            txtWidth.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtWidth.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtWidth.BorderColorIdle = Color.Silver;
            txtWidth.BorderRadius = 1;
            txtWidth.BorderThickness = 1;
            txtWidth.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtWidth.CharacterCasing = CharacterCasing.Normal;
            txtWidth.DefaultFont = new Font("Segoe UI", 9.25F);
            txtWidth.DefaultText = "";
            txtWidth.FillColor = Color.White;
            txtWidth.HideSelection = true;
            txtWidth.IconLeft = null;
            txtWidth.IconLeftCursor = Cursors.IBeam;
            txtWidth.IconPadding = 10;
            txtWidth.IconRight = null;
            txtWidth.IconRightCursor = Cursors.IBeam;
            txtWidth.Location = new Point(263, 137);
            txtWidth.MaxLength = 32767;
            txtWidth.MinimumSize = new Size(1, 1);
            txtWidth.Modified = false;
            txtWidth.Multiline = false;
            txtWidth.Name = "txtWidth";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtWidth.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtWidth.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtWidth.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtWidth.OnIdleState = stateProperties4;
            txtWidth.Padding = new Padding(3);
            txtWidth.PasswordChar = '\0';
            txtWidth.PlaceholderForeColor = Color.Silver;
            txtWidth.PlaceholderText = "Digite a largura";
            txtWidth.ReadOnly = false;
            txtWidth.ScrollBars = ScrollBars.None;
            txtWidth.SelectedText = "";
            txtWidth.SelectionLength = 0;
            txtWidth.SelectionStart = 0;
            txtWidth.ShortcutsEnabled = true;
            txtWidth.Size = new Size(150, 39);
            txtWidth.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtWidth.TabIndex = 19;
            txtWidth.TextAlign = HorizontalAlignment.Left;
            txtWidth.TextMarginBottom = 0;
            txtWidth.TextMarginLeft = 3;
            txtWidth.TextMarginTop = 1;
            txtWidth.TextPlaceholder = "Digite a largura";
            txtWidth.UseSystemPasswordChar = false;
            txtWidth.WordWrap = true;
            // 
            // txtHeight
            // 
            txtHeight.AcceptsReturn = false;
            txtHeight.AcceptsTab = false;
            txtHeight.AnimationSpeed = 200;
            txtHeight.AutoCompleteMode = AutoCompleteMode.None;
            txtHeight.AutoCompleteSource = AutoCompleteSource.None;
            txtHeight.AutoSizeHeight = true;
            txtHeight.BackColor = Color.Transparent;
            txtHeight.BackgroundImage = (Image)resources.GetObject("txtHeight.BackgroundImage");
            txtHeight.BorderColorActive = Color.DodgerBlue;
            txtHeight.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtHeight.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtHeight.BorderColorIdle = Color.Silver;
            txtHeight.BorderRadius = 1;
            txtHeight.BorderThickness = 1;
            txtHeight.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtHeight.CharacterCasing = CharacterCasing.Normal;
            txtHeight.DefaultFont = new Font("Segoe UI", 9.25F);
            txtHeight.DefaultText = "";
            txtHeight.FillColor = Color.White;
            txtHeight.HideSelection = true;
            txtHeight.IconLeft = null;
            txtHeight.IconLeftCursor = Cursors.IBeam;
            txtHeight.IconPadding = 10;
            txtHeight.IconRight = null;
            txtHeight.IconRightCursor = Cursors.IBeam;
            txtHeight.Location = new Point(446, 137);
            txtHeight.MaxLength = 32767;
            txtHeight.MinimumSize = new Size(1, 1);
            txtHeight.Modified = false;
            txtHeight.Multiline = false;
            txtHeight.Name = "txtHeight";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtHeight.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtHeight.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtHeight.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtHeight.OnIdleState = stateProperties8;
            txtHeight.Padding = new Padding(3);
            txtHeight.PasswordChar = '\0';
            txtHeight.PlaceholderForeColor = Color.Silver;
            txtHeight.PlaceholderText = "Digite a altura";
            txtHeight.ReadOnly = false;
            txtHeight.ScrollBars = ScrollBars.None;
            txtHeight.SelectedText = "";
            txtHeight.SelectionLength = 0;
            txtHeight.SelectionStart = 0;
            txtHeight.ShortcutsEnabled = true;
            txtHeight.Size = new Size(150, 39);
            txtHeight.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtHeight.TabIndex = 20;
            txtHeight.TextAlign = HorizontalAlignment.Left;
            txtHeight.TextMarginBottom = 0;
            txtHeight.TextMarginLeft = 3;
            txtHeight.TextMarginTop = 1;
            txtHeight.TextPlaceholder = "Digite a altura";
            txtHeight.UseSystemPasswordChar = false;
            txtHeight.WordWrap = true;
            // 
            // txtArea
            // 
            txtArea.AcceptsReturn = false;
            txtArea.AcceptsTab = false;
            txtArea.AnimationSpeed = 200;
            txtArea.AutoCompleteMode = AutoCompleteMode.None;
            txtArea.AutoCompleteSource = AutoCompleteSource.None;
            txtArea.AutoSizeHeight = true;
            txtArea.BackColor = Color.Transparent;
            txtArea.BackgroundImage = (Image)resources.GetObject("txtArea.BackgroundImage");
            txtArea.BorderColorActive = Color.DodgerBlue;
            txtArea.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtArea.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtArea.BorderColorIdle = Color.Silver;
            txtArea.BorderRadius = 1;
            txtArea.BorderThickness = 1;
            txtArea.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtArea.CharacterCasing = CharacterCasing.Normal;
            txtArea.DefaultFont = new Font("Segoe UI", 9F);
            txtArea.DefaultText = "";
            txtArea.FillColor = Color.White;
            txtArea.HideSelection = true;
            txtArea.IconLeft = null;
            txtArea.IconLeftCursor = Cursors.IBeam;
            txtArea.IconPadding = 10;
            txtArea.IconRight = null;
            txtArea.IconRightCursor = Cursors.IBeam;
            txtArea.Location = new Point(446, 254);
            txtArea.MaxLength = 32767;
            txtArea.MinimumSize = new Size(1, 1);
            txtArea.Modified = false;
            txtArea.Multiline = false;
            txtArea.Name = "txtArea";
            stateProperties9.BorderColor = Color.DodgerBlue;
            stateProperties9.FillColor = Color.Empty;
            stateProperties9.ForeColor = Color.Empty;
            stateProperties9.PlaceholderForeColor = Color.Empty;
            txtArea.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties10.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties10.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties10.PlaceholderForeColor = Color.DarkGray;
            txtArea.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties11.FillColor = Color.Empty;
            stateProperties11.ForeColor = Color.Empty;
            stateProperties11.PlaceholderForeColor = Color.Empty;
            txtArea.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = Color.Silver;
            stateProperties12.FillColor = Color.White;
            stateProperties12.ForeColor = Color.Empty;
            stateProperties12.PlaceholderForeColor = Color.Empty;
            txtArea.OnIdleState = stateProperties12;
            txtArea.Padding = new Padding(3);
            txtArea.PasswordChar = '\0';
            txtArea.PlaceholderForeColor = Color.Silver;
            txtArea.PlaceholderText = "Área";
            txtArea.ReadOnly = true;
            txtArea.ScrollBars = ScrollBars.None;
            txtArea.SelectedText = "";
            txtArea.SelectionLength = 0;
            txtArea.SelectionStart = 0;
            txtArea.ShortcutsEnabled = true;
            txtArea.Size = new Size(150, 38);
            txtArea.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtArea.TabIndex = 21;
            txtArea.TextAlign = HorizontalAlignment.Right;
            txtArea.TextMarginBottom = 0;
            txtArea.TextMarginLeft = 3;
            txtArea.TextMarginTop = 1;
            txtArea.TextPlaceholder = "Área";
            txtArea.UseSystemPasswordChar = false;
            txtArea.WordWrap = true;
            // 
            // FormCalcArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(874, 484);
            Controls.Add(txtArea);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(btnCalculate);
            Controls.Add(lblArea);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormCalcArea";
            Text = "Calcular Área";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblWidth;
        private Label lblHeight;
        private Label lblArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCalculate;
        private Bunifu.UI.WinForms.BunifuTextBox txtWidth;
        private Bunifu.UI.WinForms.BunifuTextBox txtHeight;
        private Bunifu.UI.WinForms.BunifuTextBox txtArea;
    }
}