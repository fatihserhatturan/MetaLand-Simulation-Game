namespace metaLand
{
    partial class OyuncuGiris
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
            this.YöneticiSifre = new System.Windows.Forms.Label();
            this.YöneticiAdı = new System.Windows.Forms.Label();
            this.oyuncuSifre = new System.Windows.Forms.TextBox();
            this.oyuncuAdi = new System.Windows.Forms.TextBox();
            this.oyuncuGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YöneticiSifre
            // 
            this.YöneticiSifre.AutoSize = true;
            this.YöneticiSifre.Location = new System.Drawing.Point(165, 336);
            this.YöneticiSifre.Name = "YöneticiSifre";
            this.YöneticiSifre.Size = new System.Drawing.Size(34, 16);
            this.YöneticiSifre.TabIndex = 8;
            this.YöneticiSifre.Text = "Sifre";
            // 
            // YöneticiAdı
            // 
            this.YöneticiAdı.AutoSize = true;
            this.YöneticiAdı.Location = new System.Drawing.Point(165, 220);
            this.YöneticiAdı.Name = "YöneticiAdı";
            this.YöneticiAdı.Size = new System.Drawing.Size(75, 16);
            this.YöneticiAdı.TabIndex = 7;
            this.YöneticiAdı.Text = "Oyuncu Adı";
            // 
            // oyuncuSifre
            // 
            this.oyuncuSifre.Location = new System.Drawing.Point(259, 330);
            this.oyuncuSifre.Name = "oyuncuSifre";
            this.oyuncuSifre.Size = new System.Drawing.Size(213, 22);
            this.oyuncuSifre.TabIndex = 6;
            // 
            // oyuncuAdi
            // 
            this.oyuncuAdi.Location = new System.Drawing.Point(259, 214);
            this.oyuncuAdi.Name = "oyuncuAdi";
            this.oyuncuAdi.Size = new System.Drawing.Size(213, 22);
            this.oyuncuAdi.TabIndex = 5;
            // 
            // oyuncuGirisButton
            // 
            this.oyuncuGirisButton.Location = new System.Drawing.Point(322, 395);
            this.oyuncuGirisButton.Name = "oyuncuGirisButton";
            this.oyuncuGirisButton.Size = new System.Drawing.Size(75, 23);
            this.oyuncuGirisButton.TabIndex = 9;
            this.oyuncuGirisButton.Text = "GİRİS";
            this.oyuncuGirisButton.UseVisualStyleBackColor = true;
            this.oyuncuGirisButton.Click += new System.EventHandler(this.oyuncuGirisButton_Click);
            // 
            // OyuncuGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.oyuncuGirisButton);
            this.Controls.Add(this.YöneticiSifre);
            this.Controls.Add(this.YöneticiAdı);
            this.Controls.Add(this.oyuncuSifre);
            this.Controls.Add(this.oyuncuAdi);
            this.Name = "OyuncuGiris";
            this.Size = new System.Drawing.Size(637, 567);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YöneticiSifre;
        private System.Windows.Forms.Label YöneticiAdı;
        private System.Windows.Forms.TextBox oyuncuSifre;
        private System.Windows.Forms.TextBox oyuncuAdi;
        private System.Windows.Forms.Button oyuncuGirisButton;
    }
}
