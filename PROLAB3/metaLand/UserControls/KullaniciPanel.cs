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
    public partial class KullaniciPanel : UserControl
    {
        
        public delegate void UserControlButtonClick1(object sender, EventArgs e);
        public event UserControlButtonClick1 harita;

        SqlConnection connectionstring = new SqlConnection("Data Source=.; Initial Catalog = metaLand; Integrated Security = True");
        Singleton singleton = Singleton.GetInstance();
        public KullaniciPanel()
        {
         
           
            InitializeComponent();

        }

        
        private void haritaOlustur_Click(object sender, EventArgs e)
        {
            string harita= haritaBoyut.Text;
            int haritaboyut=Convert.ToInt32(harita);
            DateTime now = DateTime.Now;

            SqlConnection connection = connectionstring;
            string insertQuery = "INSERT INTO harita_info (harita_id,harita_boyut,harita_tarih) VALUES (@id, @boyut,@tarih)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@id", haritaID.Text);
            cmd.Parameters.AddWithValue("@boyut",haritaboyut );
            cmd.Parameters.AddWithValue("@tarih",now);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            alanAta(haritaboyut);

            MessageBox.Show("kayıt başarıyla oluşturuldu;");

        }

        public void alanAta(int haritaboyut)
        {

            string tür = "arsa";

            for (int i = 0; i < haritaboyut*haritaboyut; i++)
            {
                
                SqlConnection connection = connectionstring;
                string insertQuery = "INSERT INTO alan_info (alan_no,alan_türü,alan_sahibi,alan_harita) VALUES (@no, @tür, @sahip, @harita)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@no", i);
                cmd.Parameters.AddWithValue("@tür", tür);
                cmd.Parameters.AddWithValue("sahip",singleton.yöneticiAd);
                cmd.Parameters.AddWithValue("harita",haritaID.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void haritaGoruntu_Click(object sender, EventArgs e)
        {
            int haritaboyut = 0;
            singleton.haritaID=haritaIDbul.Text;
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from harita_info where harita_id like '" + haritaIDbul.Text + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                 haritaboyut = Convert.ToInt32(dr["harita_boyut"]);
            }

            else
            {
                 MessageBox.Show("gecersiz id");
            }

            connection.Close();
            singleton.haritaboyut= haritaboyut;
            harita?.Invoke(this, e);

            harita form = new harita();
            form.Show();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From kullanıcı_info where kullanıcı_harita like '" + haritaIDsorgu.Text + "'", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();

        }

        private void optimizeEt_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from yönetici_info where yönetici_ad like '" + singleton.yöneticiAd + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yöneticiPara.Text = dr[2].ToString();
                yöneticiEsya.Text = dr[3].ToString();
                yöneticiYemek.Text = dr[4].ToString();
            }
            connection.Close();
            
        }

        private void menkulGörüntü_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From alan_info where alan_sahibi like '" + singleton.yöneticiAd + "'", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void pazarGörüntü_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From ürün_info ", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            connection.Close();
        }

        public void pazaraGit(int ıd,int fiyat,string tür,string sahib)
        {
            SqlConnection connection = connectionstring;
            string insertQuery = "INSERT INTO ürün_info (ürün_ID,ürün_türü,ürün_sahibi,ürün_fiyat) VALUES (@id, @tür,@sahib,@fiyat)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@id", ıd);
            cmd.Parameters.AddWithValue("@tür", tür);
            cmd.Parameters.AddWithValue("@sahib", sahib);
            cmd.Parameters.AddWithValue("@fiyat", fiyat);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void menkulSat_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from alan_info where alan_no like '" + menkulID.Text + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int ıd = Convert.ToInt32(dr["alan_no"]); 
                string tür = dr["alan_türü"].ToString();
                string sahib = dr["alan_sahibi"].ToString();
                int fiyat = Convert.ToInt32(talepFiyat.Text); 
                connection.Close();
                pazaraGit(ıd,fiyat,tür,sahib);
                MessageBox.Show("kayıt oluşturuldu");

            }

            else
            {
                MessageBox.Show("gecersiz id");
                connection.Close();
            }
           
        }

        public void satınAlÜrün()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update alan_info set alan_sahibi  =@sahip where alan_no=@id", connection);
            cmd.Parameters.AddWithValue("sahip", singleton.yöneticiAd);
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(ürünID.Text));
            cmd.ExecuteNonQuery();
            connection.Close();


        }

        public void ürünSahibeParaAktar(int para,int fiyat,string sahip)
        {
            int yenipara=para+fiyat ;
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update yönetici_info set yönetici_para  =@para where yönetici_ad=@ad", connection);
            cmd.Parameters.AddWithValue("para", yenipara);
            cmd.Parameters.AddWithValue("ad", sahip);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ürünSahibiBul(string sahip,int fiyat)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from yönetici_info where yönetici_ad like '" + sahip + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int para = Convert.ToInt32(dr["yönetici_para"]);
                connection.Close() ;
                ürünSahibeParaAktar(para,fiyat,sahip);
            }
        }
        public void ürünsil()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from ürün_info where ürün_ID  =@id", connection);
            cmd.Parameters.AddWithValue("id",ürünID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void yöneticiParaGüncelle(int yenipara)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update yönetici_info set yönetici_para  =@para where yönetici_ad=@ad", connection);
            cmd.Parameters.AddWithValue("para",yenipara);
            cmd.Parameters.AddWithValue("ad", singleton.yöneticiAd);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void satınAl_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from ürün_info where ürün_ID like '" + ürünID.Text + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int fiyat = Convert.ToInt32(dr["ürün_fiyat"]);
                string sahip = dr["ürün_sahibi"].ToString(); 
                connection.Close();

                SqlConnection connection2 = connectionstring;
                connection2.Open();
                SqlCommand cmd2 = new SqlCommand("select * from yönetici_info where yönetici_ad like '" + singleton.yöneticiAd + "'", connection2);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    int para = Convert.ToInt32(dr2["yönetici_para"]);
                    
                    connection2.Close();

                    if(para > fiyat)
                    {
                        satınAlÜrün();  
                        ürünsil();
                        yöneticiParaGüncelle(para-fiyat);
                        ürünSahibiBul(sahip,fiyat);
                       
                        MessageBox.Show("işlem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("yeterli paranız bulunmamaktadır");
                    }
                }

            }
        }

        private void menkulİnşaOnay_Click(object sender, EventArgs e)
        {
            string selectedValue =listBox1.SelectedItem.ToString();
           
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update alan_info set alan_türü  = @tür where alan_no = @no and alan_harita = @harita", connection);
            cmd.Parameters.AddWithValue("tür",selectedValue );        
            cmd.Parameters.AddWithValue("no", menkulID2.Text);
            cmd.Parameters.AddWithValue("harita", menkulHaritaInsa.Text);
            cmd.ExecuteNonQuery();                                   
            connection.Close();

            if (selectedValue == "magaza")
            {
                int no = Convert.ToInt32(menkulID2.Text);
                magazaAta(menkulHaritaInsa.Text, no);
            }

            if (selectedValue == "market")
            {
                int no= Convert.ToInt32(menkulID2.Text);
                marketAta(menkulHaritaInsa.Text,no);
            }

            MessageBox.Show("işlem başarılı");

        }

        public void marketAta(string harita,int no)
        {
            SqlConnection connection = connectionstring;
            string insertQuery = "INSERT INTO market (market_no,market_harita,market_ücret,market_seviye,market_kapasite) VALUES (@no, @harita, @ücret, @seviye, @kapasite)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@harita", harita);
            cmd.Parameters.AddWithValue("@ücret", 5);
            cmd.Parameters.AddWithValue("@seviye", 1);
            cmd.Parameters.AddWithValue("@kapasite", 3);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void magazaAta(string harita,int no)
        {
            SqlConnection connection = connectionstring;
            string insertQuery = "INSERT INTO magaza (magaza_no,magaza_harita,magaza_ücret,magaza_seviye,magaza_kapasite) VALUES (@no, @harita, @ücret, @seviye, @kapasite)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("@no", no);
            cmd.Parameters.AddWithValue("@harita", harita);
            cmd.Parameters.AddWithValue("@ücret", 5);
            cmd.Parameters.AddWithValue("@seviye", 1);
            cmd.Parameters.AddWithValue("@kapasite", 3);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void isBasvuruGörüntüle_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;

            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From basvuru_info where basvuru_alan_sahip like '" + singleton.yöneticiAd + "'", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void basvuruOnay_Click(object sender, EventArgs e)
        {
            basvuruDegerBul(Convert.ToInt32(basvuruNo.Text));
            
            SqlConnection connection = connectionstring;
            string insertQuery = "INSERT INTO calısan_info (calısan_harita,calısan_ad,calısan_alan_no,calısan_saat,calısan_ucret) VALUES (@harita, @ad, @alanNo, @saat, @ucret)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("harita",singleton.calısanHarita);
            cmd.Parameters.AddWithValue("ad",singleton.calısanAd);
            cmd.Parameters.AddWithValue("alanNo",singleton.calısanAlanNo);
            cmd.Parameters.AddWithValue("saat",singleton.calısanSaat);
            cmd.Parameters.AddWithValue("ucret",singleton.calısanUcret);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            basvuruSil();
            MessageBox.Show("işlem başarılı");

        }

        public void basvuruSil()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from basvuru_info where basvuru_no  =@no", connection);
            cmd.Parameters.AddWithValue("no",Convert.ToInt32(basvuruNo.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void basvuruDegerBul(int basvuruNo)
        {
            

            for(int i = 0;i<100;i++)
            {
                DataGridViewCell cell = dataGridView4.Rows[i].Cells[0];

                if (basvuruNo == Convert.ToInt32(cell.Value)) 
                {
                    DataGridViewCell cellHarita = dataGridView4.Rows[i].Cells[6];
                    DataGridViewCell cellAd = dataGridView4.Rows[i].Cells[1];
                    DataGridViewCell cellAlanNo = dataGridView4.Rows[i].Cells[5];
                    DataGridViewCell cellSaat = dataGridView4.Rows[i].Cells[2];
                    DataGridViewCell cellUcret = dataGridView4.Rows[i].Cells[3];

                    singleton.calısanAd=cellAd.Value.ToString();
                    singleton.calısanAlanNo=Convert.ToInt32(cellAlanNo.Value);
                    singleton.calısanSaat=Convert.ToInt32(cellSaat.Value);
                    singleton.calısanHarita=cellHarita.Value.ToString();
                    singleton.calısanUcret=Convert.ToInt32(cellUcret.Value);

                    break;
                }
            }
        }

        public int randomÜret()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 9999);

            return randomNumber;
        }

        private void basvuruReddet_Click(object sender, EventArgs e)
        {
            basvuruSil();
            MessageBox.Show("işlem başarılı");
        }

        private void basvuru_pazarlık_Click(object sender, EventArgs e)
        {
            basvuruSil();
            panel6.Visible = true;
        }

        private void basvuruYeniOnayla_Click(object sender, EventArgs e)
        {
            basvuruDegerBul(Convert.ToInt32(basvuruNoYeni.Text));

            SqlConnection connection = connectionstring;
            connection.Open();
            string insertQuery = "INSERT INTO basvuru_info (basvuru_no,basvuru_isim,basvuru_saat,basvuru_ucret,basvuru_alan_sahip,basvuru_alan_no,basvuru_alan_harita) VALUES (@no, @isim, @saat, @ucret, @alanSahip, @alanNo, @alanHarita)";
            SqlCommand cmd = new SqlCommand(insertQuery, connection);
            cmd.Parameters.AddWithValue("no", Convert.ToInt32(basvuruNoYeni.Text));
            cmd.Parameters.AddWithValue("isim", singleton.calısanAd);
            cmd.Parameters.AddWithValue("saat",Convert.ToInt32(saatYeni.Text) );
            cmd.Parameters.AddWithValue("ucret", Convert.ToInt32(fiyatYeni.Text));
            cmd.Parameters.AddWithValue("alanSahip", singleton.yöneticiAd);
            cmd.Parameters.AddWithValue("alanNo", singleton.calısanAlanNo);
            cmd.Parameters.AddWithValue("alanHarita", singleton.calısanHarita);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("işlem başarılı");
        }

        string connectionString = "Data Source=.;Initial Catalog=metaLand;Integrated Security=True";
        DateTime current = new DateTime(2023, 5, 27);   
        string meslek;

        private void button2_Click(object sender, EventArgs e)
        {
            Update();
            time();
            UpdateCalısanGelir();
            UpdateIsletmeGelir();
            MessageBox.Show("işlem başarılı");

        }
        /////////////////////////////////////////////////////////////////////////////
        public void UpdateIsletmeGelir()
        {
            string connectionString = "Data Source=.;Initial Catalog=metaLand;Integrated Security=True"; // Veritabanı bağlantı dizesini buraya girin

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // alan_info tablosundan alan_harita sütunu haritaIdilerletme.text ile eşleşen satırları çekme
                string selectQuery = "SELECT * FROM alan_info WHERE alan_harita = @haritaId";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@haritaId", haritaIdilerletme.Text);

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        string alanSahibi = reader["alan_sahibi"].ToString();

                        // alan_türü "arsa" olmayan satırları seçme ve para_miktarı değerine +100 ekleme
                        if (reader["alan_türü"].ToString() != "arsa")
                        {
                            reader.Close();
                            string updateQuery = "UPDATE kullanıcı_info SET para_miktarı = para_miktarı + 100 WHERE kullanıcı_adı = @kullanıcıAdı";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                            updateCommand.Parameters.AddWithValue("@kullanıcıAdı", alanSahibi);
                            updateCommand.ExecuteNonQuery();
                            break;
                        }
                    }
                }
            }

        }
        //////////////////////////////////////////////////////////////////////////////
        public void UpdateCalısanGelir()
        {
            string haritaID = haritaIdilerletme.Text; // haritaIdilerletme.Text, kullanıcıdan alınan harita_id değeri

            string selectQuery = "SELECT calısan_ad, calısan_ucret FROM calısan_info WHERE calısan_harita = @HaritaID";
            string updateQuery = "UPDATE kullanıcı_info SET para_miktarı = para_miktarı + @CalısanUcret WHERE kullanıcı_adı = @KullanıcıAdı";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@HaritaID", haritaID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string calısanAd = reader.GetString(0);
                            int calısanUcret = reader.GetInt32(1);

                            using (SqlConnection updateConnection = new SqlConnection(connectionString))
                            {
                                updateConnection.Open();

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, updateConnection))
                                {
                                    updateCommand.Parameters.AddWithValue("@CalısanUcret", calısanUcret);
                                    updateCommand.Parameters.AddWithValue("@KullanıcıAdı", calısanAd);

                                    int rowsAffected = updateCommand.ExecuteNonQuery();
                                }

                                updateConnection.Close();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }
        //////////////////////////////////////////////////////////////////////////////

        public void Update()
        {
            string haritaID = haritaIdilerletme.Text; // haritaIdilerletme.Text, kullanıcıdan alınan harita_id değeri
            
            string updateQueryCoin = $"UPDATE kullanıcı_info SET para_miktarı = para_miktarı - 10 WHERE kullanıcı_harita = @HaritaID";
            string updateQueryFood = $"UPDATE kullanıcı_info SET yemek_miktarı = yemek_miktarı - 10 WHERE kullanıcı_harita = @HaritaID";
            string updateQueryItem = $"UPDATE kullanıcı_info SET esya_miktarı = esya_miktarı - 10 WHERE kullanıcı_harita = @HaritaID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string meslek;
                List<string> updateQueries = new List<string>();

                using (SqlCommand command = new SqlCommand("SELECT kullanıcı_meslek FROM kullanıcı_info WHERE kullanıcı_harita = @HaritaID", connection))
                {
                    command.Parameters.AddWithValue("@HaritaID", haritaID);
                    meslek = (string)command.ExecuteScalar();
                }

                if (meslek != null)
                {
                    if (meslek == "magaza")
                    {
                        updateQueries.Add(updateQueryCoin);
                        updateQueries.Add(updateQueryFood);
                    }
                    else if (meslek == "market")
                    {
                        updateQueries.Add(updateQueryCoin);
                        updateQueries.Add(updateQueryItem);
                    }
                    else if (meslek == "arsa")
                    {
                        updateQueries.Add(updateQueryCoin);
                        updateQueries.Add(updateQueryFood);
                        updateQueries.Add(updateQueryItem);
                    }

                    foreach (string updateQuery in updateQueries)
                    {
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@HaritaID", haritaID);
                            int rowsAffected = updateCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.Close();
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        public void time()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM harita_info WHERE harita_id like '" + haritaIdilerletme.Text + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string a = dr[1].ToString();
                    label15.Text = a;

                }
                dr.Close();


                string query = "UPDATE harita_info SET harita_tarih = DATEADD(day, 1, harita_tarih) WHERE harita_id = '"+ haritaIdilerletme.Text+"'";

                // label15.Text = current.ToString();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekleme

                    // Sorguyu çalıştırma
                    int rowsAffected = command.ExecuteNonQuery();
                }
                connection.Close();

            }
        }


    }
}
