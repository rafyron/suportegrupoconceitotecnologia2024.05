namespace Concept_Conceito_Emp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.áreaDoSuporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nossoSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosDaConceitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceitoERPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceitoFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificadoDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.energiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceitoLabSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 328);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(8, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 281);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áreaDoSuporteToolStripMenuItem,
            this.nossoSiteToolStripMenuItem,
            this.serviçosDaConceitoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(373, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // áreaDoSuporteToolStripMenuItem
            // 
            this.áreaDoSuporteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.áreaDoSuporteToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.áreaDoSuporteToolStripMenuItem.Name = "áreaDoSuporteToolStripMenuItem";
            this.áreaDoSuporteToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.áreaDoSuporteToolStripMenuItem.Text = "Área do Suporte";
            this.áreaDoSuporteToolStripMenuItem.Click += new System.EventHandler(this.áreaDoSuporteToolStripMenuItem_Click);
            // 
            // nossoSiteToolStripMenuItem
            // 
            this.nossoSiteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.nossoSiteToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.nossoSiteToolStripMenuItem.Name = "nossoSiteToolStripMenuItem";
            this.nossoSiteToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nossoSiteToolStripMenuItem.Text = "Nosso Site";
            this.nossoSiteToolStripMenuItem.Click += new System.EventHandler(this.nossoSiteToolStripMenuItem_Click);
            // 
            // serviçosDaConceitoToolStripMenuItem
            // 
            this.serviçosDaConceitoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.serviçosDaConceitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceitoERPToolStripMenuItem,
            this.conceitoFoodToolStripMenuItem,
            this.certificadoDigitalToolStripMenuItem,
            this.energiToolStripMenuItem,
            this.conceitoLabSchoolToolStripMenuItem});
            this.serviçosDaConceitoToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.serviçosDaConceitoToolStripMenuItem.Name = "serviçosDaConceitoToolStripMenuItem";
            this.serviçosDaConceitoToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.serviçosDaConceitoToolStripMenuItem.Text = "Serviços da Conceito";
            this.serviçosDaConceitoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.serviçosDaConceitoToolStripMenuItem.ToolTipText = "Serviços da Conceito";
            this.serviçosDaConceitoToolStripMenuItem.Click += new System.EventHandler(this.serviçosDaConceitoToolStripMenuItem_Click);
            // 
            // conceitoERPToolStripMenuItem
            // 
            this.conceitoERPToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.conceitoERPToolStripMenuItem.Name = "conceitoERPToolStripMenuItem";
            this.conceitoERPToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.conceitoERPToolStripMenuItem.Text = "Conceito ERP";
            this.conceitoERPToolStripMenuItem.Click += new System.EventHandler(this.conceitoERPToolStripMenuItem_Click);
            // 
            // conceitoFoodToolStripMenuItem
            // 
            this.conceitoFoodToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.conceitoFoodToolStripMenuItem.Name = "conceitoFoodToolStripMenuItem";
            this.conceitoFoodToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.conceitoFoodToolStripMenuItem.Text = "Conceito Food";
            this.conceitoFoodToolStripMenuItem.Click += new System.EventHandler(this.conceitoFoodToolStripMenuItem_Click);
            // 
            // certificadoDigitalToolStripMenuItem
            // 
            this.certificadoDigitalToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.certificadoDigitalToolStripMenuItem.Name = "certificadoDigitalToolStripMenuItem";
            this.certificadoDigitalToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.certificadoDigitalToolStripMenuItem.Text = "Certificado Digital";
            this.certificadoDigitalToolStripMenuItem.Click += new System.EventHandler(this.certificadoDigitalToolStripMenuItem_Click);
            // 
            // energiToolStripMenuItem
            // 
            this.energiToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.energiToolStripMenuItem.Name = "energiToolStripMenuItem";
            this.energiToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.energiToolStripMenuItem.Text = "Energia Solar";
            this.energiToolStripMenuItem.Click += new System.EventHandler(this.energiToolStripMenuItem_Click);
            // 
            // conceitoLabSchoolToolStripMenuItem
            // 
            this.conceitoLabSchoolToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.conceitoLabSchoolToolStripMenuItem.Name = "conceitoLabSchoolToolStripMenuItem";
            this.conceitoLabSchoolToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.conceitoLabSchoolToolStripMenuItem.Text = "Conceito LabSchool";
            this.conceitoLabSchoolToolStripMenuItem.Click += new System.EventHandler(this.conceitoLabSchoolToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.ajudaToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSistemaToolStripMenuItem,
            this.fecharOSistemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.ShowShortcutKeys = false;
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sobreOSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaToolStripMenuItem_Click);
            // 
            // fecharOSistemaToolStripMenuItem
            // 
            this.fecharOSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.fecharOSistemaToolStripMenuItem.Name = "fecharOSistemaToolStripMenuItem";
            this.fecharOSistemaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.fecharOSistemaToolStripMenuItem.Text = "Fechar o Sistema";
            this.fecharOSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharOSistemaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 341);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suporte - Grupo Conceito Tecnologia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaDoSuporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nossoSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosDaConceitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceitoERPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceitoFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificadoDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem energiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceitoLabSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharOSistemaToolStripMenuItem;
    }
}

