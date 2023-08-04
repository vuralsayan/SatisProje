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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbSatisDataSet.Satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.dbSatisDataSet.Satis);

            SqlDataAdapter da = new SqlDataAdapter("Execute Satis",baglanti); // DataAdapter, veritabanı ile arayüz arasında köprü görevi görür.
            DataTable dt = new DataTable();                // DataTable, veritabanından gelen verileri tutar.
            da.Fill(dt);                                    // Fill metodu, veritabanından gelen verileri DataTable'a doldurur.
            dataGridView2.DataSource = dt;
        }
    }
}
