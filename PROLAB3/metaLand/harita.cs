using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metaLand
{
    public partial class harita : Form
    {
        Singleton singleton = Singleton.GetInstance();
        SqlConnection connectionstring = new SqlConnection("Data Source=.; Initial Catalog = metaLand; Integrated Security = True");
        public harita()
        {
            InitializeComponent();
        }
       
        private void harita_Load(object sender, EventArgs e)
        {
            List<Button> picboxs = new List<Button>();
            int c = 0; int b = 0;int sayac = 1;
            string alanTürü = null;
            Image onceki=null;

            for (int i = 0; i < singleton.haritaboyut; i++)
            {
                for (int j = 0; j < singleton.haritaboyut; j++)
                {
                    
                    alanTürü = türVer(sayac);
                    Size newSize = new Size(75, 75);
                    Button picbox = new Button();
                    picbox.Location = new System.Drawing.Point(75 + (75 * c), 75 + (75 * b));
                    picbox.Size = new System.Drawing.Size(75, 75);
                    picbox.BackColor = System.Drawing.Color.White;
                    picbox.Text = sayac.ToString();
                   
                    if(alanTürü == "arsa")
                    {
                         onceki = Properties.Resources.arsajpg;
                    }

                    if (alanTürü == "magaza")
                    {
                        onceki = Properties.Resources.magaza;
                    }

                    if (alanTürü == "market")
                    {
                        onceki = Properties.Resources.market;
                    }

                    Image compressedImage = new Bitmap(onceki, newSize);
                    picbox.BackgroundImage= compressedImage;

                    this.Controls.Add(picbox);
                    picboxs.Add(picbox);
                    picbox.Click += new EventHandler(picbox_Click); // Olay işleyicisini atayın

                    sayac++;
                    c++;
                }
                c = 0;
                b++;
            }
        }

        public  string türVer(int alanNo)
        {
            string returnValue = null;

            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from alan_info where alan_harita = '" + singleton.haritaID + "' AND alan_no= '" + alanNo + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                 returnValue= dr["alan_türü"].ToString();
            }

            connection.Close();

            return returnValue;
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
    
                int alanNo = Convert.ToInt32(clickedButton.Text);
                string alanTür = null;
                singleton.alanNo = alanNo;

                SqlConnection connection = connectionstring;
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from alan_info where alan_harita = '" + singleton.haritaID + "' AND alan_no= '" + alanNo + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    alanSahip.Text= dr["alan_sahibi"].ToString();
                    alanTür = dr["alan_türü"].ToString();
                    tür.Text = alanTür;
                   
                    
                }
                connection.Close();
                if (alanTür != "arsa")
                {
                    fiyat.Text = fiyatver(alanNo, alanTür);
                    singleton.ürünFİyat = Convert.ToInt32(fiyat.Text);
                }
                else
                {
                    fiyat.Text= "fiyat bilgisi yok";
                    
                }
                if (alanTür != "arsa")
                {
                    panel2.Visible = true;
                }
                else
                {
                    panel2.Visible= false;
                }
               
            }
        }
        
        public string fiyatver(int alanNo,string alanTür)
        {
            string returnValue= null;

            SqlConnection connection = connectionstring;
            connection.Open();

            string insertQuery = null;

            if (alanTür == "magaza")
            {
                insertQuery = "select * from magaza where magaza_harita = '" + singleton.haritaID + "' AND magaza_no= '" + alanNo + "'";
            }

            if (alanTür == "market")
            {
               insertQuery=  "select * from market where market_harita = '" + singleton.haritaID + "' AND market_no= '" + alanNo + "'";

            }
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if (alanTür=="magaza")
                {
                    returnValue = dr["magaza_ücret"].ToString();
                }

                if (alanTür=="market")
                {
                    returnValue = dr["market_ücret"].ToString();
                }
               
            }
            connection.Close();
            return returnValue;

        }

        private void ürünAl_Click(object sender, EventArgs e)
        {
            string insertQuery = null;
            int ekle = 0;

            SqlConnection connection = connectionstring;
            

            if (tür.Text == "magaza")
            {
               ekle= yöneticiBilgiVer("esya");

                insertQuery = "Update yönetici_info set yönetici_esya  = @esya where yönetici_ad = @ad ";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("esya",Convert.ToInt32(ürünAdet.Text)+ekle);
                cmd.Parameters.AddWithValue("ad", singleton.yöneticiAd);
                cmd.ExecuteNonQuery();
            }
            if(tür.Text == "market")
            {
               ekle= yöneticiBilgiVer("yemek");

                insertQuery = "Update yönetici_info set yönetici_yemek  = @yemek where yönetici_ad = @ad ";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("yemek", Convert.ToInt32(ürünAdet.Text)+ekle);
                cmd.Parameters.AddWithValue("ad", singleton.yöneticiAd);
                cmd.ExecuteNonQuery();
            }
            
            connection.Close();
            yöneticiParaAzalt();
            sahipParaArtır();
            MessageBox.Show("işlem başarılı");
        }

        public int yöneticiBilgiVer(string talepbilgi)
        {

            string insertQuery = null;
            int returnValue = 0;
            string talep = null;

            SqlConnection connection = connectionstring;
            connection.Open();

            if (talepbilgi == "esya")
            {
                insertQuery = "select * from yönetici_info  where yönetici_ad like '"+singleton.yöneticiAd +"'";
                talep = "yönetici_esya";
            }
            if (talepbilgi == "yemek")
            {
                insertQuery = "select * from yönetici_info   where yönetici_ad like '"+singleton.yöneticiAd +"'";
                talep ="yönetici_yemek";
            }
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if(dr.Read())
            {
                returnValue = Convert.ToInt32(dr[talep]);
            }

            connection.Close();

            return returnValue;

        }

        public void yöneticiParaAzalt()
        {

            SqlConnection connection = connectionstring;
            string insertQuery = null;
            int ekle = yöneticiParaBul();

            insertQuery = "Update yönetici_info set yönetici_para  = @para where yönetici_ad = @ad ";
            connection.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("para",ekle-(singleton.ürünFİyat*Convert.ToInt32(ürünAdet.Text)));
            cmd.Parameters.AddWithValue("ad", singleton.yöneticiAd);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public int yöneticiParaBul()
        {
            int returnValue = 0;
            SqlConnection connection = connectionstring;
            connection.Open();

            string insertQuery = null;
            insertQuery = "select * from yönetici_info  where yönetici_ad like '" + singleton.yöneticiAd + "'";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                returnValue = Convert.ToInt32(dr["yönetici_para"]);
            }
            connection.Close() ;

            return returnValue;
        }
        public int kullanıcıParaBul()
        {

            int returnValue = 0;

            SqlConnection connection = connectionstring;
            connection.Open();

            string insertQuery = null;
            insertQuery = "select * from kullanıcı_info  where kullanıcı_adı like '" + alanSahip.Text + "'";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                returnValue = Convert.ToInt32(dr["para_miktarı"]);
            }
            connection.Close();

            return returnValue;
        }

        public void sahipParaArtır()
        {
           int ekle = 0;
           string returnDeger= sahipBul();
           string insertQuery = null;
           SqlConnection connection = connectionstring;


            if ( returnDeger == "yönetici")
            {
               ekle = yöneticiParaBul();
               insertQuery = "Update yönetici_info set yönetici_para  =  @para where yönetici_ad = @ad ";
            }
            else
            {
                ekle = kullanıcıParaBul();
                insertQuery = "Update kullanıcı_info set para_miktarı  =  @para where kullanıcı_adı = @ad ";
            }
            
            connection.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("para", ekle + (singleton.ürünFİyat * Convert.ToInt32(ürünAdet.Text)));
            cmd.Parameters.AddWithValue("ad", alanSahip.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        public string sahipBul()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            string returnValue = null;
            string selectQuery = "SELECT COUNT(*) FROM yönetici_info WHERE yönetici_ad ='"+alanSahip.Text+"'";
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            int count = (int)cmd.ExecuteScalar();
            connection.Close();

            if (count > 0)
            {
                returnValue = "yönetici";
            }
            else
            {
                returnValue = "kullanıcı";
            }

            return returnValue;
        }



        public int randomÜret()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 9999);
                
            return randomNumber;
        }

        private void isBasvuruOnayla_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            string insertQuery = "INSERT INTO basvuru_info (basvuru_no,basvuru_isim,basvuru_saat,basvuru_ucret,basvuru_alan_sahip,basvuru_alan_no,basvuru_alan_harita) VALUES (@no, @isim, @saat, @ucret, @alanSahip, @alanNo, @alanHarita)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("no", randomÜret());
            cmd.Parameters.AddWithValue("isim", singleton.yöneticiAd);
            cmd.Parameters.AddWithValue("saat", Convert.ToInt32(isBasvuruSaat.Text));
            cmd.Parameters.AddWithValue("ucret", Convert.ToInt32(isBasvuruFiyat.Text));
            cmd.Parameters.AddWithValue("alanSahip", alanSahip.Text);
            cmd.Parameters.AddWithValue("alanNo", singleton.alanNo);
            cmd.Parameters.AddWithValue("alanHarita", singleton.haritaID);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("işlem başarılı");
        }

  
    }
}
