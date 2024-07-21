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
            label1 = new Label();
            lblWidth = new Label();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            lblHeight = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            btnCalculate = new Bunifu.Framework.UI.BunifuFlatButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(251, 251, 251);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(8);
            label1.Size = new Size(874, 58);
            label1.TabIndex = 1;
            label1.Text = "Calcular Áreea";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWidth.Location = new Point(263, 108);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(127, 23);
            lblWidth.TabIndex = 2;
            lblWidth.Text = "Largura (cm)";
            // 
            // txtWidth
            // 
            txtWidth.Font = new Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtWidth.Location = new Point(263, 134);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(161, 30);
            txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(440, 134);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(161, 30);
            txtHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(440, 108);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(111, 23);
            lblHeight.TabIndex = 4;
            lblHeight.Text = "Altura (cm)";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(440, 252);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(161, 30);
            txtArea.TabIndex = 7;
            txtArea.Text = "0";
            txtArea.TextAlign = HorizontalAlignment.Right;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(494, 226);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(110, 23);
            lblArea.TabIndex = 6;
            lblArea.Text = "Área (cm²)";
            lblArea.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            btnCalculate.Active = false;
            btnCalculate.Activecolor = Color.FromArgb(46, 44, 50);
            btnCalculate.BackColor = Color.FromArgb(24, 22, 27);
            btnCalculate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalculate.BorderRadius = 5;
            btnCalculate.ButtonText = "Calcular";
            btnCalculate.DisabledColor = Color.Gray;
            btnCalculate.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Iconcolor = Color.Transparent;
            btnCalculate.Iconimage = null;
            btnCalculate.Iconimage_right = null;
            btnCalculate.Iconimage_right_Selected = null;
            btnCalculate.Iconimage_Selected = null;
            btnCalculate.IconMarginLeft = 0;
            btnCalculate.IconMarginRight = 16;
            btnCalculate.IconRightVisible = false;
            btnCalculate.IconRightZoom = 0D;
            btnCalculate.IconVisible = true;
            btnCalculate.IconZoom = 38D;
            btnCalculate.IsTab = false;
            btnCalculate.Location = new Point(263, 177);
            btnCalculate.Margin = new Padding(0, 0, 0, 8);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Normalcolor = Color.FromArgb(24, 22, 27);
            btnCalculate.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnCalculate.OnHoverTextColor = Color.White;
            btnCalculate.selected = false;
            btnCalculate.Size = new Size(105, 33);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calcular";
            btnCalculate.TextAlign = ContentAlignment.MiddleCenter;
            btnCalculate.Textcolor = Color.White;
            btnCalculate.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnCalculate;
    }
}