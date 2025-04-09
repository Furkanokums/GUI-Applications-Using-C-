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

namespace sqlbaglanti
{
    public partial class sqlbaglanti : Form
    {
        private DataTable tblVeri;
        private SqlDataAdapter adpVeri;
        SqlConnection conn;
        public sqlbaglanti()
        {
            InitializeComponent();
        }

        private void sqlbaglanti_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = LAPTOP-2RK95PNO\SQLEXPRESS;Connection Timeout = 300000000; Initial Catalog = PIKSEL_EKIM;User ID = sa; Password = 1; Timeout = 300000000");

            adpVeri = new SqlDataAdapter("SELECT * FROM URUNLER", conn); 
            tblVeri = new DataTable();
            adpVeri.Fill(tblVeri);

            for (int i = 0; i < tblVeri.Rows.Count; i++)
            {
                chkMalzemeler.Items.Add(tblVeri.Rows[i][2].ToString());
            }
        }

        private void button_Gönder_Click(object sender, EventArgs e)
        {
            txtMalzemeAd.Text = chkMalzemeler.SelectedItem.ToString();

            txtMalzemeId.Text = tblVeri.Rows[chkMalzemeler.SelectedIndex][0].ToString();

            txtMalzemeKod.Text = tblVeri.Rows[chkMalzemeler.SelectedIndex][1].ToString();

            txtMalzemeAlışFiyat.Text = tblVeri.Rows[chkMalzemeler.SelectedIndex][3].ToString();

            txtMalzemeSatışFiyat.Text = tblVeri.Rows[chkMalzemeler.SelectedIndex][4].ToString();
        }

        private void button_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdGüncelle = new SqlCommand("UPDATE URUNLER SET URUNKOD = @URUNKOD,URUNAD = @URUNAD, ALISFIYAT = @ALISFIYAT, SATISFIYAT = @SATISFIYAT WHERE ID = ' " + txtMalzemeId.Text + "'", conn);
            cmdGüncelle.Parameters.AddWithValue("@URUNKOD", txtMalzemeKod.Text);
            cmdGüncelle.Parameters.AddWithValue("@URUNAD", txtMalzemeAd.Text);
            cmdGüncelle.Parameters.AddWithValue("@ALISFIYAT",Convert.ToDouble(txtMalzemeAlışFiyat.Text));
            cmdGüncelle.Parameters.AddWithValue("@SATISFIYAT", Convert.ToDouble(txtMalzemeSatışFiyat.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdGüncelle.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("ürün güncellendi");
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {

            SqlCommand cmdSil = new SqlCommand("DELETE FROM URUNLER WHERE ID = ' " + txtMalzemeId.Text + "'", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdSil.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("ürün silindi");
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("INSERT INTO URUNLER(URUNKOD,URUNAD,ALISFIYAT,SATISFIYAT) VALUES (@URUNKOD,@URUNAD,@ALISFIYAT,@SATISFIYAT)");
            cmdEkle.Parameters.AddWithValue("@URUNKOD", txtMalzemeKod.Text);
            cmdEkle.Parameters.AddWithValue("@URUNAD", txtMalzemeAd.Text);
            cmdEkle.Parameters.AddWithValue("@ALISFIYAT", Convert.ToDouble(txtMalzemeAlışFiyat.Text));
            cmdEkle.Parameters.AddWithValue("@SATISFIYAT", Convert.ToDouble(txtMalzemeSatışFiyat.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdEkle.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("ürün eklendi");
        }
    }
    
}



