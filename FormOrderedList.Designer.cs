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
            btnSort = new Button();
            lblResult = new Label();
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
            lbxSortedWords.SelectedIndexChanged += lbxSortedWords_SelectedIndexChanged;
            // 
            // txtWords
            // 
            txtWords.Font = new Font("Inter", 9F);
            txtWords.Location = new Point(237, 93);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(350, 22);
            txtWords.TabIndex = 3;
            txtWords.Text = "Melância, Zebra, Abacaxi, Batata";
            // 
            // lblWords
            // 
            lblWords.AutoSize = true;
            lblWords.Font = new Font("Inter", 9F);
            lblWords.Location = new Point(237, 75);
            lblWords.Name = "lblWords";
            lblWords.Size = new Size(250, 15);
            lblWords.TabIndex = 4;
            lblWords.Text = "Digite as palavras separadas por vírgula ( , )";
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Inter", 9F);
            btnSort.Location = new Point(237, 121);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 5;
            btnSort.Text = "Organizar";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
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
            // FormOrderedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnSort);
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
        private Button btnSort;
        private Label lblResult;
    }
}