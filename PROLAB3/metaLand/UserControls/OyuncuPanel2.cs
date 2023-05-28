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
    public partial class OyuncuPanel2 : UserControl
    {
        SqlConnection connectionstring = new SqlConnection("Data Source=.; Initial Catalog = metaLand; Integrated Security = True");
        Singleton singleton = Singleton.GetInstance();

        public OyuncuPanel2()
        {
            InitializeComponent();
        }

        public string haritaIdBul()
        {
            string haritaID=null;

            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanıcı_info where kullanıcı_adı like '" + singleton.oyuncuAd + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                haritaID = dr["kullanıcı_harita"].ToString();
            }
            connection.Close();
            return haritaID;
        }

        private void haritaGörüntüle_Click(object sender, EventArgs e)
        {
            string haritaID = haritaIdBul();
            int haritaboyut = 0;
          
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from harita_info where harita_id like '" + haritaID + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                haritaboyut = Convert.ToInt32(dr["harita_boyut"]);
            }

     
            connection.Close();
            singleton.haritaboyut = haritaboyut;
            singleton.haritaID = haritaID;

            haritaOyuncu harita = new haritaOyuncu();
            harita.Show();
        }

        private void optimizeEt_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from kullanıcı_info where kullanıcı_adı like '" + singleton.oyuncuAd + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                yöneticiPara.Text = dr[6].ToString();
                yöneticiEsya.Text = dr[5].ToString();
                yöneticiYemek.Text = dr[4].ToString();
            }
            connection.Close();
        }

        private void menkulGörüntü_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From alan_info where alan_sahibi like '" + singleton.oyuncuAd + "'", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
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
                pazaraGit(ıd, fiyat, tür, sahib);
                MessageBox.Show("kayıt oluşturuldu");

            }

            else
            {
                MessageBox.Show("gecersiz id");
                connection.Close();
            }
        
        }
        public void pazaraGit(int ıd, int fiyat, string tür, string sahib)
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

        private void menkulİnşaOnay_Click(object sender, EventArgs e)
        {
            string selectedValue = listBox1.SelectedItem.ToString();

            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update alan_info set alan_türü  = @tür where alan_no = @no and alan_harita = @harita", connection);
            cmd.Parameters.AddWithValue("tür", selectedValue);
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
                int no = Convert.ToInt32(menkulID2.Text);
                marketAta(menkulHaritaInsa.Text, no);
            }

            MessageBox.Show("işlem başarılı");
        }

        public void marketAta(string harita, int no)
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

        public void magazaAta(string harita, int no)
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

        private void pazarGörüntü_Click(object sender, EventArgs e)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From ürün_info  ", connectionstring);
            DataSet ds = new DataSet();
            dA.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
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
                SqlCommand cmd2 = new SqlCommand("select * from kullanıcı_info where kullanıcı_adı like '" + singleton.oyuncuAd + "'", connection2);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    int para = Convert.ToInt32(dr2["para_miktarı"]);

                    connection2.Close();

                    if (para > fiyat)
                    {
                        satınAlÜrün();
                        ürünsil();
                        yöneticiParaGüncelle(para - fiyat);
                        ürünSahibiBul(sahip, fiyat);

                        MessageBox.Show("işlem başarılı");
                    }
                    else
                    {
                        MessageBox.Show("yeterli paranız bulunmamaktadır");
                    }
                }

            }
        }
        public void satınAlÜrün()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update alan_info set alan_sahibi  =@sahip where alan_no=@id", connection);
            cmd.Parameters.AddWithValue("sahip", singleton.oyuncuAd);
            cmd.Parameters.AddWithValue("id", Convert.ToInt32(ürünID.Text));
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        public void ürünsil()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from ürün_info where ürün_ID  =@id", connection);
            cmd.Parameters.AddWithValue("id", ürünID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void yöneticiParaGüncelle(int yenipara)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update kullanıcı_info set para_miktarı  =@para where yönetici_ad=@ad", connection);
            cmd.Parameters.AddWithValue("para", yenipara);
            cmd.Parameters.AddWithValue("ad", singleton.oyuncuAd);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void ürünSahibiBul(string sahip, int fiyat)
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from yönetici_info where yönetici_ad like '" + sahip + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int para = Convert.ToInt32(dr["yönetici_para"]);
                connection.Close();
                ürünSahibeParaAktar(para, fiyat, sahip);
            }
        }

        public void ürünSahibeParaAktar(int para, int fiyat, string sahip)
        {
            int yenipara = para + fiyat;
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Update yönetici_info set yönetici_para  =@para where yönetici_ad=@ad", connection);
            cmd.Parameters.AddWithValue("para", yenipara);
            cmd.Parameters.AddWithValue("ad", sahip);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void isBasvuruGörüntüle_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;

            SqlConnection connection = connectionstring;
            connection.Open();
            SqlDataAdapter dA = new SqlDataAdapter("Select *From basvuru_info where basvuru_alan_sahip like '" + singleton.oyuncuAd + "'", connectionstring);
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
            cmd.Parameters.AddWithValue("harita", singleton.calısanHarita);
            cmd.Parameters.AddWithValue("ad", singleton.calısanAd);
            cmd.Parameters.AddWithValue("alanNo", singleton.calısanAlanNo);
            cmd.Parameters.AddWithValue("saat", singleton.calısanSaat);
            cmd.Parameters.AddWithValue("ucret", singleton.calısanUcret);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            basvuruSil();
            MessageBox.Show("işlem başarılı");
        }

        public void basvuruDegerBul(int basvuruNo)
        {


            for (int i = 0; i < 100; i++)
            {
                DataGridViewCell cell = dataGridView4.Rows[i].Cells[0];

                if (basvuruNo == Convert.ToInt32(cell.Value))
                {
                    DataGridViewCell cellHarita = dataGridView4.Rows[i].Cells[6];
                    DataGridViewCell cellAd = dataGridView4.Rows[i].Cells[1];
                    DataGridViewCell cellAlanNo = dataGridView4.Rows[i].Cells[5];
                    DataGridViewCell cellSaat = dataGridView4.Rows[i].Cells[2];
                    DataGridViewCell cellUcret = dataGridView4.Rows[i].Cells[3];

                    singleton.calısanAd = cellAd.Value.ToString();
                    singleton.calısanAlanNo = Convert.ToInt32(cellAlanNo.Value);
                    singleton.calısanSaat = Convert.ToInt32(cellSaat.Value);
                    singleton.calısanHarita = cellHarita.Value.ToString();
                    singleton.calısanUcret = Convert.ToInt32(cellUcret.Value);

                    break;
                }
            }
        }
        public void basvuruSil()
        {
            SqlConnection connection = connectionstring;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from basvuru_info where basvuru_no  =@no", connection);
            cmd.Parameters.AddWithValue("no", Convert.ToInt32(basvuruNo.Text));
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void basvuru_pazarlık_Click(object sender, EventArgs e)
        {
            basvuruSil();
            panel6.Visible = true;
        }

        private void basvuruReddet_Click(object sender, EventArgs e)
        {
            basvuruSil();
            MessageBox.Show("işlem başarılı");
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
            cmd.Parameters.AddWithValue("saat", Convert.ToInt32(saatYeni.Text));
            cmd.Parameters.AddWithValue("ucret", Convert.ToInt32(fiyatYeni.Text));
            cmd.Parameters.AddWithValue("alanSahip", singleton.oyuncuAd);
            cmd.Parameters.AddWithValue("alanNo", singleton.calısanAlanNo);
            cmd.Parameters.AddWithValue("alanHarita", singleton.calısanHarita);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("işlem başarılı");
        }
    }
}
