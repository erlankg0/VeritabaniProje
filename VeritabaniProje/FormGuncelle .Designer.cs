
namespace VeritabaniProje
{
    partial class FormGuncelle
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblpartchek = new System.Windows.Forms.Label();
            this.lbldyerchek = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.txt_tcno = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker_doğumGun = new System.Windows.Forms.DateTimePicker();
            this.cmb_part = new System.Windows.Forms.ComboBox();
            this.cmb_dyer = new System.Windows.Forms.ComboBox();
            this.rdb_man = new System.Windows.Forms.RadioButton();
            this.rdb_kadin = new System.Windows.Forms.RadioButton();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_dtarih = new System.Windows.Forms.Label();
            this.lbl_part = new System.Windows.Forms.Label();
            this.lbl_dyer = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_tcno = new System.Windows.Forms.Label();
            this.lblGunİD = new System.Windows.Forms.Label();
            this.textBoxİD = new System.Windows.Forms.TextBox();
            this.btnFormGuncelle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.textBoxİD);
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
            this.groupBox2.Controls.Add(this.lblGunİD);
            this.groupBox2.Controls.Add(this.lbl_tcno);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 234);
            this.groupBox2.TabIndex = 8;
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
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(77, 44);
            this.txt_tcno.Mask = "00000000000";
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(100, 20);
            this.txt_tcno.TabIndex = 5;
            this.txt_tcno.ValidatingType = typeof(int);
            // 
            // dateTimePicker_doğumGun
            // 
            this.dateTimePicker_doğumGun.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_doğumGun.Location = new System.Drawing.Point(77, 192);
            this.dateTimePicker_doğumGun.Name = "dateTimePicker_doğumGun";
            this.dateTimePicker_doğumGun.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_doğumGun.TabIndex = 4;
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
            this.cmb_part.Location = new System.Drawing.Point(77, 167);
            this.cmb_part.Name = "cmb_part";
            this.cmb_part.Size = new System.Drawing.Size(121, 21);
            this.cmb_part.TabIndex = 3;
            this.cmb_part.Text = "Seçiniz";
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
            this.cmb_dyer.Location = new System.Drawing.Point(77, 140);
            this.cmb_dyer.Name = "cmb_dyer";
            this.cmb_dyer.Size = new System.Drawing.Size(121, 21);
            this.cmb_dyer.TabIndex = 3;
            this.cmb_dyer.Text = "Seçiniz";
            // 
            // rdb_man
            // 
            this.rdb_man.AutoSize = true;
            this.rdb_man.Location = new System.Drawing.Point(76, 119);
            this.rdb_man.Name = "rdb_man";
            this.rdb_man.Size = new System.Drawing.Size(53, 17);
            this.rdb_man.TabIndex = 2;
            this.rdb_man.TabStop = true;
            this.rdb_man.Text = "Erkek";
            this.rdb_man.UseVisualStyleBackColor = true;
            // 
            // rdb_kadin
            // 
            this.rdb_kadin.AutoSize = true;
            this.rdb_kadin.Location = new System.Drawing.Point(130, 119);
            this.rdb_kadin.Name = "rdb_kadin";
            this.rdb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rdb_kadin.TabIndex = 2;
            this.rdb_kadin.TabStop = true;
            this.rdb_kadin.Text = "Kadın";
            this.rdb_kadin.UseVisualStyleBackColor = true;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(76, 96);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 20);
            this.txt_soyad.TabIndex = 1;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(76, 70);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // lbl_dtarih
            // 
            this.lbl_dtarih.AutoSize = true;
            this.lbl_dtarih.Location = new System.Drawing.Point(9, 192);
            this.lbl_dtarih.Name = "lbl_dtarih";
            this.lbl_dtarih.Size = new System.Drawing.Size(70, 13);
            this.lbl_dtarih.TabIndex = 0;
            this.lbl_dtarih.Text = "Doğum Tarihi";
            // 
            // lbl_part
            // 
            this.lbl_part.AutoSize = true;
            this.lbl_part.Location = new System.Drawing.Point(9, 168);
            this.lbl_part.Name = "lbl_part";
            this.lbl_part.Size = new System.Drawing.Size(36, 13);
            this.lbl_part.TabIndex = 0;
            this.lbl_part.Text = "Bölüm";
            // 
            // lbl_dyer
            // 
            this.lbl_dyer.AutoSize = true;
            this.lbl_dyer.Location = new System.Drawing.Point(9, 141);
            this.lbl_dyer.Name = "lbl_dyer";
            this.lbl_dyer.Size = new System.Drawing.Size(58, 13);
            this.lbl_dyer.TabIndex = 0;
            this.lbl_dyer.Text = "Doğum yer";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(9, 117);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(51, 13);
            this.lbl_sex.TabIndex = 0;
            this.lbl_sex.Text = "Cinsiniyet";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(9, 93);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(37, 13);
            this.lbl_soyad.TabIndex = 0;
            this.lbl_soyad.Text = "Soyad";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(9, 69);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(20, 13);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Ad";
            // 
            // lbl_tcno
            // 
            this.lbl_tcno.AutoSize = true;
            this.lbl_tcno.Location = new System.Drawing.Point(9, 44);
            this.lbl_tcno.Name = "lbl_tcno";
            this.lbl_tcno.Size = new System.Drawing.Size(37, 13);
            this.lbl_tcno.TabIndex = 0;
            this.lbl_tcno.Text = "TCNO";
            // 
            // lblGunİD
            // 
            this.lblGunİD.AutoSize = true;
            this.lblGunİD.Location = new System.Drawing.Point(9, 20);
            this.lblGunİD.Name = "lblGunİD";
            this.lblGunİD.Size = new System.Drawing.Size(18, 13);
            this.lblGunİD.TabIndex = 0;
            this.lblGunİD.Text = "İD";
            // 
            // textBoxİD
            // 
            this.textBoxİD.Enabled = false;
            this.textBoxİD.Location = new System.Drawing.Point(77, 20);
            this.textBoxİD.Name = "textBoxİD";
            this.textBoxİD.Size = new System.Drawing.Size(47, 20);
            this.textBoxİD.TabIndex = 7;
            // 
            // btnFormGuncelle
            // 
            this.btnFormGuncelle.Location = new System.Drawing.Point(12, 253);
            this.btnFormGuncelle.Name = "btnFormGuncelle";
            this.btnFormGuncelle.Size = new System.Drawing.Size(285, 42);
            this.btnFormGuncelle.TabIndex = 9;
            this.btnFormGuncelle.Text = "Kayıt Guncelle";
            this.btnFormGuncelle.UseVisualStyleBackColor = true;
            this.btnFormGuncelle.Click += new System.EventHandler(this.btnFormGuncelle_Click);
            // 
            // FormGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(314, 307);
            this.Controls.Add(this.btnFormGuncelle);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellme Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_dtarih;
        private System.Windows.Forms.Label lbl_part;
        private System.Windows.Forms.Label lbl_dyer;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_tcno;
        private System.Windows.Forms.Label lblGunİD;
        private System.Windows.Forms.Button btnFormGuncelle;
        public System.Windows.Forms.Label lblpartchek;
        public System.Windows.Forms.Label lbldyerchek;
        public System.Windows.Forms.Label lblradio;
        public System.Windows.Forms.MaskedTextBox txt_tcno;
        public System.Windows.Forms.DateTimePicker dateTimePicker_doğumGun;
        public System.Windows.Forms.ComboBox cmb_part;
        public System.Windows.Forms.ComboBox cmb_dyer;
        public System.Windows.Forms.RadioButton rdb_man;
        public System.Windows.Forms.RadioButton rdb_kadin;
        public System.Windows.Forms.TextBox txt_soyad;
        public System.Windows.Forms.TextBox txt_ad;
        public System.Windows.Forms.TextBox textBoxİD;
    }
}