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
    public partial class HaritaGoruntusu : UserControl
    {
        Singleton singleton = Singleton.GetInstance();
        public HaritaGoruntusu()
        {
            InitializeComponent();
            
            int c = 0;
            int b = 0;

            Panel panel = new Panel();
            panel.Location = new System.Drawing.Point(22, 22);
            panel.Size = new System.Drawing.Size(75 * singleton.haritaboyut, 75 * singleton.haritaboyut);
            this.Controls.Add(panel);
            
            for (int i = 0; i < singleton.haritaboyut; i++)
            {
                for (int j = 0; j < singleton.haritaboyut; j++)
                {
                    TextBox picbox = new TextBox();
                    picbox.Location = new System.Drawing.Point(75 * c, 75 * b);
                    picbox.Size = new System.Drawing.Size(75, 75);
                    picbox.BackColor = System.Drawing.Color.Black;
                    panel.Controls.Add(picbox);

                    c++;
                }
                c = 0;
                b++;
            }
            
        }
    }
}






