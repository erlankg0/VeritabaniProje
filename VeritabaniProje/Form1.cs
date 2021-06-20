using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    //Access Veritabanı Kütüphanesi Tanımlama

namespace VeritabaniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bağlantı Cümleciği
        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb");

        //Veritabanı bağlatısını kontrollü şekilde açan method
        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open(); //Veritabanını Aç
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"Bağlantı Açma Hatası");
            }        
        }

        // Personel KayiListeleme Methodu
        public void KayitListele()
        {
            try
            {
                BaglantiAc();                               // veri tabani ac
                DataSet dataSet = new DataSet();            // dataSet olurturdum
                string Sorgu = "Select * from Personel";     // sql sorgu olusturdum
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(Sorgu, Baglanti); // data adapter olusturduk 
                dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                Baglanti.Close();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Hata Listeleme ");
            }
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            BaglantiAc();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_listeme_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EkleForm ekleForm = new EkleForm();
            ekleForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            KayitListele();
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FormDelete formDelete = new FormDelete();

            formDelete.lbliD.Text = dataGridListele.CurrentRow.Cells[0].Value.ToString();
            formDelete.lblAd.Text = dataGridListele.CurrentRow.Cells[1].Value.ToString();
            formDelete.lblSoyad.Text = dataGridListele.CurrentRow.Cells[2].Value.ToString();
            formDelete.lblTCNO.Text = dataGridListele.CurrentRow.Cells[3].Value.ToString();

            formDelete.ShowDialog(); // Sil Form çığırıldı
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FormGuncelle frmGuncelle = new FormGuncelle();
            frmGuncelle.textBoxİD.Text = dataGridListele.CurrentRow.Cells[0].Value.ToString();
            frmGuncelle.txt_tcno.Text = dataGridListele.CurrentRow.Cells[1].Value.ToString();
            frmGuncelle.txt_ad.Text = dataGridListele.CurrentRow.Cells[2].Value.ToString();
            frmGuncelle.txt_soyad.Text = dataGridListele.CurrentRow.Cells[3].Value.ToString();
            if (dataGridListele.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmGuncelle.rdb_man.Checked = true;
            else
                frmGuncelle.rdb_kadin.Checked = true;
            frmGuncelle.cmb_dyer.Text = dataGridListele.CurrentRow.Cells[5].Value.ToString();
            frmGuncelle.dateTimePicker_doğumGun.Text = dataGridListele.CurrentRow.Cells[6].Value.ToString();
            frmGuncelle.cmb_part.Text = dataGridListele.CurrentRow.Cells[7].Value.ToString();

            frmGuncelle.ShowDialog();


           

        }
    }
}
