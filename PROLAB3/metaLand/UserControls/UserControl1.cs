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
    public partial class UserControl1 : UserControl
    {

        public delegate void UserControlButtonClick1(object sender, EventArgs e);
        public delegate void UserControlButtonClick2(object sender, EventArgs e);
        public delegate void UserControlkayıtOlEkranClick(object sender, EventArgs e);
        public event UserControlButtonClick1 ButtonClick1;
        public event UserControlButtonClick2 ButtonClick2;
        public event UserControlkayıtOlEkranClick kayıtOlEkranClick;
        public UserControl1()
        {
            InitializeComponent();
            HaritaGoruntusu haritaGoruntusu = new HaritaGoruntusu();
            haritaGoruntusu.Location = new System.Drawing.Point(75, 75);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick1?.Invoke(this, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick2?.Invoke(this, e);
        }

        private void kayıtOlEkran_Click(object sender, EventArgs e)
        {
            kayıtOlEkranClick?.Invoke(this, e);
        }
    }
}
