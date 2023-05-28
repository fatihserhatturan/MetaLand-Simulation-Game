using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static metaLand.UserControl1;

namespace metaLand
{
    public partial class KullanıcıGirisi : UserControl
    {



        public delegate void UserControlButtonClick1(object sender, EventArgs e);
        public event UserControlButtonClick1 kullanıcıGiris;
        Singleton singleton = Singleton.GetInstance();
        public KullanıcıGirisi()
        {
            InitializeComponent();
        }

        private void KullancıGirisButton_Click(object sender, EventArgs e)
        {
            singleton.yöneticiAd = yöneticiAd.Text;
            singleton.yöneticiSifre=yönneticiSifre.Text;

            kullanıcıGiris?.Invoke(this, e);
        }
    }
}
