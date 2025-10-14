namespace HARAS_3D87
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem = new ToolStripMenuItem();
            raçasToolStripMenuItem = new ToolStripMenuItem();
            animaisToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(824, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { raçasToolStripMenuItem, animaisToolStripMenuItem });
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(66, 20);
            toolStripMenuItem.Text = "Arquivos";
            // 
            // raçasToolStripMenuItem
            // 
            raçasToolStripMenuItem.Name = "raçasToolStripMenuItem";
            raçasToolStripMenuItem.Size = new Size(180, 22);
            raçasToolStripMenuItem.Text = "Raças";
            raçasToolStripMenuItem.Click += RACAToolStripMenuItem_Click;
            // 
            // animaisToolStripMenuItem
            // 
            animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            animaisToolStripMenuItem.Size = new Size(180, 22);
            animaisToolStripMenuItem.Text = "Animais";
            animaisToolStripMenuItem.Click += ANIMAISToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(824, 525);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Frm_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App HARAS v.1.0";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem raçasToolStripMenuItem;
        private ToolStripMenuItem animaisToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}