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
            pnlMain = new Panel();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
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
            pcbLogo.Location = new Point(12, 9);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(139, 64);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(24, 22, 27);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 100);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(171, 405);
            pnlSidebar.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(171, 100);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(754, 405);
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
    }
}
