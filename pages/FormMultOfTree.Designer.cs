namespace teste_atak
{
    partial class FormMultOfTree
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
            lbxFor = new ListBox();
            lblFor = new Label();
            lblWhile = new Label();
            lbxWhile = new ListBox();
            lblDoWhile = new Label();
            lbxDoWhile = new ListBox();
            btnListNumbers = new Bunifu.Framework.UI.BunifuFlatButton();
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
            label1.Text = "Múltiplos de 3";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxFor
            // 
            lbxFor.Font = new Font("Segoe UI", 9F);
            lbxFor.FormattingEnabled = true;
            lbxFor.ItemHeight = 15;
            lbxFor.Location = new Point(135, 163);
            lbxFor.Name = "lbxFor";
            lbxFor.Size = new Size(156, 259);
            lbxFor.TabIndex = 2;
            // 
            // lblFor
            // 
            lblFor.AutoSize = true;
            lblFor.Font = new Font("Segoe UI", 9F);
            lblFor.Location = new Point(135, 145);
            lblFor.Name = "lblFor";
            lblFor.Size = new Size(24, 15);
            lblFor.TabIndex = 3;
            lblFor.Text = "For";
            // 
            // lblWhile
            // 
            lblWhile.AutoSize = true;
            lblWhile.Font = new Font("Segoe UI", 9F);
            lblWhile.Location = new Point(319, 145);
            lblWhile.Name = "lblWhile";
            lblWhile.Size = new Size(37, 15);
            lblWhile.TabIndex = 5;
            lblWhile.Text = "While";
            // 
            // lbxWhile
            // 
            lbxWhile.Font = new Font("Segoe UI", 9F);
            lbxWhile.FormattingEnabled = true;
            lbxWhile.ItemHeight = 15;
            lbxWhile.Location = new Point(319, 163);
            lbxWhile.Name = "lbxWhile";
            lbxWhile.Size = new Size(156, 259);
            lbxWhile.TabIndex = 4;
            // 
            // lblDoWhile
            // 
            lblDoWhile.AutoSize = true;
            lblDoWhile.Font = new Font("Segoe UI", 9F);
            lblDoWhile.Location = new Point(500, 145);
            lblDoWhile.Name = "lblDoWhile";
            lblDoWhile.Size = new Size(55, 15);
            lblDoWhile.TabIndex = 7;
            lblDoWhile.Text = "Do While";
            // 
            // lbxDoWhile
            // 
            lbxDoWhile.Font = new Font("Segoe UI", 9F);
            lbxDoWhile.FormattingEnabled = true;
            lbxDoWhile.ItemHeight = 15;
            lbxDoWhile.Location = new Point(500, 163);
            lbxDoWhile.Name = "lbxDoWhile";
            lbxDoWhile.Size = new Size(156, 259);
            lbxDoWhile.TabIndex = 6;
            // 
            // btnListNumbers
            // 
            btnListNumbers.Active = false;
            btnListNumbers.Activecolor = Color.FromArgb(46, 44, 50);
            btnListNumbers.BackColor = Color.FromArgb(24, 22, 27);
            btnListNumbers.BackgroundImageLayout = ImageLayout.Stretch;
            btnListNumbers.BorderRadius = 5;
            btnListNumbers.ButtonText = "Listar";
            btnListNumbers.DisabledColor = Color.Gray;
            btnListNumbers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListNumbers.Iconcolor = Color.Transparent;
            btnListNumbers.Iconimage = null;
            btnListNumbers.Iconimage_right = null;
            btnListNumbers.Iconimage_right_Selected = null;
            btnListNumbers.Iconimage_Selected = null;
            btnListNumbers.IconMarginLeft = 0;
            btnListNumbers.IconMarginRight = 16;
            btnListNumbers.IconRightVisible = false;
            btnListNumbers.IconRightZoom = 0D;
            btnListNumbers.IconVisible = true;
            btnListNumbers.IconZoom = 38D;
            btnListNumbers.IsTab = false;
            btnListNumbers.Location = new Point(346, 72);
            btnListNumbers.Margin = new Padding(0, 0, 0, 8);
            btnListNumbers.Name = "btnListNumbers";
            btnListNumbers.Normalcolor = Color.FromArgb(24, 22, 27);
            btnListNumbers.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnListNumbers.OnHoverTextColor = Color.White;
            btnListNumbers.selected = false;
            btnListNumbers.Size = new Size(105, 33);
            btnListNumbers.TabIndex = 10;
            btnListNumbers.Text = "Listar";
            btnListNumbers.TextAlign = ContentAlignment.MiddleCenter;
            btnListNumbers.Textcolor = Color.White;
            btnListNumbers.TextFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnListNumbers.Click += btnListNumbers_Click;
            // 
            // FormMultOfTree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(btnListNumbers);
            Controls.Add(lblDoWhile);
            Controls.Add(lbxDoWhile);
            Controls.Add(lblWhile);
            Controls.Add(lbxWhile);
            Controls.Add(lblFor);
            Controls.Add(lbxFor);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMultOfTree";
            Text = "FormMultOfTree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxFor;
        private Label lblFor;
        private Label lblWhile;
        private ListBox lbxWhile;
        private Label lblDoWhile;
        private ListBox lbxDoWhile;
        private Bunifu.Framework.UI.BunifuFlatButton btnListNumbers;
    }
}