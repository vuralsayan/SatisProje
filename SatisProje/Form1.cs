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


        private void Yenile()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Satis", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Satis",baglanti);  // DataAdapter, veritabanı ile arayüz arasında köprü görevi görür.
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

            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO HAREKETLER (URUN, MUSTERI, PERSONEL, FIYAT) VALUES(@P1,@P2,@P3,@P4)",baglanti);
            komut.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbMusteri.SelectedValue);
            komut.Parameters.AddWithValue("@P3", CmbPersonel.SelectedValue);
            komut.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Yenile();
        }
    }
}
 