using System;
using System.Data;
using System.Data.OleDb;    //Access Veritabanı Kütüphanesi Tanımlama
using System.Windows.Forms;

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
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hatası");
            }
        }

        // Personel KayiListeleme Methodu
        /// <summary>
        ///  personel tum gosterme
        /// </summary>
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
                MessageBox.Show(Error.Message, "Kayıt arama Hatası ");
            }
        }

        // Kayit Arama method
        public void KayitArama()
        {
            try
            {
                BaglantiAc();                               // veri tabani ac
                DataSet dataSet = new DataSet();            // dataSet olurturdum

                string SorguAD = "Select * from Personel where Ad='" + txtBirArama_Ad.Text + "'";
                string Sorgu = "Select * from Personel where Soyad='" + txtSoyad_arama.Text + "'";
                string SorguAdSoyad = "Select * from Personel where Ad='" + txtBirArama_Ad.Text + "' and Soyad='" + txtSoyad_arama.Text + "'";
                string SorguTum = "Select * from Personel";
                if (chxAD.Checked == true)
                {
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SorguAD, Baglanti); // data adapter olusturduk 
                    dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                    dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                    Baglanti.Close();
                    MessageBox.Show("Ad ile Arama");

                }
                if (chb_soyad.Checked == true)
                {
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(Sorgu, Baglanti); // data adapter olusturduk 

                    dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                    dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                    Baglanti.Close();

                }
                if (chb_Ad_Soyad.Checked == true)
                {
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SorguAdSoyad, Baglanti); // data adapter olusturduk 

                    dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                    dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                    Baglanti.Close();
                }
                else
                {
                    OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SorguTum, Baglanti); // data adapter olusturduk 

                    dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                    dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                    Baglanti.Close();
                }



            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Hata Listeleme ");
            }
        }
        /// <summary>
        ///  Personel tablodaki benzer arama method SQL % Like
        /// </summary>
        public void HizliKayitArama()
        {
            try
            {
                BaglantiAc();                               // veri tabani ac
                DataSet dataSet = new DataSet();            // dataSet olurturdum
                /// SQL TCNO hizli arama
                string SorguTcnoBitten = "Select * from Personel where Tcno Like '%" + textaranan.Text + "'"; // sql bitten
                string SorguTcnoBaslayan = "Select * from Personel where Tcno Like '" + textaranan.Text + "%'"; // sql başlayan
                string SorguTcnoiceren = "Select * from Personel where Tcno Like '%" + textaranan.Text + "%'";

                /// SQL Dogum yer hizli arama methodu
                string SogrguDyerBitten = "Select * from Personel where Dyer Like '%" + textaranan.Text + "'";
                string SorguDyerBaslayan = "Select * from Personel where Dyer Like '" + textaranan.Text + "%'";
                string SorguDyericeren = "Select * from Personel where Dyer Like '%" + textaranan.Text + "%'";

                string SorguTum = "Select * from Personel";

                // Arama turun secme anlami
                if (rdbDyerAra.Checked == true)
                {
                    if (cmbAramaTur.Text == "ile başlayan")
                    {
                        // Dogum yer ... ile baslayan
                        SorguTum = SorguDyerBaslayan;
                        Form1.Baglanti.Close();
                    }
                    else if (cmbAramaTur.Text == "ile bitten")
                    {
                        // Dogum yer ... ile bitten
                        SorguTum = SogrguDyerBitten;
                        Form1.Baglanti.Close();
                    }
                    else if (cmbAramaTur.Text == "içeren")
                    {
                        // Dogum yer ... iceren
                        SorguTum = SorguDyericeren;
                        Form1.Baglanti.Close();
                    }
                    Form1.Baglanti.Close();
                }
                else if (rdbTCNOara.Checked == true)
                {
                    if (cmbAramaTur.Text == "ile başlayan")
                    {
                        // TCNO ... ile baslayan
                        SorguTum = SorguTcnoBaslayan;
                        Form1.Baglanti.Close();
                    }
                    else if (cmbAramaTur.Text == "ile bitten")
                    {
                        // TCNO ... ile bitten
                        SorguTum = SorguTcnoBitten;
                        Form1.Baglanti.Close();
                    }
                    else if (cmbAramaTur.Text == "içeren")
                    {
                        // TCNO ... iceren
                        SorguTum = SorguTcnoiceren;
                        Form1.Baglanti.Close();
                    }
                    Form1.Baglanti.Close();
                }

                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SorguTum, Baglanti); // data adapter olusturduk 
                dbDataAdapter.Fill(dataSet, "Personel");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                dataGridListele.DataSource = dataSet.Tables["Personel"]; // dataset deki veri datagride goster
                Baglanti.Close();

            }
            catch
            {

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

        private void btnBirArama_Click(object sender, EventArgs e)
        {
            KayitArama();
        }

        private void chxAD_CheckedChanged(object sender, EventArgs e)
        {
            if (chxAD.Checked == true)
            {
                txtBirArama_Ad.Enabled = true;
                txtSoyad_arama.Focus();
            }
            else
            {
                txtBirArama_Ad.Enabled = false;
                txtBirArama_Ad.Clear();
            }
        }

        private void chb_soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_soyad.Checked == true)
            {
                txtSoyad_arama.Enabled = true;
                txtSoyad_arama.Focus();
            }
            else
            {
                txtSoyad_arama.Enabled = false;
                txtSoyad_arama.Clear();
            }
        }

        private void chb_Ad_Soyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_Ad_Soyad.Checked == true)
            {
                txtBirArama_Ad.Enabled = true;
                txtSoyad_arama.Enabled = true;
                txtSoyad_arama.Focus();
                txtBirArama_Ad.Focus();
            }
            else
            {
                txtSoyad_arama.Enabled = false;
                txtSoyad_arama.Clear();
                txtBirArama_Ad.Enabled = false;
                txtBirArama_Ad.Clear();
            }
        }

        private void rdbDyerAra_CheckedChanged(object sender, EventArgs e)
        {
            arama_alan.Text = "Doğum yer";
            arama_alan.Focus();
        }

        private void rdbTCNOara_CheckedChanged(object sender, EventArgs e)
        {
            arama_alan.Text = "TCNO";
            arama_alan.Focus();
        }

        private void textaranan_TextChanged(object sender, EventArgs e)
        {
            HizliKayitArama();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelForm personelForm = new PersonelForm();
            personelForm.ShowDialog();
        }
    }
}
