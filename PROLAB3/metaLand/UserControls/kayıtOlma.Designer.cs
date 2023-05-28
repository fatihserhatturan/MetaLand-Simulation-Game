namespace metaLand
{
    partial class kayıtOlma
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ad = new System.Windows.Forms.TextBox();
            this.SoyAd = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KayıtOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(351, 240);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(204, 22);
            this.Ad.TabIndex = 0;
           // this.Ad.TextChanged += new System.EventHandler(this.Ad_TextChanged);
            // 
            // SoyAd
            // 
            this.SoyAd.Location = new System.Drawing.Point(351, 302);
            this.SoyAd.Name = "SoyAd";
            this.SoyAd.Size = new System.Drawing.Size(204, 22);
            this.SoyAd.TabIndex = 1;
            // 
            // Sifre
            // 
            this.Sifre.Location = new System.Drawing.Point(351, 364);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(204, 22);
            this.Sifre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "SİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "KAYIT OLMA EKRANI";
            // 
            // KayıtOl
            // 
            this.KayıtOl.Location = new System.Drawing.Point(381, 434);
            this.KayıtOl.Name = "KayıtOl";
            this.KayıtOl.Size = new System.Drawing.Size(140, 60);
            this.KayıtOl.TabIndex = 7;
            this.KayıtOl.Text = "KAYIT OL";
            this.KayıtOl.UseVisualStyleBackColor = true;
            this.KayıtOl.Click += new System.EventHandler(this.KayıtOl_Click);
            // 
            // kayıtOlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KayıtOl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.SoyAd);
            this.Controls.Add(this.Ad);
            this.Name = "kayıtOlma";
            this.Size = new System.Drawing.Size(826, 678);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox SoyAd;
        private System.Windows.Forms.TextBox Sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button KayıtOl;
    }
}
