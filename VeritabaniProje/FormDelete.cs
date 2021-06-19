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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        public void KayitSil()
        {
            try
            {
                Form1.BaglantiAc();
                string SorguDelet = "Delete From Personel Where id=" + lbliD.Text;
                OleDbCommand oleDbCommand = new OleDbCommand(SorguDelet, Form1.Baglanti);
                if (oleDbCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt silindi.");
                    Form1.Baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt silinmedi.");
                    Form1.Baglanti.Close();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.ToString(), "Hata");
                Form1.Baglanti.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            KayitSil();
        }
    }
}
