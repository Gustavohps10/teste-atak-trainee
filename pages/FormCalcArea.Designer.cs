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
            label1 = new Label();
            lblWidth = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            lblHeight = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            btnCalculate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
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
            // txtWidth
            // 
            txtWidth.Font = new Font("Segoe UI", 14.25F);
            txtWidth.Location = new Point(263, 134);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(161, 33);
            txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 14.25F);
            txtHeight.Location = new Point(440, 134);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(161, 33);
            txtHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 14.25F);
            lblHeight.Location = new Point(440, 108);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(105, 25);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Altura (cm)";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(440, 252);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(161, 33);
            txtArea.TabIndex = 7;
            txtArea.Text = "0";
            txtArea.TextAlign = HorizontalAlignment.Right;
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
            btnCalculate.Location = new Point(263, 182);
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
            // FormCalcArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(874, 484);
            Controls.Add(btnCalculate);
            Controls.Add(txtArea);
            Controls.Add(lblArea);
            Controls.Add(txtHeight);
            Controls.Add(lblHeight);
            Controls.Add(txtWidth);
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
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Label lblHeight;
        private TextBox txtArea;
        private Label lblArea;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCalculate;
    }
}