namespace DergimWinformUI
{
    partial class SatisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.nudSatilanSayiAdedi = new System.Windows.Forms.NumericUpDown();
            this.cmbDergiSayilari = new System.Windows.Forms.ComboBox();
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.nudSatisTutari = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatilanSayiAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisTutari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dergi Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Satılan Sayı Adedi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(8, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satış Tutarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Açıklama";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(12, 25);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(133, 21);
            this.cmbMusteriler.TabIndex = 0;
            // 
            // nudSatilanSayiAdedi
            // 
            this.nudSatilanSayiAdedi.Location = new System.Drawing.Point(12, 168);
            this.nudSatilanSayiAdedi.Name = "nudSatilanSayiAdedi";
            this.nudSatilanSayiAdedi.Size = new System.Drawing.Size(133, 20);
            this.nudSatilanSayiAdedi.TabIndex = 3;
            // 
            // cmbDergiSayilari
            // 
            this.cmbDergiSayilari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDergiSayilari.FormattingEnabled = true;
            this.cmbDergiSayilari.Location = new System.Drawing.Point(12, 72);
            this.cmbDergiSayilari.Name = "cmbDergiSayilari";
            this.cmbDergiSayilari.Size = new System.Drawing.Size(133, 21);
            this.cmbDergiSayilari.TabIndex = 1;
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(12, 121);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(133, 21);
            this.cmbPersoneller.TabIndex = 2;
            // 
            // nudSatisTutari
            // 
            this.nudSatisTutari.Location = new System.Drawing.Point(12, 212);
            this.nudSatisTutari.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudSatisTutari.Name = "nudSatisTutari";
            this.nudSatisTutari.Size = new System.Drawing.Size(133, 20);
            this.nudSatisTutari.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 258);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 93);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(151, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 326);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(10, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(75, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nudSatisTutari);
            this.Controls.Add(this.nudSatilanSayiAdedi);
            this.Controls.Add(this.cmbDergiSayilari);
            this.Controls.Add(this.cmbPersoneller);
            this.Controls.Add(this.cmbMusteriler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSatilanSayiAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSatisTutari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.NumericUpDown nudSatilanSayiAdedi;
        private System.Windows.Forms.ComboBox cmbDergiSayilari;
        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.NumericUpDown nudSatisTutari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}