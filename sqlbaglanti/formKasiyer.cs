using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlbaglanti
{
    public partial class formKasiyer : Form
    {

        SqlConnection conn;
        SqlDataAdapter adpVeri;
        DataTable tblVeri;
        int Id;
        public formKasiyer()
        {
            InitializeComponent();
        }

        private void formKasiyer_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = LAPTOP-2RK95PNO\SQLEXPRESS;Connection Timeout = 300000000; Initial Catalog = PIKSEL_EKIM;User ID = sa; Password = 1; Timeout = 300000000");

            
            KasiyerGetir();
        }

        private void KasiyerGetir()
        {
            lstKasiyer.Items.Clear();
            adpVeri = new SqlDataAdapter("SELECT * FROM KASIYER ", conn);
            tblVeri = new DataTable();
            adpVeri.Fill(tblVeri);
            for (int i = 0; i < tblVeri.Rows.Count; i++)
            {
                lstKasiyer.Items.Add(tblVeri.Rows[i][1].ToString());
            }

        }

        private void lstKasiyer_DoubleClick(object sender, EventArgs e)
        {

            Id = Convert.ToInt32(tblVeri.Rows[lstKasiyer.SelectedIndex][0]);

            this.txtKasiyerAd.Text = tblVeri.Rows[lstKasiyer.SelectedIndex][1].ToString();

            this.txtKasiyerParola.Text = tblVeri.Rows[lstKasiyer.SelectedIndex][2].ToString();

            this.txtKasiyerNo.Text = tblVeri.Rows[lstKasiyer.SelectedIndex][3].ToString();

        }

        private void button_Sil_Click(object sender, EventArgs e)
        {

            SqlCommand cmdSil = new SqlCommand("DELETE FROM URUNLER WHERE ID = ' " + Id + "'", conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdSil.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("kasiyer silindi");
            KasiyerGetir();


        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {

            SqlCommand cmdEkle = new SqlCommand("INSERT INTO KASIYER(KASIYERNO,,KASIYERAD,PAROLA)VALUES (@KASIYERNO,@KASIYERAD,@PAROLA)",conn);
            cmdEkle.Parameters.AddWithValue("@KASIYERNO", txtKasiyerNo.Text);
            cmdEkle.Parameters.AddWithValue("@KASIYERAD", txtKasiyerAd.Text);
            cmdEkle.Parameters.AddWithValue("@PAROLA", Convert.ToDouble(txtKasiyerParola.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdEkle.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("kasiyer eklendi");
            KasiyerGetir();

        }

        private void button_Güncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdGüncelle = new SqlCommand("UPDATE KASIYER SET KASIYERNO = @KASIYERNO,KASIYERAD = @KASIYERAD, PAROLA = @PAROLA, WHERE ID = ' " + Id + "'", conn);
            cmdGüncelle.Parameters.AddWithValue("@KASIYERNO", txtKasiyerNo.Text);
            cmdGüncelle.Parameters.AddWithValue("@KASIYERAD", txtKasiyerAd.Text);
            cmdGüncelle.Parameters.AddWithValue("@PAROLA", Convert.ToDouble(txtKasiyerParola.Text));

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmdGüncelle.ExecuteNonQuery();

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            MessageBox.Show("kasiyer güncellendi");
            KasiyerGetir();
        }
    }
}
