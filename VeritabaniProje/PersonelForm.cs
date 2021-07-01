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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void KayitListele()
        {
            try
            {
                Form1.BaglantiAc();                               // veri tabani ac
                DataSet dataSet = new DataSet();            // dataSet olurturdum
                string Sorgu = "Select * from Kullanicilar";     // sql sorgu olusturdum
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(Sorgu, Form1.Baglanti); // data adapter olusturduk 
                dbDataAdapter.Fill(dataSet, "Kullanicilar");  // datasete  Personel ile doldurduk,  adapter ile ama goremioyruz(yani copy var)
                dataPersonelForm.DataSource = dataSet.Tables["Kullanicilar"]; // dataset deki veri datagride goster
                Form1.Baglanti.Close();

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Kullanici Listeleme ");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            lblstatusLogin.Text = dataPersonelForm.CurrentRow.Cells[1].Value.ToString();
            lblstatusType.Text = dataPersonelForm.CurrentRow.Cells[3].Value.ToString();
            KayitListele();
        }
    }
}
