using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VeritabaniProje
{
    public partial class FormGuncelle : Form
    {
        public FormGuncelle()
        {
            InitializeComponent();
        }
       
        public bool BoslukKontrol()
        {
            bool kontrol = true;

            //// Kırımıza değiştirme için
            txt_tcno.BackColor = Color.White;
            txt_ad.BackColor = Color.White;
            txt_soyad.BackColor = Color.White;



            if (txt_tcno.Text == "")
            {
                txt_tcno.BackColor = Color.Red;
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            if (txt_ad.Text == "")
            {
                txt_ad.BackColor = Color.Red;
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            if (txt_soyad.Text == "")
            {
                txt_soyad.BackColor = Color.Red;
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            if (cmb_dyer.Text == "" || cmb_dyer.Text == "Seçiniz")
            {
                lbldyerchek.Visible = true;
                kontrol = true;

            }
            else
            {
                kontrol = false;
            }
            if (cmb_part.Text == "" || cmb_dyer.Text == "Seçiniz")
            {
                lblpartchek.Visible = true;
                kontrol = true;

            }
            else
            {
                kontrol = false;
            }
            if (rdb_kadin.Checked == false && rdb_man.Checked == false)
            {
                lblradio.Visible = true;
                kontrol = true;
            }
            else
            {
                kontrol = false;
            }
            return kontrol;
        }
        public void KayitGuncelle()
        {
            try
            {
                Form1.BaglantiAc();         //Veritabanını aç
                string Sorgu = "Update Personel Set Tcno=@Tcno,Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,Dyer=@Dyer,Dtar=@Dtar,Bolum=@Bolum where id=@ID";

                OleDbCommand GuncelleKomut = new OleDbCommand(Sorgu, Form1.Baglanti);

                GuncelleKomut.Parameters.AddWithValue("@Tcno", txt_tcno.Text);
                GuncelleKomut.Parameters.AddWithValue("@Ad", txt_ad.Text);
                GuncelleKomut.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
                if (rdb_man.Checked == true)
                    GuncelleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else
                    GuncelleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                GuncelleKomut.Parameters.AddWithValue("@Dyer", cmb_dyer.Text);
                GuncelleKomut.Parameters.AddWithValue("@Dtar", dateTimePicker_doğumGun.Text);
                GuncelleKomut.Parameters.AddWithValue("@Bolum", cmb_part.Text);
                GuncelleKomut.Parameters.AddWithValue("@ID", textBoxİD.Text);

                if (GuncelleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Güncelleme Hatası ");
            }
        }
        private void btnFormGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                MessageBox.Show("Boşluk doldurunuz");
            }
            else
            {
                KayitGuncelle();
                Form1.Baglanti.Close();
            }
           

        }
    }
}
