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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvenOdd));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            label1 = new Label();
            lblNumber = new Label();
            lblResult = new Label();
            panel1 = new Panel();
            btnCheck = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            txtNumber = new Bunifu.UI.WinForms.BunifuTextBox();
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
            lblNumber.Location = new Point(81, 30);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(104, 15);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Digite um número";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(33, 33, 33);
            lblResult.Location = new Point(113, 155);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(190, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "O número 1 é ímpar";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(lblResult);
            panel1.Controls.Add(lblNumber);
            panel1.Location = new Point(191, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(426, 207);
            panel1.TabIndex = 5;
            // 
            // btnCheck
            // 
            btnCheck.AllowAnimations = true;
            btnCheck.AllowMouseEffects = true;
            btnCheck.AllowToggling = false;
            btnCheck.AnimationSpeed = 25;
            btnCheck.AutoGenerateColors = false;
            btnCheck.AutoRoundBorders = false;
            btnCheck.AutoSizeLeftIcon = true;
            btnCheck.AutoSizeRightIcon = true;
            btnCheck.BackColor = Color.Transparent;
            btnCheck.BackColor1 = Color.FromArgb(24, 22, 27);
            btnCheck.BackgroundImage = (Image)resources.GetObject("btnCheck.BackgroundImage");
            btnCheck.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCheck.ButtonText = "Verificar";
            btnCheck.ButtonTextMarginLeft = 0;
            btnCheck.ColorContrastOnClick = 45;
            btnCheck.ColorContrastOnHover = 45;
            btnCheck.Cursor = Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnCheck.CustomizableEdges = borderEdges1;
            btnCheck.DialogResult = DialogResult.None;
            btnCheck.DisabledBorderColor = Color.Transparent;
            btnCheck.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnCheck.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnCheck.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCheck.ForeColor = Color.White;
            btnCheck.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnCheck.IconLeftCursor = Cursors.Default;
            btnCheck.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnCheck.IconMarginLeft = 11;
            btnCheck.IconPadding = 10;
            btnCheck.IconRightAlign = ContentAlignment.MiddleRight;
            btnCheck.IconRightCursor = Cursors.Default;
            btnCheck.IconRightPadding = new Padding(3, 3, 7, 3);
            btnCheck.IconSize = 25;
            btnCheck.IdleBorderColor = Color.Transparent;
            btnCheck.IdleBorderRadius = 8;
            btnCheck.IdleBorderThickness = 1;
            btnCheck.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnCheck.IdleIconLeftImage = null;
            btnCheck.IdleIconRightImage = null;
            btnCheck.IndicateFocus = false;
            btnCheck.Location = new Point(81, 93);
            btnCheck.Name = "btnCheck";
            btnCheck.OnDisabledState.BorderColor = Color.Transparent;
            btnCheck.OnDisabledState.BorderRadius = 8;
            btnCheck.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCheck.OnDisabledState.BorderThickness = 1;
            btnCheck.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnCheck.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnCheck.OnDisabledState.IconLeftImage = null;
            btnCheck.OnDisabledState.IconRightImage = null;
            btnCheck.onHoverState.BorderColor = Color.Transparent;
            btnCheck.onHoverState.BorderRadius = 8;
            btnCheck.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCheck.onHoverState.BorderThickness = 1;
            btnCheck.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnCheck.onHoverState.ForeColor = Color.White;
            btnCheck.onHoverState.IconLeftImage = null;
            btnCheck.onHoverState.IconRightImage = null;
            btnCheck.OnIdleState.BorderColor = Color.Transparent;
            btnCheck.OnIdleState.BorderRadius = 8;
            btnCheck.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCheck.OnIdleState.BorderThickness = 1;
            btnCheck.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnCheck.OnIdleState.ForeColor = Color.White;
            btnCheck.OnIdleState.IconLeftImage = null;
            btnCheck.OnIdleState.IconRightImage = null;
            btnCheck.OnPressedState.BorderColor = Color.Transparent;
            btnCheck.OnPressedState.BorderRadius = 8;
            btnCheck.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnCheck.OnPressedState.BorderThickness = 1;
            btnCheck.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnCheck.OnPressedState.ForeColor = Color.White;
            btnCheck.OnPressedState.IconLeftImage = null;
            btnCheck.OnPressedState.IconRightImage = null;
            btnCheck.Size = new Size(114, 36);
            btnCheck.TabIndex = 17;
            btnCheck.TextAlign = ContentAlignment.MiddleCenter;
            btnCheck.TextAlignment = HorizontalAlignment.Center;
            btnCheck.TextMarginLeft = 0;
            btnCheck.TextPadding = new Padding(0);
            btnCheck.UseDefaultRadiusAndThickness = true;
            btnCheck.Click += btnMenuEvenOdd_Click;
            // 
            // txtNumber
            // 
            txtNumber.AcceptsReturn = false;
            txtNumber.AcceptsTab = false;
            txtNumber.AnimationSpeed = 200;
            txtNumber.AutoCompleteMode = AutoCompleteMode.None;
            txtNumber.AutoCompleteSource = AutoCompleteSource.None;
            txtNumber.AutoSizeHeight = true;
            txtNumber.BackColor = Color.Transparent;
            txtNumber.BackgroundImage = (Image)resources.GetObject("txtNumber.BackgroundImage");
            txtNumber.BorderColorActive = Color.DodgerBlue;
            txtNumber.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtNumber.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtNumber.BorderColorIdle = Color.Silver;
            txtNumber.BorderRadius = 1;
            txtNumber.BorderThickness = 1;
            txtNumber.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtNumber.CharacterCasing = CharacterCasing.Normal;
            txtNumber.DefaultFont = new Font("Segoe UI", 9.25F);
            txtNumber.DefaultText = "1";
            txtNumber.FillColor = Color.White;
            txtNumber.HideSelection = true;
            txtNumber.IconLeft = null;
            txtNumber.IconLeftCursor = Cursors.IBeam;
            txtNumber.IconPadding = 10;
            txtNumber.IconRight = null;
            txtNumber.IconRightCursor = Cursors.IBeam;
            txtNumber.Lines = new string[]
    {
    "1"
    };
            txtNumber.Location = new Point(81, 48);
            txtNumber.MaxLength = 32767;
            txtNumber.MinimumSize = new Size(1, 1);
            txtNumber.Modified = false;
            txtNumber.Multiline = false;
            txtNumber.Name = "txtNumber";
            stateProperties1.BorderColor = Color.DodgerBlue;
            stateProperties1.FillColor = Color.Empty;
            stateProperties1.ForeColor = Color.Empty;
            stateProperties1.PlaceholderForeColor = Color.Empty;
            txtNumber.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties2.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties2.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties2.PlaceholderForeColor = Color.DarkGray;
            txtNumber.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties3.FillColor = Color.Empty;
            stateProperties3.ForeColor = Color.Empty;
            stateProperties3.PlaceholderForeColor = Color.Empty;
            txtNumber.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = Color.Silver;
            stateProperties4.FillColor = Color.White;
            stateProperties4.ForeColor = Color.Empty;
            stateProperties4.PlaceholderForeColor = Color.Empty;
            txtNumber.OnIdleState = stateProperties4;
            txtNumber.Padding = new Padding(3);
            txtNumber.PasswordChar = '\0';
            txtNumber.PlaceholderForeColor = Color.Silver;
            txtNumber.PlaceholderText = "Enter text";
            txtNumber.ReadOnly = false;
            txtNumber.ScrollBars = ScrollBars.None;
            txtNumber.SelectedText = "";
            txtNumber.SelectionLength = 0;
            txtNumber.SelectionStart = 1;
            txtNumber.ShortcutsEnabled = true;
            txtNumber.Size = new Size(260, 39);
            txtNumber.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtNumber.TabIndex = 18;
            txtNumber.TextAlign = HorizontalAlignment.Left;
            txtNumber.TextMarginBottom = 0;
            txtNumber.TextMarginLeft = 3;
            txtNumber.TextMarginTop = 1;
            txtNumber.TextPlaceholder = "Enter text";
            txtNumber.UseSystemPasswordChar = false;
            txtNumber.WordWrap = true;
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
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCheck;
        private Bunifu.UI.WinForms.BunifuTextBox txtNumber;
    }
}