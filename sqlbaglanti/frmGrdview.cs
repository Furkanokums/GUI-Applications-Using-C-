using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlbaglanti
{
    public partial class frmGrdview : Form
    {
        SqlConnection conn;
        SqlDataAdapter adpVeri;
        DataTable tblVeri;

        public frmGrdview()
        {
            InitializeComponent();
        }

        private void frmGrdview_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(
                @"Data Source = LAPTOP-2RK95PNO\SQLEXPRESS;Connection Timeout = 300000000; Initial Catalog = PIKSEL_EKIM;User ID = sa; Password = 1; Timeout = 300000000");
            VeriGetir(dateTimeTarih.Value, dateTimeTarihBitiş.Value);
        }


        private void VeriGetir(DateTime başTarih, DateTime bitişTarih)
        {
            adpVeri = new SqlDataAdapter(
                "SELECT KS.KASIYERNO,KS.KASIYERAD,ST.TARIH,ST.URUNAD,ST.MIKTAR,ST.FIYAT,ST.TUTAR,[FATURA TİP]=CASE WHEN FATURAID=1  THEN 'ALIŞ FATURASI' ELSE 'SATIŞ FATURASI' END FROM SATIS ST INNER JOIN KASIYER KS ON KS.ID=ST.KASIYERID WHERE ST.TARIH >= CONVERT(DATETIME,' " +
                başTarih + " ' ,104) AND ST.TARIH <= CONVERT(DATETIME,' " + bitişTarih + " ' ,104) ", conn);
            tblVeri = new DataTable();
            adpVeri.Fill(tblVeri);
            this.grdVeri.DataSource = tblVeri;
            this.grdVeri.Columns[0].Width = 200;
            this.grdVeri.Columns[1].Width = 200;
            this.grdVeri.Columns[2].Width = 200;
            this.grdVeri.Columns[7].Width = 200;
            this.grdVeri.Columns[0].Visible = false;

        }


        private void button_Güncelle_Click(object sender, EventArgs e)
        {



        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {



        }

        private void button_Sil_Click(object sender, EventArgs e)
        {


        }


        private void grdVeri_DoubleClick(object sender, EventArgs e)
        {
            txtUrunAd.Text = grdVeri.CurrentRow.Cells["URUNAD"].Value.ToString();
            dateTimeTarih.Value = Convert.ToDateTime((grdVeri.CurrentRow.Cells["TARIH"].Value));
            dateTimeTarihBitiş.Value = Convert.ToDateTime((grdVeri.CurrentRow.Cells["TARIH"].Value));
        }



        private void button_Getir_Click(object sender, EventArgs e)
        {
            VeriGetir(dateTimeTarih.Value, dateTimeTarihBitiş.Value);
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            Excel_Disa_Aktar(grdVeri);
        }

        private void Excel_Disa_Aktar(DataGridView dataGridView)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "Excel Dosyaları";
            save.DefaultExt = "xlsx";
            save.Filter = "xlsx Dosyaları (.xlsx)|.xlsx|Tüm Dosyalar(.)|.";

            if (save.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sayfa1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Satış Raporu";
                for (int i = 1; i < grdVeri.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = grdVeri.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < grdVeri.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grdVeri.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdVeri.Rows[i].Cells[j].Value;
                    }
                }

                workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);
                app.Quit();
            }
        }

        private void button_Excel_Oku_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "*.xlsx";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=Excel 12.0;");
                conn.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM [Satış Raporu$]", conn);
                System.Data.DataTable tbl = new System.Data.DataTable();
                adp.Fill(tbl);
                conn.Close();
                this.grdVeri.DataSource = tbl;
                this.grdVeri.Columns[0].Width = 200;
                this.grdVeri.Columns[1].Width = 200;
                this.grdVeri.Columns[2].Width = 200;
                this.grdVeri.Columns[7].Width = 200;
            }
        }
    }
}
