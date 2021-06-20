
namespace VeritabaniProje
{
    partial class EkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker_doğumGun = new System.Windows.Forms.DateTimePicker();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_dyer = new System.Windows.Forms.Label();
            this.lbl_part = new System.Windows.Forms.Label();
            this.lbl_dtarih = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.rdb_kadin = new System.Windows.Forms.RadioButton();
            this.rdb_man = new System.Windows.Forms.RadioButton();
            this.cmb_dyer = new System.Windows.Forms.ComboBox();
            this.cmb_part = new System.Windows.Forms.ComboBox();
            this.txt_tcno = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpartchek = new System.Windows.Forms.Label();
            this.lbldyerchek = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.btn_kayit_ekle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_doğumGun
            // 
            this.dateTimePicker_doğumGun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_doğumGun.Location = new System.Drawing.Point(77, 158);
            this.dateTimePicker_doğumGun.Name = "dateTimePicker_doğumGun";
            this.dateTimePicker_doğumGun.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_doğumGun.TabIndex = 4;
            this.dateTimePicker_doğumGun.Value = new System.DateTime(2021, 6, 20, 17, 58, 49, 0);
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(9, 10);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(37, 13);
            this.lbl_tcno.TabIndex = 0;
            this.lbl_tcno.Text = "TCNO";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(9, 35);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(9, 59);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(37, 13);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(9, 83);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(51, 13);
            this.lbl_sex.TabIndex = 0;
            this.lbl_sex.Text = "Cinsiniyet";
            // 
            // lbl_dyer
            // 
            this.lbl_dyer.AutoSize = true;
            this.lbl_dyer.Location = new System.Drawing.Point(9, 107);
            this.lbl_dyer.Name = "lbl_dyer";
            this.lbl_dyer.Size = new System.Drawing.Size(58, 13);
            this.lbl_dyer.TabIndex = 0;
            this.lbl_dyer.Text = "Doğum yer";
            // 
            // lbl_part
            // 
            this.lbl_part.AutoSize = true;
            this.lbl_part.Location = new System.Drawing.Point(9, 134);
            this.lbl_part.Name = "lbl_part";
            this.lbl_part.Size = new System.Drawing.Size(36, 13);
            this.lbl_part.TabIndex = 0;
            this.lbl_part.Text = "Bölüm";
            // 
            // lbl_dtarih
            // 
            this.lbl_dtarih.AutoSize = true;
            this.lbl_dtarih.Location = new System.Drawing.Point(9, 158);
            this.lbl_dtarih.Name = "lbl_dtarih";
            this.lbl_dtarih.Size = new System.Drawing.Size(70, 13);
            this.lbl_dtarih.TabIndex = 0;
            this.lbl_dtarih.Text = "Doğum Tarihi";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(76, 36);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(76, 62);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // rdb_kadin
            // 
            this.rdb_kadin.AutoSize = true;
            this.rdb_kadin.Location = new System.Drawing.Point(130, 85);
            this.rdb_kadin.Name = "rdb_kadin";
            this.rdb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rdb_kadin.TabIndex = 2;
            this.rdb_kadin.TabStop = true;
            this.rdb_kadin.Text = "Kadın";
            this.rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // rdb_man
            // 
            this.rdb_man.AutoSize = true;
            this.rdb_man.Location = new System.Drawing.Point(76, 85);
            this.rdb_man.Name = "rdb_man";
            this.rdb_man.Size = new System.Drawing.Size(53, 17);
            this.rdb_man.TabIndex = 2;
            this.rdb_man.TabStop = true;
            this.rdb_man.Text = "Erkek";
            this.rdb_man.UseVisualStyleBackColor = true;
            // 
            // cmb_dyer
            // 
            this.cmb_dyer.FormattingEnabled = true;
            this.cmb_dyer.Items.AddRange(new object[] {
            "Ankara",
            "Antalya",
            "Adana",
            "Bişkek",
            "Oş",
            "Tokmok",
            "Kastamonu",
            "Karabuk",
            "Alanya"});
            this.cmb_dyer.Location = new System.Drawing.Point(77, 106);
            this.cmb_dyer.Name = "cmb_dyer";
            this.cmb_dyer.Size = new System.Drawing.Size(121, 21);
            this.cmb_dyer.TabIndex = 3;
            this.cmb_dyer.Text = "Seçiniz";
            // 
            // cmb_part
            // 
            this.cmb_part.FormattingEnabled = true;
            this.cmb_part.Items.AddRange(new object[] {
            "Mimar",
            "Tıp",
            "Mühendislik",
            "Şöför",
            "Öğretmen",
            "Uykucu"});
            this.cmb_part.Location = new System.Drawing.Point(77, 133);
            this.cmb_part.Name = "cmb_part";
            this.cmb_part.Size = new System.Drawing.Size(121, 21);
            this.cmb_part.TabIndex = 3;
            this.cmb_part.Text = "Seçiniz";
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(77, 10);
            this.txt_tcno.Mask = "00000000000";
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(100, 20);
            this.txt_tcno.TabIndex = 5;
            this.txt_tcno.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblpartchek);
            this.groupBox2.Controls.Add(this.lbldyerchek);
            this.groupBox2.Controls.Add(this.lblradio);
            this.groupBox2.Controls.Add(this.txt_tcno);
            this.groupBox2.Controls.Add(this.dateTimePicker_doğumGun);
            this.groupBox2.Controls.Add(this.cmb_part);
            this.groupBox2.Controls.Add(this.cmb_dyer);
            this.groupBox2.Controls.Add(this.rdb_man);
            this.groupBox2.Controls.Add(this.rdb_kadin);
            this.groupBox2.Controls.Add(this.txt_soyad);
            this.groupBox2.Controls.Add(this.txt_ad);
            this.groupBox2.Controls.Add(this.lbl_dtarih);
            this.groupBox2.Controls.Add(this.lbl_part);
            this.groupBox2.Controls.Add(this.lbl_dyer);
            this.groupBox2.Controls.Add(this.lbl_sex);
            this.groupBox2.Controls.Add(this.lbl_soyad);
            this.groupBox2.Controls.Add(this.lbl_ad);
            this.groupBox2.Controls.Add(this.lbl_tcno);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "f";
            // 
            // lblpartchek
            // 
            this.lblpartchek.AutoSize = true;
            this.lblpartchek.ForeColor = System.Drawing.Color.Red;
            this.lblpartchek.Location = new System.Drawing.Point(204, 136);
            this.lblpartchek.Name = "lblpartchek";
            this.lblpartchek.Size = new System.Drawing.Size(22, 13);
            this.lblpartchek.TabIndex = 6;
            this.lblpartchek.Text = "///";
            this.lblpartchek.Visible = false;
            // 
            // lbldyerchek
            // 
            this.lbldyerchek.AutoSize = true;
            this.lbldyerchek.ForeColor = System.Drawing.Color.Red;
            this.lbldyerchek.Location = new System.Drawing.Point(204, 107);
            this.lbldyerchek.Name = "lbldyerchek";
            this.lbldyerchek.Size = new System.Drawing.Size(22, 13);
            this.lbldyerchek.TabIndex = 6;
            this.lbldyerchek.Text = "///";
            this.lbldyerchek.Visible = false;
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.ForeColor = System.Drawing.Color.Red;
            this.lblradio.Location = new System.Drawing.Point(188, 87);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(22, 13);
            this.lblradio.TabIndex = 6;
            this.lblradio.Text = "///";
            this.lblradio.Visible = false;
            // 
            // btn_kayit_ekle
            // 
            this.btn_kayit_ekle.Location = new System.Drawing.Point(12, 222);
            this.btn_kayit_ekle.Name = "btn_kayit_ekle";
            this.btn_kayit_ekle.Size = new System.Drawing.Size(285, 39);
            this.btn_kayit_ekle.TabIndex = 8;
            this.btn_kayit_ekle.Text = "Kayıt Ekle.";
            this.btn_kayit_ekle.UseVisualStyleBackColor = true;
            this.btn_kayit_ekle.Click += new System.EventHandler(this.btn_kayit_ekle_Click);
            // 
            // EkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 290);
            this.Controls.Add(this.btn_kayit_ekle);
            this.Controls.Add(this.groupBox2);
            this.Name = "EkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EkleForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_doğumGun;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_dyer;
        private System.Windows.Forms.Label lbl_part;
        private System.Windows.Forms.Label lbl_dtarih;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.RadioButton rdb_kadin;
        private System.Windows.Forms.RadioButton rdb_man;
        private System.Windows.Forms.ComboBox cmb_dyer;
        private System.Windows.Forms.ComboBox cmb_part;
        private System.Windows.Forms.MaskedTextBox txt_tcno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_kayit_ekle;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.Label lblpartchek;
        private System.Windows.Forms.Label lbldyerchek;
    }
}