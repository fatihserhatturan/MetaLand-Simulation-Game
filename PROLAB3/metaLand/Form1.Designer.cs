namespace metaLand
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
            this.anamenu = new System.Windows.Forms.Button();
            this.kayıtOlma1 = new metaLand.kayıtOlma();
            this.oyuncuPanel21 = new metaLand.OyuncuPanel2();
            this.kullaniciPanel1 = new metaLand.KullaniciPanel();
            this.oyuncuGiris1 = new metaLand.OyuncuGiris();
            this.kullanıcıGirisi1 = new metaLand.KullanıcıGirisi();
            this.userControl11 = new metaLand.UserControl1();
            this.SuspendLayout();
            // 
            // anamenu
            // 
            this.anamenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anamenu.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anamenu.Location = new System.Drawing.Point(62, 45);
            this.anamenu.Name = "anamenu";
            this.anamenu.Size = new System.Drawing.Size(236, 55);
            this.anamenu.TabIndex = 3;
            this.anamenu.Text = "ANA MENÜ";
            this.anamenu.UseVisualStyleBackColor = false;
            this.anamenu.Click += new System.EventHandler(this.anamenu_Click);
            // 
            // kayıtOlma1
            // 
            this.kayıtOlma1.Location = new System.Drawing.Point(440, 45);
            this.kayıtOlma1.Name = "kayıtOlma1";
            this.kayıtOlma1.Size = new System.Drawing.Size(814, 529);
            this.kayıtOlma1.TabIndex = 6;
            // 
            // oyuncuPanel21
            // 
            this.oyuncuPanel21.Location = new System.Drawing.Point(-9, -4);
            this.oyuncuPanel21.Name = "oyuncuPanel21";
            this.oyuncuPanel21.Size = new System.Drawing.Size(1492, 675);
            this.oyuncuPanel21.TabIndex = 5;
            // 
            // kullaniciPanel1
            // 
            this.kullaniciPanel1.Location = new System.Drawing.Point(-9, -4);
            this.kullaniciPanel1.Name = "kullaniciPanel1";
            this.kullaniciPanel1.Size = new System.Drawing.Size(1492, 675);
            this.kullaniciPanel1.TabIndex = 4;
            // 
            // oyuncuGiris1
            // 
            this.oyuncuGiris1.Location = new System.Drawing.Point(515, 24);
            this.oyuncuGiris1.Name = "oyuncuGiris1";
            this.oyuncuGiris1.Size = new System.Drawing.Size(637, 439);
            this.oyuncuGiris1.TabIndex = 2;
            // 
            // kullanıcıGirisi1
            // 
            this.kullanıcıGirisi1.Location = new System.Drawing.Point(440, 143);
            this.kullanıcıGirisi1.Name = "kullanıcıGirisi1";
            this.kullanıcıGirisi1.Size = new System.Drawing.Size(776, 457);
            this.kullanıcıGirisi1.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(405, 97);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 483);
            this.userControl11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 683);
            this.Controls.Add(this.kayıtOlma1);
            this.Controls.Add(this.oyuncuPanel21);
            this.Controls.Add(this.kullaniciPanel1);
            this.Controls.Add(this.anamenu);
            this.Controls.Add(this.oyuncuGiris1);
            this.Controls.Add(this.kullanıcıGirisi1);
            this.Controls.Add(this.userControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private KullanıcıGirisi kullanıcıGirisi1;
        private OyuncuGiris oyuncuGiris1;
        private System.Windows.Forms.Button anamenu;
        private KullaniciPanel kullaniciPanel1;
        private OyuncuPanel2 oyuncuPanel21;
        private kayıtOlma kayıtOlma1;
    }
}

