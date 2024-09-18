namespace sistemasdeacoes.View
{
    partial class telaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaHome));
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            porCódigoToolStripMenuItem = new ToolStripMenuItem();
            porNomeToolStripMenuItem = new ToolStripMenuItem();
            manipularToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, cadastrarToolStripMenuItem, pesquisarToolStripMenuItem, manipularToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Sair";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { porCódigoToolStripMenuItem, porNomeToolStripMenuItem });
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(69, 20);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += pesquisarToolStripMenuItem_Click;
            // 
            // porCódigoToolStripMenuItem
            // 
            porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            porCódigoToolStripMenuItem.Size = new Size(134, 22);
            porCódigoToolStripMenuItem.Text = "Por Código";
            porCódigoToolStripMenuItem.Click += porCódigoToolStripMenuItem_Click;
            // 
            // porNomeToolStripMenuItem
            // 
            porNomeToolStripMenuItem.Name = "porNomeToolStripMenuItem";
            porNomeToolStripMenuItem.Size = new Size(134, 22);
            porNomeToolStripMenuItem.Text = "Por Nome";
            porNomeToolStripMenuItem.Click += porNomeToolStripMenuItem_Click;
            // 
            // manipularToolStripMenuItem
            // 
            manipularToolStripMenuItem.Name = "manipularToolStripMenuItem";
            manipularToolStripMenuItem.Size = new Size(73, 20);
            manipularToolStripMenuItem.Text = "Manipular";
            manipularToolStripMenuItem.Click += manipularToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 411);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // telaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "telaHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ações";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem manipularToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem porCódigoToolStripMenuItem;
        private ToolStripMenuItem porNomeToolStripMenuItem;
    }
}