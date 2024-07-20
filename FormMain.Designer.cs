namespace teste_atak
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            pcbUserIcon = new PictureBox();
            pcbLogo = new PictureBox();
            pnlSidebar = new Panel();
            pnlMenuClass = new Panel();
            pcbMenuClass = new PictureBox();
            lblMenuClass = new Label();
            pnlMenuMultiplesOf3 = new Panel();
            pcbMenuMultipleOf3 = new PictureBox();
            lblMenuMultipleOf3 = new Label();
            pnlMenuRetangle = new Panel();
            pcbMenuRetangle = new PictureBox();
            lblMenuRetangle = new Label();
            pnlMenuList = new Panel();
            pcbMenuList = new PictureBox();
            lblMenuList = new Label();
            pnlMenuEvenOdd = new Panel();
            pcbMenuEvenOdd = new PictureBox();
            lblMenuEvenOdd = new Label();
            pnlMain = new Panel();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            pnlMenuClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuClass).BeginInit();
            pnlMenuMultiplesOf3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuMultipleOf3).BeginInit();
            pnlMenuRetangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuRetangle).BeginInit();
            pnlMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuList).BeginInit();
            pnlMenuEvenOdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuEvenOdd).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pcbUserIcon);
            pnlHeader.Controls.Add(pcbLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(8, 0, 8, 0);
            pnlHeader.Size = new Size(925, 76);
            pnlHeader.TabIndex = 0;
            // 
            // pcbUserIcon
            // 
            pcbUserIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pcbUserIcon.Image = Properties.Resources.circle_user_round;
            pcbUserIcon.Location = new Point(878, 21);
            pcbUserIcon.Name = "pcbUserIcon";
            pcbUserIcon.Size = new Size(36, 36);
            pcbUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUserIcon.TabIndex = 1;
            pcbUserIcon.TabStop = false;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.atak_logo;
            pcbLogo.Location = new Point(12, 20);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(139, 34);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(24, 22, 27);
            pnlSidebar.Controls.Add(pnlMenuClass);
            pnlSidebar.Controls.Add(pnlMenuMultiplesOf3);
            pnlSidebar.Controls.Add(pnlMenuRetangle);
            pnlSidebar.Controls.Add(pnlMenuList);
            pnlSidebar.Controls.Add(pnlMenuEvenOdd);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 100);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(16);
            pnlSidebar.Size = new Size(190, 405);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlMenuClass
            // 
            pnlMenuClass.BackColor = Color.FromArgb(24, 22, 27);
            pnlMenuClass.Controls.Add(pcbMenuClass);
            pnlMenuClass.Controls.Add(lblMenuClass);
            pnlMenuClass.Cursor = Cursors.Hand;
            pnlMenuClass.Location = new Point(16, 192);
            pnlMenuClass.Margin = new Padding(0, 0, 0, 4);
            pnlMenuClass.Name = "pnlMenuClass";
            pnlMenuClass.Padding = new Padding(8, 4, 8, 4);
            pnlMenuClass.Size = new Size(158, 36);
            pnlMenuClass.TabIndex = 4;
            pnlMenuClass.MouseEnter += pnlMenuClass_MouseEnter;
            pnlMenuClass.MouseLeave += pnlMenuClass_MouseLeave;
            // 
            // pcbMenuClass
            // 
            pcbMenuClass.Enabled = false;
            pcbMenuClass.Image = Properties.Resources.user;
            pcbMenuClass.Location = new Point(7, 7);
            pcbMenuClass.Name = "pcbMenuClass";
            pcbMenuClass.Size = new Size(24, 24);
            pcbMenuClass.TabIndex = 1;
            pcbMenuClass.TabStop = false;
            // 
            // lblMenuClass
            // 
            lblMenuClass.AutoSize = true;
            lblMenuClass.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuClass.ForeColor = Color.White;
            lblMenuClass.Location = new Point(41, 11);
            lblMenuClass.Name = "lblMenuClass";
            lblMenuClass.Size = new Size(93, 15);
            lblMenuClass.TabIndex = 0;
            lblMenuClass.Text = "Classe Pessoa";
            // 
            // pnlMenuMultiplesOf3
            // 
            pnlMenuMultiplesOf3.BackColor = Color.FromArgb(46, 44, 50);
            pnlMenuMultiplesOf3.Controls.Add(pcbMenuMultipleOf3);
            pnlMenuMultiplesOf3.Controls.Add(lblMenuMultipleOf3);
            pnlMenuMultiplesOf3.Cursor = Cursors.Hand;
            pnlMenuMultiplesOf3.Location = new Point(16, 148);
            pnlMenuMultiplesOf3.Margin = new Padding(0, 0, 0, 4);
            pnlMenuMultiplesOf3.Name = "pnlMenuMultiplesOf3";
            pnlMenuMultiplesOf3.Padding = new Padding(8, 4, 8, 4);
            pnlMenuMultiplesOf3.Size = new Size(158, 36);
            pnlMenuMultiplesOf3.TabIndex = 3;
            // 
            // pcbMenuMultipleOf3
            // 
            pcbMenuMultipleOf3.Image = Properties.Resources.repeat;
            pcbMenuMultipleOf3.Location = new Point(7, 7);
            pcbMenuMultipleOf3.Name = "pcbMenuMultipleOf3";
            pcbMenuMultipleOf3.Size = new Size(24, 24);
            pcbMenuMultipleOf3.TabIndex = 1;
            pcbMenuMultipleOf3.TabStop = false;
            // 
            // lblMenuMultipleOf3
            // 
            lblMenuMultipleOf3.AutoSize = true;
            lblMenuMultipleOf3.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuMultipleOf3.ForeColor = Color.White;
            lblMenuMultipleOf3.Location = new Point(41, 11);
            lblMenuMultipleOf3.Name = "lblMenuMultipleOf3";
            lblMenuMultipleOf3.Size = new Size(90, 15);
            lblMenuMultipleOf3.TabIndex = 0;
            lblMenuMultipleOf3.Text = "Múltiplos de 3";
            // 
            // pnlMenuRetangle
            // 
            pnlMenuRetangle.BackColor = Color.FromArgb(46, 44, 50);
            pnlMenuRetangle.Controls.Add(pcbMenuRetangle);
            pnlMenuRetangle.Controls.Add(lblMenuRetangle);
            pnlMenuRetangle.Cursor = Cursors.Hand;
            pnlMenuRetangle.Location = new Point(16, 104);
            pnlMenuRetangle.Margin = new Padding(0, 0, 0, 4);
            pnlMenuRetangle.Name = "pnlMenuRetangle";
            pnlMenuRetangle.Padding = new Padding(8, 4, 8, 4);
            pnlMenuRetangle.Size = new Size(158, 36);
            pnlMenuRetangle.TabIndex = 2;
            // 
            // pcbMenuRetangle
            // 
            pcbMenuRetangle.Image = Properties.Resources.square_dashed_bottom;
            pcbMenuRetangle.Location = new Point(7, 7);
            pcbMenuRetangle.Name = "pcbMenuRetangle";
            pcbMenuRetangle.Size = new Size(24, 24);
            pcbMenuRetangle.TabIndex = 1;
            pcbMenuRetangle.TabStop = false;
            // 
            // lblMenuRetangle
            // 
            lblMenuRetangle.AutoSize = true;
            lblMenuRetangle.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuRetangle.ForeColor = Color.White;
            lblMenuRetangle.Location = new Point(41, 11);
            lblMenuRetangle.Name = "lblMenuRetangle";
            lblMenuRetangle.Size = new Size(86, 15);
            lblMenuRetangle.TabIndex = 0;
            lblMenuRetangle.Text = "Calcular Área";
            // 
            // pnlMenuList
            // 
            pnlMenuList.BackColor = Color.FromArgb(46, 44, 50);
            pnlMenuList.Controls.Add(pcbMenuList);
            pnlMenuList.Controls.Add(lblMenuList);
            pnlMenuList.Cursor = Cursors.Hand;
            pnlMenuList.Location = new Point(16, 60);
            pnlMenuList.Margin = new Padding(0, 0, 0, 4);
            pnlMenuList.Name = "pnlMenuList";
            pnlMenuList.Padding = new Padding(8, 4, 8, 4);
            pnlMenuList.Size = new Size(158, 36);
            pnlMenuList.TabIndex = 1;
            // 
            // pcbMenuList
            // 
            pcbMenuList.Image = Properties.Resources.list;
            pcbMenuList.Location = new Point(7, 7);
            pcbMenuList.Name = "pcbMenuList";
            pcbMenuList.Size = new Size(24, 24);
            pcbMenuList.TabIndex = 1;
            pcbMenuList.TabStop = false;
            // 
            // lblMenuList
            // 
            lblMenuList.AutoSize = true;
            lblMenuList.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuList.ForeColor = Color.White;
            lblMenuList.Location = new Point(41, 11);
            lblMenuList.Name = "lblMenuList";
            lblMenuList.Size = new Size(97, 15);
            lblMenuList.TabIndex = 0;
            lblMenuList.Text = "Lista Ordenada";
            // 
            // pnlMenuEvenOdd
            // 
            pnlMenuEvenOdd.BackColor = Color.FromArgb(46, 44, 50);
            pnlMenuEvenOdd.Controls.Add(pcbMenuEvenOdd);
            pnlMenuEvenOdd.Controls.Add(lblMenuEvenOdd);
            pnlMenuEvenOdd.Cursor = Cursors.Hand;
            pnlMenuEvenOdd.Location = new Point(16, 16);
            pnlMenuEvenOdd.Margin = new Padding(0);
            pnlMenuEvenOdd.Name = "pnlMenuEvenOdd";
            pnlMenuEvenOdd.Padding = new Padding(8, 4, 8, 4);
            pnlMenuEvenOdd.Size = new Size(158, 36);
            pnlMenuEvenOdd.TabIndex = 0;
            // 
            // pcbMenuEvenOdd
            // 
            pcbMenuEvenOdd.Image = Properties.Resources.file_digit;
            pcbMenuEvenOdd.Location = new Point(7, 7);
            pcbMenuEvenOdd.Name = "pcbMenuEvenOdd";
            pcbMenuEvenOdd.Size = new Size(24, 24);
            pcbMenuEvenOdd.TabIndex = 1;
            pcbMenuEvenOdd.TabStop = false;
            // 
            // lblMenuEvenOdd
            // 
            lblMenuEvenOdd.AutoSize = true;
            lblMenuEvenOdd.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuEvenOdd.ForeColor = Color.White;
            lblMenuEvenOdd.Location = new Point(41, 11);
            lblMenuEvenOdd.Name = "lblMenuEvenOdd";
            lblMenuEvenOdd.Size = new Size(81, 15);
            lblMenuEvenOdd.TabIndex = 0;
            lblMenuEvenOdd.Text = "Par ou Ímpar";
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(190, 100);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(735, 405);
            pnlMain.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(925, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Image = Properties.Resources.about;
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(68, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 251, 251);
            ClientSize = new Size(925, 505);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(menuStrip1);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teste - Atak Sistemas";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbUserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            pnlMenuClass.ResumeLayout(false);
            pnlMenuClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuClass).EndInit();
            pnlMenuMultiplesOf3.ResumeLayout(false);
            pnlMenuMultiplesOf3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuMultipleOf3).EndInit();
            pnlMenuRetangle.ResumeLayout(false);
            pnlMenuRetangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuRetangle).EndInit();
            pnlMenuList.ResumeLayout(false);
            pnlMenuList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuList).EndInit();
            pnlMenuEvenOdd.ResumeLayout(false);
            pnlMenuEvenOdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbMenuEvenOdd).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Panel pnlMain;
        private PictureBox pcbLogo;
        private PictureBox pcbUserIcon;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlMenuEvenOdd;
        private PictureBox pcbMenuEvenOdd;
        private Label lblMenuEvenOdd;
        private Panel pnlMenuList;
        private PictureBox pcbMenuList;
        private Label lblMenuList;
        private Panel pnlMenuRetangle;
        private PictureBox pcbMenuRetangle;
        private Label lblMenuRetangle;
        private Panel pnlMenuClass;
        private PictureBox pcbMenuClass;
        private Label lblMenuClass;
        private Panel pnlMenuMultiplesOf3;
        private PictureBox pcbMenuMultipleOf3;
        private Label lblMenuMultipleOf3;
    }
}
