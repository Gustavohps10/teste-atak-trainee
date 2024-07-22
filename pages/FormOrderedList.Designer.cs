namespace teste_atak
{
    partial class FormOrderedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderedList));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            label1 = new Label();
            lbxSortedWords = new ListBox();
            lblWords = new Label();
            lblResult = new Label();
            btnSort = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            txtWords = new Bunifu.UI.WinForms.BunifuTextBox();
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
            label1.TabIndex = 1;
            label1.Text = "Lista Ordenada";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxSortedWords
            // 
            lbxSortedWords.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxSortedWords.FormattingEnabled = true;
            lbxSortedWords.ItemHeight = 15;
            lbxSortedWords.Location = new Point(237, 212);
            lbxSortedWords.Name = "lbxSortedWords";
            lbxSortedWords.Size = new Size(350, 169);
            lbxSortedWords.TabIndex = 2;
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Font = new Font("Segoe UI", 9F);
            lblWords.Location = new Point(237, 75);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(267, 15);
            lblWords.TabIndex = 4;
            lblWords.Text = "Digite algumas palavras separadas por vírgula ( , )";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(237, 194);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(65, 15);
            lblResult.TabIndex = 6;
            lblResult.Text = "Resultado:";
            // 
            // btnSort
            // 
            btnSort.AllowAnimations = true;
            btnSort.AllowMouseEffects = true;
            btnSort.AllowToggling = false;
            btnSort.AnimationSpeed = 25;
            btnSort.AutoGenerateColors = false;
            btnSort.AutoRoundBorders = false;
            btnSort.AutoSizeLeftIcon = true;
            btnSort.AutoSizeRightIcon = true;
            btnSort.BackColor = Color.Transparent;
            btnSort.BackColor1 = Color.FromArgb(24, 22, 27);
            btnSort.BackgroundImage = (Image)resources.GetObject("btnSort.BackgroundImage");
            btnSort.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSort.ButtonText = "Organizar";
            btnSort.ButtonTextMarginLeft = 0;
            btnSort.ColorContrastOnClick = 45;
            btnSort.ColorContrastOnHover = 45;
            btnSort.Cursor = Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            btnSort.CustomizableEdges = borderEdges2;
            btnSort.DialogResult = DialogResult.None;
            btnSort.DisabledBorderColor = Color.Transparent;
            btnSort.DisabledFillColor = Color.FromArgb(204, 204, 204);
            btnSort.DisabledForecolor = Color.FromArgb(168, 160, 168);
            btnSort.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSort.ForeColor = Color.White;
            btnSort.IconLeftAlign = ContentAlignment.MiddleLeft;
            btnSort.IconLeftCursor = Cursors.Default;
            btnSort.IconLeftPadding = new Padding(11, 3, 3, 3);
            btnSort.IconMarginLeft = 11;
            btnSort.IconPadding = 10;
            btnSort.IconRightAlign = ContentAlignment.MiddleRight;
            btnSort.IconRightCursor = Cursors.Default;
            btnSort.IconRightPadding = new Padding(3, 3, 7, 3);
            btnSort.IconSize = 25;
            btnSort.IdleBorderColor = Color.Transparent;
            btnSort.IdleBorderRadius = 8;
            btnSort.IdleBorderThickness = 1;
            btnSort.IdleFillColor = Color.FromArgb(24, 22, 27);
            btnSort.IdleIconLeftImage = null;
            btnSort.IdleIconRightImage = null;
            btnSort.IndicateFocus = false;
            btnSort.Location = new Point(237, 138);
            btnSort.Name = "btnSort";
            btnSort.OnDisabledState.BorderColor = Color.Transparent;
            btnSort.OnDisabledState.BorderRadius = 8;
            btnSort.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSort.OnDisabledState.BorderThickness = 1;
            btnSort.OnDisabledState.FillColor = Color.FromArgb(204, 204, 204);
            btnSort.OnDisabledState.ForeColor = Color.FromArgb(168, 160, 168);
            btnSort.OnDisabledState.IconLeftImage = null;
            btnSort.OnDisabledState.IconRightImage = null;
            btnSort.onHoverState.BorderColor = Color.Transparent;
            btnSort.onHoverState.BorderRadius = 8;
            btnSort.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSort.onHoverState.BorderThickness = 1;
            btnSort.onHoverState.FillColor = Color.FromArgb(46, 43, 52);
            btnSort.onHoverState.ForeColor = Color.White;
            btnSort.onHoverState.IconLeftImage = null;
            btnSort.onHoverState.IconRightImage = null;
            btnSort.OnIdleState.BorderColor = Color.Transparent;
            btnSort.OnIdleState.BorderRadius = 8;
            btnSort.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSort.OnIdleState.BorderThickness = 1;
            btnSort.OnIdleState.FillColor = Color.FromArgb(24, 22, 27);
            btnSort.OnIdleState.ForeColor = Color.White;
            btnSort.OnIdleState.IconLeftImage = null;
            btnSort.OnIdleState.IconRightImage = null;
            btnSort.OnPressedState.BorderColor = Color.Transparent;
            btnSort.OnPressedState.BorderRadius = 8;
            btnSort.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            btnSort.OnPressedState.BorderThickness = 1;
            btnSort.OnPressedState.FillColor = Color.FromArgb(46, 43, 52);
            btnSort.OnPressedState.ForeColor = Color.White;
            btnSort.OnPressedState.IconLeftImage = null;
            btnSort.OnPressedState.IconRightImage = null;
            btnSort.Size = new Size(114, 36);
            btnSort.TabIndex = 18;
            btnSort.TextAlign = ContentAlignment.MiddleCenter;
            btnSort.TextAlignment = HorizontalAlignment.Center;
            btnSort.TextMarginLeft = 0;
            btnSort.TextPadding = new Padding(0);
            btnSort.UseDefaultRadiusAndThickness = true;
            btnSort.Click += btnSortList_Click;
            // 
            // txtWords
            // 
            txtWords.AcceptsReturn = false;
            txtWords.AcceptsTab = false;
            txtWords.AnimationSpeed = 200;
            txtWords.AutoCompleteMode = AutoCompleteMode.None;
            txtWords.AutoCompleteSource = AutoCompleteSource.None;
            txtWords.AutoSizeHeight = true;
            txtWords.BackColor = Color.Transparent;
            txtWords.BackgroundImage = (Image)resources.GetObject("txtWords.BackgroundImage");
            txtWords.BorderColorActive = Color.DodgerBlue;
            txtWords.BorderColorDisabled = Color.FromArgb(204, 204, 204);
            txtWords.BorderColorHover = Color.FromArgb(105, 181, 255);
            txtWords.BorderColorIdle = Color.Silver;
            txtWords.BorderRadius = 1;
            txtWords.BorderThickness = 1;
            txtWords.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            txtWords.CharacterCasing = CharacterCasing.Normal;
            txtWords.DefaultFont = new Font("Segoe UI", 9.25F);
            txtWords.DefaultText = "Exemplo, Melância, Zebra, Abacaxi, Batata";
            txtWords.FillColor = Color.White;
            txtWords.HideSelection = true;
            txtWords.IconLeft = null;
            txtWords.IconLeftCursor = Cursors.IBeam;
            txtWords.IconPadding = 10;
            txtWords.IconRight = null;
            txtWords.IconRightCursor = Cursors.IBeam;
            txtWords.Lines = new string[]
    {
    "Exemplo, Melância, Zebra, Abacaxi, Batata"
    };
            txtWords.Location = new Point(237, 93);
            txtWords.MaxLength = 32767;
            txtWords.MinimumSize = new Size(1, 1);
            txtWords.Modified = false;
            txtWords.Multiline = false;
            txtWords.Name = "txtWords";
            stateProperties5.BorderColor = Color.DodgerBlue;
            stateProperties5.FillColor = Color.Empty;
            stateProperties5.ForeColor = Color.Empty;
            stateProperties5.PlaceholderForeColor = Color.Empty;
            txtWords.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = Color.FromArgb(204, 204, 204);
            stateProperties6.FillColor = Color.FromArgb(240, 240, 240);
            stateProperties6.ForeColor = Color.FromArgb(109, 109, 109);
            stateProperties6.PlaceholderForeColor = Color.DarkGray;
            txtWords.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = Color.FromArgb(105, 181, 255);
            stateProperties7.FillColor = Color.Empty;
            stateProperties7.ForeColor = Color.Empty;
            stateProperties7.PlaceholderForeColor = Color.Empty;
            txtWords.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = Color.Silver;
            stateProperties8.FillColor = Color.White;
            stateProperties8.ForeColor = Color.Empty;
            stateProperties8.PlaceholderForeColor = Color.Empty;
            txtWords.OnIdleState = stateProperties8;
            txtWords.Padding = new Padding(3);
            txtWords.PasswordChar = '\0';
            txtWords.PlaceholderForeColor = Color.Silver;
            txtWords.PlaceholderText = "Enter text";
            txtWords.ReadOnly = false;
            txtWords.ScrollBars = ScrollBars.None;
            txtWords.SelectedText = "";
            txtWords.SelectionLength = 0;
            txtWords.SelectionStart = 41;
            txtWords.ShortcutsEnabled = true;
            txtWords.Size = new Size(350, 39);
            txtWords.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            txtWords.TabIndex = 19;
            txtWords.TextAlign = HorizontalAlignment.Left;
            txtWords.TextMarginBottom = 0;
            txtWords.TextMarginLeft = 3;
            txtWords.TextMarginTop = 1;
            txtWords.TextPlaceholder = "Enter text";
            txtWords.UseSystemPasswordChar = false;
            txtWords.WordWrap = true;
            // 
            // FormOrderedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(txtWords);
            Controls.Add(btnSort);
            Controls.Add(lblResult);
            Controls.Add(lblWords);
            Controls.Add(lbxSortedWords);
            Controls.Add(label1);
            Name = "FormOrderedList";
            Text = "Lista Ordenada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxSortedWords;
        private Label lblWords;
        private Label lblResult;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSort;
        private Bunifu.UI.WinForms.BunifuTextBox txtWords;
    }
}