using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metaLand
{
    public partial class OyuncuGiris : UserControl
    {
        public delegate void UserControlButtonClick1(object sender, EventArgs e);
        public event UserControlButtonClick1 oyuncuGiris;
        Singleton singleton = Singleton.GetInstance();
        string connectionString = "Data Source=.;Initial Catalog=metaLand;Integrated Security=True";
        int yemek = 1, para = 1, esya = 1;

        public OyuncuGiris()
        {
            InitializeComponent();

        }

        private void oyuncuGirisButton_Click(object sender, EventArgs e)
        {
            singleton.oyuncuSifre = oyuncuSifre.Text;
            singleton.oyuncuAd = oyuncuAdi.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM kullanıcı_info  where kullanıcı_adı like '" + singleton.oyuncuAd + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    string a = dr[6].ToString();
                    para = int.Parse(a);
                    //label16.Text = a;
                    a = dr[4].ToString();
                    yemek = int.Parse(a);
                    a = dr[5].ToString();
                    esya = int.Parse(a);
                }


                dr.Close();
                connection.Close();
            }
            if (para <= 0 || esya <= 0 || yemek <= 0)
            {
                MessageBox.Show("Kaynaklarınız tükendiği için,oyunu kaybettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                oyuncuGiris?.Invoke(this, e);
            }
        }
    }
}
