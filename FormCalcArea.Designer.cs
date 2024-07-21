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
            btnCalcArea = new Button();
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
            txtArea.Location = new Point(440, 273);
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
            lblArea.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(494, 247);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(107, 23);
            lblArea.TabIndex = 6;
            lblArea.Text = "Área (cm²)";
            // 
            // btnCalcArea
            // 
            btnCalcArea.Cursor = Cursors.Hand;
            btnCalcArea.Font = new Font("Inter", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcArea.Location = new Point(263, 179);
            btnCalcArea.Name = "btnCalcArea";
            btnCalcArea.Size = new Size(106, 30);
            btnCalcArea.TabIndex = 8;
            btnCalcArea.Text = "Calcular";
            btnCalcArea.UseVisualStyleBackColor = true;
            btnCalcArea.Click += btnCalcArea_Click;
            // 
            // FormCalcArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(874, 484);
            Controls.Add(btnCalcArea);
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
        private Button btnCalcArea;
    }
}