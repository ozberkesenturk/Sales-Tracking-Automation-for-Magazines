namespace DergimWinformUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATIŞLARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dERGİSAYILARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sATIŞLARToolStripMenuItem,
            this.dERGİSAYILARIToolStripMenuItem,
            this.mÜŞTERİLERToolStripMenuItem,
            this.pERSONELLERToolStripMenuItem});
            this.menüToolStripMenuItem.Font = new System.Drawing.Font("Led Italic Font", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menüToolStripMenuItem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // sATIŞLARToolStripMenuItem
            // 
            this.sATIŞLARToolStripMenuItem.Name = "sATIŞLARToolStripMenuItem";
            this.sATIŞLARToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.sATIŞLARToolStripMenuItem.Text = "Satışlar";
            this.sATIŞLARToolStripMenuItem.Click += new System.EventHandler(this.sATIŞLARToolStripMenuItem_Click);
            // 
            // dERGİSAYILARIToolStripMenuItem
            // 
            this.dERGİSAYILARIToolStripMenuItem.Name = "dERGİSAYILARIToolStripMenuItem";
            this.dERGİSAYILARIToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.dERGİSAYILARIToolStripMenuItem.Text = "Dergi Sayıları";
            this.dERGİSAYILARIToolStripMenuItem.Click += new System.EventHandler(this.dERGİSAYILARIToolStripMenuItem_Click);
            // 
            // mÜŞTERİLERToolStripMenuItem
            // 
            this.mÜŞTERİLERToolStripMenuItem.Name = "mÜŞTERİLERToolStripMenuItem";
            this.mÜŞTERİLERToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.mÜŞTERİLERToolStripMenuItem.Text = "Müşteriler";
            this.mÜŞTERİLERToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_Click);
            // 
            // pERSONELLERToolStripMenuItem
            // 
            this.pERSONELLERToolStripMenuItem.Name = "pERSONELLERToolStripMenuItem";
            this.pERSONELLERToolStripMenuItem.Size = new System.Drawing.Size(179, 28);
            this.pERSONELLERToolStripMenuItem.Text = "Personeller";
            this.pERSONELLERToolStripMenuItem.Click += new System.EventHandler(this.pERSONELLERToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 458);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATIŞLARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dERGİSAYILARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELLERToolStripMenuItem;
    }
}

