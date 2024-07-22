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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            label1 = new Label();
            lbxSortedWords = new ListBox();
            txtWords = new TextBox();
            lblWords = new Label();
            lblResult = new Label();
            btnSort = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            // txtWords
            // 
            txtWords.Font = new Font("Segoe UI", 9F);
            txtWords.Location = new Point(237, 93);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(350, 23);
            txtWords.TabIndex = 3;
            txtWords.Text = "Exemplo, Melância, Zebra, Abacaxi, Batata";
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            btnSort.CustomizableEdges = borderEdges1;
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
            btnSort.Location = new Point(237, 131);
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
            // FormOrderedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(lblResult);
            Controls.Add(lblWords);
            Controls.Add(txtWords);
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
        private TextBox txtWords;
        private Label lblWords;
        private Label lblResult;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnSort;
    }
}