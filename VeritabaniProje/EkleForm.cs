using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txt_tcno.BackColor = Color.White;
            txt_ad.BackColor = Color.White;
            txt_soyad.BackColor = Color.White;
            cmb_dyer.BackColor = Color.White;
            cmb_part.BackColor = Color.White;

            if (txt_tcno.Text == "")
            {
                txt_tcno.BackColor = Color.Red;
                
            }
            if (txt_ad.Text == "")
            {
                txt_ad.BackColor = Color.Red;
               
            }
            if (txt_soyad.Text == "")
            {
                txt_soyad.BackColor = Color.Red;
              
            }
            if (cmb_dyer.Text == "" || cmb_dyer.Text == "Seçiniz")
            {
                cmb_dyer.BackColor = Color.Red;
     
            }
            if (cmb_part.Text == "" || cmb_dyer.Text == "Seçiniz")
            {
                cmb_part.BackColor = Color.Red;
      
            }
            if (rdb_kadin.Checked == false && rdb_man.Checked == false)
            {
                rdb_kadin.BackColor = Color.Red;
                rdb_man.BackColor = Color.Red;
                
            }
        }
        private void btn_kayit_ekle_Click(object sender, EventArgs e)
        {
            Kayitekle();
        }
    }
}
