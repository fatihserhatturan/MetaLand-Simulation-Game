namespace metaLand
{
    partial class KullanıcıGirisi
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
            this.components = new System.ComponentModel.Container();
            this.yöneticiAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yönneticiSifre = new System.Windows.Forms.TextBox();
            this.YöneticiAdı = new System.Windows.Forms.Label();
            this.YöneticiSifre = new System.Windows.Forms.Label();
            this.KullancıGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yöneticiAd
            // 
            this.yöneticiAd.Location = new System.Drawing.Point(262, 178);
            this.yöneticiAd.Name = "yöneticiAd";
            this.yöneticiAd.Size = new System.Drawing.Size(213, 22);
            this.yöneticiAd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // yönneticiSifre
            // 
            this.yönneticiSifre.Location = new System.Drawing.Point(262, 294);
            this.yönneticiSifre.Name = "yönneticiSifre";
            this.yönneticiSifre.Size = new System.Drawing.Size(213, 22);
            this.yönneticiSifre.TabIndex = 2;
            // 
            // YöneticiAdı
            // 
            this.YöneticiAdı.AutoSize = true;
            this.YöneticiAdı.Location = new System.Drawing.Point(168, 184);
            this.YöneticiAdı.Name = "YöneticiAdı";
            this.YöneticiAdı.Size = new System.Drawing.Size(78, 16);
            this.YöneticiAdı.TabIndex = 3;
            this.YöneticiAdı.Text = "Yönetici Adı";
            // 
            // YöneticiSifre
            // 
            this.YöneticiSifre.AutoSize = true;
            this.YöneticiSifre.Location = new System.Drawing.Point(168, 300);
            this.YöneticiSifre.Name = "YöneticiSifre";
            this.YöneticiSifre.Size = new System.Drawing.Size(34, 16);
            this.YöneticiSifre.TabIndex = 4;
            this.YöneticiSifre.Text = "Sifre";
            // 
            // KullancıGirisButton
            // 
            this.KullancıGirisButton.Location = new System.Drawing.Point(338, 351);
            this.KullancıGirisButton.Name = "KullancıGirisButton";
            this.KullancıGirisButton.Size = new System.Drawing.Size(75, 23);
            this.KullancıGirisButton.TabIndex = 5;
            this.KullancıGirisButton.Text = "GİRİS";
            this.KullancıGirisButton.UseVisualStyleBackColor = true;
            this.KullancıGirisButton.Click += new System.EventHandler(this.KullancıGirisButton_Click);
            // 
            // KullanıcıGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KullancıGirisButton);
            this.Controls.Add(this.YöneticiSifre);
            this.Controls.Add(this.YöneticiAdı);
            this.Controls.Add(this.yönneticiSifre);
            this.Controls.Add(this.yöneticiAd);
            this.Name = "KullanıcıGirisi";
            this.Size = new System.Drawing.Size(776, 491);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yöneticiAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox yönneticiSifre;
        private System.Windows.Forms.Label YöneticiAdı;
        private System.Windows.Forms.Label YöneticiSifre;
        private System.Windows.Forms.Button KullancıGirisButton;
    }
}
