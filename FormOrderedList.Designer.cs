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
            label1 = new Label();
            lbxSortedWords = new ListBox();
            txtWords = new TextBox();
            lblWords = new Label();
            lblResult = new Label();
            btnSortList = new Bunifu.Framework.UI.BunifuFlatButton();
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
            label1.Size = new Size(800, 58);
            label1.TabIndex = 1;
            label1.Text = "Lista Ordenada";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxSortedWords
            // 
            lbxSortedWords.Font = new Font("Inter", 9F);
            lbxSortedWords.FormattingEnabled = true;
            lbxSortedWords.ItemHeight = 15;
            lbxSortedWords.Location = new Point(237, 212);
            lbxSortedWords.Name = "lbxSortedWords";
            lbxSortedWords.Size = new Size(350, 169);
            lbxSortedWords.TabIndex = 2;
            // 
            // txtWords
            // 
            txtWords.Font = new Font("Inter", 9F);
            txtWords.Location = new Point(237, 93);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(350, 22);
            txtWords.TabIndex = 3;
            txtWords.Text = "Exemplo, Melância, Zebra, Abacaxi, Batata";
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Font = new Font("Inter", 9F);
            lblWords.Location = new Point(237, 75);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(284, 15);
            lblWords.TabIndex = 4;
            lblWords.Text = "Digite algumas palavras separadas por vírgula ( , )";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Inter", 9F, FontStyle.Bold);
            lblResult.Location = new Point(237, 194);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(70, 15);
            lblResult.TabIndex = 6;
            lblResult.Text = "Resultado:";
            // 
            // btnSortList
            // 
            btnSortList.Active = false;
            btnSortList.Activecolor = Color.FromArgb(46, 44, 50);
            btnSortList.BackColor = Color.FromArgb(24, 22, 27);
            btnSortList.BackgroundImageLayout = ImageLayout.Stretch;
            btnSortList.BorderRadius = 5;
            btnSortList.ButtonText = "  Organizar";
            btnSortList.DisabledColor = Color.Gray;
            btnSortList.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortList.Iconcolor = Color.Transparent;
            btnSortList.Iconimage = null;
            btnSortList.Iconimage_right = null;
            btnSortList.Iconimage_right_Selected = null;
            btnSortList.Iconimage_Selected = null;
            btnSortList.IconMarginLeft = 0;
            btnSortList.IconMarginRight = 16;
            btnSortList.IconRightVisible = false;
            btnSortList.IconRightZoom = 0D;
            btnSortList.IconVisible = true;
            btnSortList.IconZoom = 38D;
            btnSortList.IsTab = false;
            btnSortList.Location = new Point(237, 121);
            btnSortList.Margin = new Padding(0, 0, 0, 8);
            btnSortList.Name = "btnSortList";
            btnSortList.Normalcolor = Color.FromArgb(24, 22, 27);
            btnSortList.OnHovercolor = Color.FromArgb(46, 44, 50);
            btnSortList.OnHoverTextColor = Color.White;
            btnSortList.selected = false;
            btnSortList.Size = new Size(105, 33);
            btnSortList.TabIndex = 7;
            btnSortList.Text = "  Organizar";
            btnSortList.TextAlign = ContentAlignment.MiddleCenter;
            btnSortList.Textcolor = Color.White;
            btnSortList.TextFont = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSortList.Click += btnSortList_Click;
            // 
            // FormOrderedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSortList);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnSortList;
    }
}