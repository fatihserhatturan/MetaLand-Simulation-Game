using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metaLand
{
    public partial class kayıtOlma : UserControl
    {
        public delegate void UserControlButtonClick1(object sender, EventArgs e);
        public event UserControlButtonClick1 kayıtOl;
        Singleton singleton = Singleton.GetInstance();
        public kayıtOlma()
        {
            InitializeComponent();
           
        }

        private void KayıtOl_Click(object sender, EventArgs e)
        {
            
            singleton.KullanıcıAd = Ad.Text;
            singleton.KullanıcıSoyAd = SoyAd.Text;
            singleton.KullnıcıSifre = Sifre.Text;
            kayıtOl?.Invoke(this, e);
        }
    }
}
