using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace VeritabaniProje
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Bu method kulannici login ve password Sl komutla kontrol etip giris yapacak
        /// </summary>
        public void Giris()
        {
            try
            {
                Form1.BaglantiAc();                               // veri tabani ac
                DataSet dataSet = new DataSet();            // dataSet olurturdum


                string SorguAdSoyad = "Select * from Kullanicilar where Kadi='" + txtLogin.Text + "' and Sifre='" + txtPassword.Text + "'";


                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(SorguAdSoyad, Form1.Baglanti); // data adapter olusturduk 

                dbDataAdapter.Fill(dataSet, "Kullanicilar ");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                dataGridView1.DataSource = dataSet.Tables["Kullanicilar "]; // dataset deki veri datagride goster
                Form1.Baglanti.Close();




            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Giriş Hata ");
            }
        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            Giris();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Doğru yazın.");
            }

        }
    }
}
