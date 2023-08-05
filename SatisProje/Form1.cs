using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SatisProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Vural\SQLEXPRESS;Initial Catalog=DbSatis;Integrated Security=True");


        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Satis", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void MusteriListele()
        {
            SqlCommand komut5 = new SqlCommand("Select * From MUSTERILER", baglanti);
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            dataGridViewMusteri.DataSource = dt5;
        }

        private void PersonelListele()
        {
            SqlCommand komut = new SqlCommand("Select * From PERSONELLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPersonel.DataSource = dt;
        }

        private void UrunListele()
        {
            SqlCommand komut = new SqlCommand("Select ID,AD, STOK, ALISFIYAT as 'ALIŞ FİYAT', SATISFIYAT as 'SATIŞ FİYAT' From URUNLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUrun.DataSource = dt;
        }

        private void Yenile()
        {
            //Ürünleri Çekme
            SqlCommand komut2 = new SqlCommand("Select * From URUNLER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbUrun.ValueMember = "ID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt2;

            //Müşterileri Çekme
            SqlCommand komut3 = new SqlCommand("Select * From MUSTERILER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DisplayMember = "ADSOYAD";
            CmbMusteri.DataSource = dt3;

            //Personelleri Çekme    
            SqlCommand komut4 = new SqlCommand("Select * From PERSONELLER", baglanti);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbPersonel.ValueMember = "ID";
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.DataSource = dt4;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Satis", baglanti);  // DataAdapter, veritabanı ile arayüz arasında köprü görevi görür.
            DataTable dt = new DataTable();                                   // DataTable, veritabanından gelen verileri tutar.
            da.Fill(dt);                                                     // Fill metodu, veritabanından gelen verileri DataTable'a doldurur.
            dataGridView2.DataSource = dt;

            //Ürünleri Çekme
            SqlCommand komut2 = new SqlCommand("Select * From URUNLER", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmbUrun.ValueMember = "ID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt2;

            //Müşterileri Çekme
            SqlCommand komut3 = new SqlCommand("Select * From MUSTERILER", baglanti);
            SqlDataAdapter da3 = new SqlDataAdapter(komut3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DisplayMember = "ADSOYAD";
            CmbMusteri.DataSource = dt3;

            //Personelleri Çekme    
            SqlCommand komut4 = new SqlCommand("Select * From PERSONELLER", baglanti);
            SqlDataAdapter da4 = new SqlDataAdapter(komut4);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CmbPersonel.ValueMember = "ID";
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.DataSource = dt4;

            //Müşteri İşlemleri Load
            SqlCommand komut5 = new SqlCommand("Select ID, ADSOYAD as 'AD SOYAD' From MUSTERILER", baglanti);
            SqlDataAdapter da5 = new SqlDataAdapter(komut5);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            dataGridViewMusteri.DataSource = dt5;

            //Personel İşlemleri Load
            SqlCommand komut6 = new SqlCommand("Select ID, AD as 'AD SOYAD' From PERSONELLER", baglanti);
            SqlDataAdapter da6 = new SqlDataAdapter(komut6);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);
            dataGridViewPersonel.DataSource = dt6;

            //Ürün İşlemleri Load
            SqlCommand komut7 = new SqlCommand("Select ID,AD, STOK, ALISFIYAT as 'ALIŞ FİYAT', SATISFIYAT as 'SATIŞ FİYAT' From URUNLER", baglanti);
            SqlDataAdapter da7 = new SqlDataAdapter(komut7);
            DataTable dt7 = new DataTable();
            da7.Fill(dt7);
            dataGridViewUrun.DataSource = dt7;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO HAREKETLER (URUN, MUSTERI, PERSONEL, FIYAT) VALUES(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbMusteri.SelectedValue);
            komut.Parameters.AddWithValue("@P3", CmbPersonel.SelectedValue);
            komut.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen satırın bilgilerini comboboxlara aktarma
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            CmbUrun.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            CmbMusteri.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            CmbPersonel.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            //Seçilen satırın bilgilerini güncelleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE HAREKETLER SET URUN=@P1, MUSTERI=@P2, PERSONEL=@P3, FIYAT=@P4 WHERE HAREKETID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbMusteri.SelectedValue);
            komut.Parameters.AddWithValue("@P3", CmbPersonel.SelectedValue);
            komut.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@P5", TxtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
            MessageBox.Show("Satış Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            //Müşteri Ekleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MUSTERILER (ADSOYAD) VALUES(@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMusteriAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Müşteri Eklendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusteriListele();
        }

        private void dataGridViewMusteri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewMusteri.SelectedCells[0].RowIndex;
            TxtMusteriID.Text = dataGridViewMusteri.Rows[secilen].Cells[0].Value.ToString();
            TxtMusteriAd.Text = dataGridViewMusteri.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            //Müşteri Silme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM MUSTERILER WHERE ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Müşteri Silindi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MusteriListele();
        }

        private void BtnMusGuncelle_Click(object sender, EventArgs e)
        {
            //Müşteri Güncelleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE MUSTERILER SET ADSOYAD=@P1 WHERE ID=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMusteriAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtMusteriID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Müşteri Güncellendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MusteriListele();
        }

        private void dataGridViewPersonel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewPersonel.SelectedCells[0].RowIndex;
            TxtPersonelID.Text = dataGridViewPersonel.Rows[secilen].Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridViewPersonel.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnPersonelEkle_Click(object sender, EventArgs e)
        {
            //Personel Ekleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO PERSONELLER (AD) VALUES(@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtPersonelAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Personel Eklendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            // Personel Silme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM PERSONELLER WHERE ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Personel Silindi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListele();
        }

        private void BtnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            // Personel Güncelleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE PERSONELLER SET AD=@P1 WHERE ID=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtPersonelID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Personel Güncellendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            // Ürün Ekleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO URUNLER (AD, STOK, ALISFIYAT, SATISFIYAT) VALUES(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@P2", (TxtUrunAdet.Text));
            komut.Parameters.AddWithValue("@P3", (TxtAlFiyat.Text));
            komut.Parameters.AddWithValue("@P4", (TxtSatFiyat.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Ürün Eklendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListele();
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {
            // Ürün Silme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM URUNLER WHERE ID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Ürün Silindi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            UrunListele();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void dataGridViewUrun_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewUrun.SelectedCells[0].RowIndex;
            TxtUrunID.Text = dataGridViewUrun.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridViewUrun.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunAdet.Text = dataGridViewUrun.Rows[secilen].Cells[2].Value.ToString();
            TxtAlFiyat.Text = dataGridViewUrun.Rows[secilen].Cells[3].Value.ToString();
            TxtSatFiyat.Text = dataGridViewUrun.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            // Ürün Güncelleme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE URUNLER SET AD=@P1, STOK=@P2, ALISFIYAT=@P3, SATISFIYAT=@P4 WHERE ID=@P5", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtUrunAdet.Text);
            komut.Parameters.AddWithValue("@P3", TxtAlFiyat.Text);
            komut.Parameters.AddWithValue("@P4", TxtSatFiyat.Text);
            komut.Parameters.AddWithValue("@P5", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            string message = "Ürün Güncellendi" + Environment.NewLine + "Lütfen sistemi güncelleyin";
            MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListele();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int alisFiyat = Convert.ToInt32(TxtAlFiyat.Text);
            int satisFiyat = Convert.ToInt32(TxtSatFiyat.Text);
            int fark = satisFiyat - alisFiyat;  
            TxtKar.Text = fark.ToString();
        }

    }
}
