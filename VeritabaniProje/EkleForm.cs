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
    public partial class EkleForm : Form
    {
        public EkleForm()
        {
            InitializeComponent();
        }        

        public void Kayitekle()
        {
            
            ///Sql sorgular
            try
            {
                Form1.BaglantiAc(); /// baglanti actim
                string Sorgu = "Insert Into Personel(Tcno, Ad, Soyad, Cinsiyet, Dyer, Dtar, Bolum) Values(@Tcno, @Ad, @Soyad, @Cinsiyet, @Dyer, @Dtar, @Bolum)"; /// Kayit ekleme SQl Sorgu

                OleDbCommand oleDbCommand = new OleDbCommand(Sorgu, Form1.Baglanti); /// commnatd olusturdum
                oleDbCommand.Parameters.AddWithValue("@Tcno", txt_tcno.Text);
                oleDbCommand.Parameters.AddWithValue("@Ad", txt_ad.Text);
                oleDbCommand.Parameters.AddWithValue("@Soyad", txt_soyad.Text);
                if (rdb_kadin.Checked == true)
                {
                    oleDbCommand.Parameters.AddWithValue("@Cinsiyet", rdb_kadin.Text);

                }
                else
                {
                    oleDbCommand.Parameters.AddWithValue("@Cinsiyet", rdb_man.Text);
                }
                oleDbCommand.Parameters.AddWithValue("@Dyer", cmb_dyer.Text);
                oleDbCommand.Parameters.AddWithValue("@Dtar", dateTimePicker_doğumGun);
                oleDbCommand.Parameters.AddWithValue("@Bolum", cmb_part.Text);

                if (oleDbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Eklendi.");
                    Form1.Baglanti.Close();
                }
               
            }
            catch (Exception Error)
            {
                MessageBox.Show("Kayit Hatasi", Error.ToString());
                Form1.Baglanti.Close();

            }
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
        private void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                MessageBox.Show("Boşluk doldurunuz Kayıt yapılamaz");
            }
            else
            {
                Kayitekle();
            }
        }
    }
}
