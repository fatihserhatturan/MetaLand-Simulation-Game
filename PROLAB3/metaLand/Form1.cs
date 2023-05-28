using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace metaLand
{
    public partial class Form1 : Form
    {
        SqlConnection connectionstring = new SqlConnection("Data Source=.; Initial Catalog = metaLand; Integrated Security = True");
        Singleton singleton = Singleton.GetInstance();
        public Form1()
        {
            InitializeComponent();
            userControl11.ButtonClick1 += UserControlButtonClickHandler1;
            userControl11.ButtonClick2 += UserControlButtonClickHandler2;
            userControl11.kayıtOlEkranClick += UserControlkayıtOlEkranClickHandler;
            kullanıcıGirisi1.kullanıcıGiris += KullanıcıGirisiButtonClickHandlerKullanıcıGiris;
            oyuncuGiris1.oyuncuGiris += OyuncuGirisButtonClickHandlerOyuncuGiris;
            kayıtOlma1.kayıtOl += kayıtOlButtonClickHandlerkayıtOl;
            kullaniciPanel1.harita += haritaGoruntuButtonClickHandlerharita;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            oyuncuGiris1.Hide();
            kullanıcıGirisi1.Hide();
            kullaniciPanel1.Hide();
            oyuncuPanel21.Hide();
            kayıtOlma1.Hide();
            anamenu.Visible = false;

        }
        private void UserControlButtonClickHandler1(object sender, EventArgs e)
        {
            kullanıcıGirisi1.Show();
            userControl11.Hide();
            anamenu.Visible = true;

        }
        private void haritaGoruntuButtonClickHandlerharita(object sender, EventArgs e)
        {
            /**/
         

        }
        private void UserControlkayıtOlEkranClickHandler(object sender, EventArgs e)
        {
            kayıtOlma1.Show();
            userControl11.Hide();
            anamenu.Visible = true;

        }
        private void UserControlButtonClickHandler2(object sender, EventArgs e)
        {
           

            oyuncuGiris1.Show();
            userControl11.Hide();
            anamenu.Visible = true;

        }public int haritaBul()
        {
            List<object> veriListesi = new List<object>();
            int returnValue;

            SqlConnection connection = connectionstring;
            connection.Open();

            string sqlQuery = "SELECT harita_id FROM harita_info";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                object deger = reader["harita_id"];
                veriListesi.Add(deger);
            }

            object[] veriDizisi = veriListesi.ToArray();

            reader.Close();
            connection.Close();

            Random random = new Random();
            int randomNumber = random.Next(0,veriDizisi.Length);


            returnValue = Convert.ToInt32(veriDizisi[randomNumber]); 

            return returnValue;
        }


        private void kayıtOlButtonClickHandlerkayıtOl(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            int yemek=100, esya=100, para = 1000;
            DateTime time = DateTime.Now;
            int harita = haritaBul();

            using (SqlConnection connection = connectionstring)
            {
                
                string insertQuery = "INSERT INTO kullanıcı_info (kullanıcı_no,kullanıcı_adı,kullanıcı_soyadı,kullanıcı_sifresi,yemek_miktarı,esya_miktarı,para_miktarı,kullanıcı_kayıt_tarih,kullanıcı_harita,kullanıcı_meslek) VALUES (@no, @ad, @soyad, @sifre, @yemek, @esya, @para, @tarih, @harita, @meslek)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@no",randomNumber);
                cmd.Parameters.AddWithValue("@ad", singleton.KullanıcıAd);
                cmd.Parameters.AddWithValue("@soyad", singleton.KullanıcıSoyAd);
                cmd.Parameters.AddWithValue("@sifre", singleton.KullnıcıSifre);
                cmd.Parameters.AddWithValue("@yemek", yemek);
                cmd.Parameters.AddWithValue("@esya", esya);
                cmd.Parameters.AddWithValue("@para", para);
                cmd.Parameters.AddWithValue("tarih",time);
                cmd.Parameters.AddWithValue("harita", harita.ToString());
                cmd.Parameters.AddWithValue("meslek","arsa");
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("kayıt başarıyla oluşturuldu;");
                kayıtOlma1.Hide();
                userControl11.Show();
            }
            }

           
        

        private void KullanıcıGirisiButtonClickHandlerKullanıcıGiris(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from yönetici_info where yönetici_ad='" +singleton.yöneticiAd+ "'and yönetici_sifre='" +singleton.yöneticiSifre+"'",connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                kullanıcıGirisi1.Hide();
                userControl11.Hide();
                kullaniciPanel1.Show();
                anamenu.Visible = false;
            }
            else
            {
                MessageBox.Show("Giriş İşlemi başarısız oldu!");
            }

            connection.Close();

        }
        private void OyuncuGirisButtonClickHandlerOyuncuGiris(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanıcı_info where kullanıcı_adı='" + singleton.oyuncuAd + "'and kullanıcı_sifresi='" + singleton.oyuncuSifre + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                kullanıcıGirisi1.Hide();
                userControl11.Hide();
                oyuncuPanel21.Show();
                anamenu.Visible = false;
            }
            else
            {
                MessageBox.Show("Giriş İşlemi başarısız oldu!");
            }
            connection.Close();

           

        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            oyuncuGiris1.Hide();
            kullanıcıGirisi1.Hide();
            kayıtOlma1.Hide();
            userControl11.Show();
            anamenu.Visible = false;
        }

        
    }
}
