namespace VeritabaniProje
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.btn_listeme = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_tum = new System.Windows.Forms.CheckBox();
            this.chb_Ad_Soyad = new System.Windows.Forms.CheckBox();
            this.chb_soyad = new System.Windows.Forms.CheckBox();
            this.chxAD = new System.Windows.Forms.CheckBox();
            this.btnBirArama = new System.Windows.Forms.Button();
            this.txtSoyad_arama = new System.Windows.Forms.TextBox();
            this.txtBirArama_Ad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.arama_alan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbDyerAra = new System.Windows.Forms.RadioButton();
            this.rdbTCNOara = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAramaTur = new System.Windows.Forms.ComboBox();
            this.textaranan = new System.Windows.Forms.TextBox();
            this.btnbilgiislem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güvenlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridListele
            // 
            this.dataGridListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridListele.Location = new System.Drawing.Point(12, 27);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListele.Size = new System.Drawing.Size(577, 304);
            this.dataGridListele.TabIndex = 2;
            this.dataGridListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_listeme
            // 
            this.btn_listeme.Location = new System.Drawing.Point(14, 336);
            this.btn_listeme.Name = "btn_listeme";
            this.btn_listeme.Size = new System.Drawing.Size(75, 40);
            this.btn_listeme.TabIndex = 3;
            this.btn_listeme.Text = "Listeleme";
            this.btn_listeme.UseVisualStyleBackColor = true;
            this.btn_listeme.Click += new System.EventHandler(this.btn_listeme_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(95, 336);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 40);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Kayıt Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(177, 337);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(81, 39);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Kayıt Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(264, 337);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(84, 39);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Kayıt güncelle ";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chb_tum);
            this.groupBox1.Controls.Add(this.chb_Ad_Soyad);
            this.groupBox1.Controls.Add(this.chb_soyad);
            this.groupBox1.Controls.Add(this.chxAD);
            this.groupBox1.Controls.Add(this.btnBirArama);
            this.groupBox1.Controls.Add(this.txtSoyad_arama);
            this.groupBox1.Controls.Add(this.txtBirArama_Ad);
            this.groupBox1.Location = new System.Drawing.Point(595, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bire bir Arama";
            // 
            // chb_tum
            // 
            this.chb_tum.AutoSize = true;
            this.chb_tum.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_tum.Location = new System.Drawing.Point(7, 128);
            this.chb_tum.Name = "chb_tum";
            this.chb_tum.Size = new System.Drawing.Size(65, 26);
            this.chb_tum.TabIndex = 5;
            this.chb_tum.Text = "Tüm";
            this.chb_tum.UseVisualStyleBackColor = true;
            // 
            // chb_Ad_Soyad
            // 
            this.chb_Ad_Soyad.AutoSize = true;
            this.chb_Ad_Soyad.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chb_Ad_Soyad.Location = new System.Drawing.Point(7, 95);
            this.chb_Ad_Soyad.Name = "chb_Ad_Soyad";
            this.chb_Ad_Soyad.Size = new System.Drawing.Size(130, 26);
            this.chb_Ad_Soyad.TabIndex = 4;
            this.chb_Ad_Soyad.Text = "Ad ve Soyad";
            this.chb_Ad_Soyad.UseVisualStyleBackColor = true;
            this.chb_Ad_Soyad.CheckedChanged += new System.EventHandler(this.chb_Ad_Soyad_CheckedChanged);
            // 
            // chb_soyad
            // 
            this.chb_soyad.AutoSize = true;
            this.chb_soyad.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_soyad.Location = new System.Drawing.Point(7, 55);
            this.chb_soyad.Name = "chb_soyad";
            this.chb_soyad.Size = new System.Drawing.Size(79, 33);
            this.chb_soyad.TabIndex = 3;
            this.chb_soyad.Text = "Soyad";
            this.chb_soyad.UseVisualStyleBackColor = true;
            this.chb_soyad.CheckedChanged += new System.EventHandler(this.chb_soyad_CheckedChanged);
            // 
            // chxAD
            // 
            this.chxAD.AutoSize = true;
            this.chxAD.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxAD.Location = new System.Drawing.Point(7, 28);
            this.chxAD.Name = "chxAD";
            this.chxAD.Size = new System.Drawing.Size(49, 20);
            this.chxAD.TabIndex = 3;
            this.chxAD.Text = "Ad";
            this.chxAD.UseVisualStyleBackColor = true;
            this.chxAD.CheckedChanged += new System.EventHandler(this.chxAD_CheckedChanged);
            // 
            // btnBirArama
            // 
            this.btnBirArama.Location = new System.Drawing.Point(102, 118);
            this.btnBirArama.Name = "btnBirArama";
            this.btnBirArama.Size = new System.Drawing.Size(104, 39);
            this.btnBirArama.TabIndex = 2;
            this.btnBirArama.Text = "Bire bir Arama";
            this.btnBirArama.UseVisualStyleBackColor = true;
            this.btnBirArama.Click += new System.EventHandler(this.btnBirArama_Click);
            // 
            // txtSoyad_arama
            // 
            this.txtSoyad_arama.Enabled = false;
            this.txtSoyad_arama.Location = new System.Drawing.Point(102, 62);
            this.txtSoyad_arama.Name = "txtSoyad_arama";
            this.txtSoyad_arama.Size = new System.Drawing.Size(104, 20);
            this.txtSoyad_arama.TabIndex = 1;
            // 
            // txtBirArama_Ad
            // 
            this.txtBirArama_Ad.Enabled = false;
            this.txtBirArama_Ad.Location = new System.Drawing.Point(102, 26);
            this.txtBirArama_Ad.Name = "txtBirArama_Ad";
            this.txtBirArama_Ad.Size = new System.Drawing.Size(104, 20);
            this.txtBirArama_Ad.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Controls.Add(this.arama_alan);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbAramaTur);
            this.groupBox2.Controls.Add(this.textaranan);
            this.groupBox2.Location = new System.Drawing.Point(595, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 174);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benzer Arama";
            // 
            // arama_alan
            // 
            this.arama_alan.AutoSize = true;
            this.arama_alan.Location = new System.Drawing.Point(8, 122);
            this.arama_alan.Name = "arama_alan";
            this.arama_alan.Size = new System.Drawing.Size(7, 13);
            this.arama_alan.TabIndex = 5;
            this.arama_alan.Text = "\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.BlueViolet;
            this.groupBox3.Controls.Add(this.rdbDyerAra);
            this.groupBox3.Controls.Add(this.rdbTCNOara);
            this.groupBox3.Location = new System.Drawing.Point(52, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alan Seçiniz";
            // 
            // rdbDyerAra
            // 
            this.rdbDyerAra.AutoSize = true;
            this.rdbDyerAra.Location = new System.Drawing.Point(7, 34);
            this.rdbDyerAra.Name = "rdbDyerAra";
            this.rdbDyerAra.Size = new System.Drawing.Size(76, 17);
            this.rdbDyerAra.TabIndex = 0;
            this.rdbDyerAra.TabStop = true;
            this.rdbDyerAra.Text = "Doğum yer";
            this.rdbDyerAra.UseVisualStyleBackColor = true;
            this.rdbDyerAra.CheckedChanged += new System.EventHandler(this.rdbDyerAra_CheckedChanged);
            // 
            // rdbTCNOara
            // 
            this.rdbTCNOara.AutoSize = true;
            this.rdbTCNOara.Location = new System.Drawing.Point(97, 34);
            this.rdbTCNOara.Name = "rdbTCNOara";
            this.rdbTCNOara.Size = new System.Drawing.Size(55, 17);
            this.rdbTCNOara.TabIndex = 0;
            this.rdbTCNOara.TabStop = true;
            this.rdbTCNOara.Text = "TCNO";
            this.rdbTCNOara.UseVisualStyleBackColor = true;
            this.rdbTCNOara.CheckedChanged += new System.EventHandler(this.rdbTCNOara_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Arama türü";
            // 
            // cmbAramaTur
            // 
            this.cmbAramaTur.FormattingEnabled = true;
            this.cmbAramaTur.Items.AddRange(new object[] {
            "ile başlayan",
            "ile bitten",
            "içeren"});
            this.cmbAramaTur.Location = new System.Drawing.Point(102, 30);
            this.cmbAramaTur.Name = "cmbAramaTur";
            this.cmbAramaTur.Size = new System.Drawing.Size(121, 21);
            this.cmbAramaTur.TabIndex = 2;
            this.cmbAramaTur.Text = "ile başlayan";
            // 
            // textaranan
            // 
            this.textaranan.Location = new System.Drawing.Point(79, 119);
            this.textaranan.Name = "textaranan";
            this.textaranan.Size = new System.Drawing.Size(144, 20);
            this.textaranan.TabIndex = 1;
            this.textaranan.TextChanged += new System.EventHandler(this.textaranan_TextChanged);
            // 
            // btnbilgiislem
            // 
            this.btnbilgiislem.Location = new System.Drawing.Point(354, 337);
            this.btnbilgiislem.Name = "btnbilgiislem";
            this.btnbilgiislem.Size = new System.Drawing.Size(75, 39);
            this.btnbilgiislem.TabIndex = 9;
            this.btnbilgiislem.Text = "Kullanıcı işlem";
            this.btnbilgiislem.UseVisualStyleBackColor = true;
            this.btnbilgiislem.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelİşlemleriToolStripMenuItem,
            this.tanımlamaToolStripMenuItem,
            this.güvenlikToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listelemeToolStripMenuItem,
            this.kayıtEklemeToolStripMenuItem,
            this.kayıtSilmeToolStripMenuItem,
            this.kayıtGüncellemeToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // listelemeToolStripMenuItem
            // 
            this.listelemeToolStripMenuItem.Name = "listelemeToolStripMenuItem";
            this.listelemeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listelemeToolStripMenuItem.Text = "Listeleme";
            this.listelemeToolStripMenuItem.Click += new System.EventHandler(this.btn_listeme_Click);
            // 
            // kayıtEklemeToolStripMenuItem
            // 
            this.kayıtEklemeToolStripMenuItem.Name = "kayıtEklemeToolStripMenuItem";
            this.kayıtEklemeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kayıtEklemeToolStripMenuItem.Text = "Kayıt ekleme";
            this.kayıtEklemeToolStripMenuItem.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // kayıtSilmeToolStripMenuItem
            // 
            this.kayıtSilmeToolStripMenuItem.Name = "kayıtSilmeToolStripMenuItem";
            this.kayıtSilmeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kayıtSilmeToolStripMenuItem.Text = "Kayıt Silme";
            this.kayıtSilmeToolStripMenuItem.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // kayıtGüncellemeToolStripMenuItem
            // 
            this.kayıtGüncellemeToolStripMenuItem.Name = "kayıtGüncellemeToolStripMenuItem";
            this.kayıtGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kayıtGüncellemeToolStripMenuItem.Text = "Kayıt Güncelleme";
            this.kayıtGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tanımlamaToolStripMenuItem
            // 
            this.tanımlamaToolStripMenuItem.Name = "tanımlamaToolStripMenuItem";
            this.tanımlamaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.tanımlamaToolStripMenuItem.Text = "Tanımlama";
            // 
            // güvenlikToolStripMenuItem
            // 
            this.güvenlikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem});
            this.güvenlikToolStripMenuItem.Name = "güvenlikToolStripMenuItem";
            this.güvenlikToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.güvenlikToolStripMenuItem.Text = "Güvenlik";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtSilToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 399);
            this.Controls.Add(this.btnbilgiislem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listeme);
            this.Controls.Add(this.dataGridListele);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(860, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridListele;
        private System.Windows.Forms.Button btn_listeme;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBirArama;
        private System.Windows.Forms.TextBox txtBirArama_Ad;
        private System.Windows.Forms.CheckBox chb_soyad;
        private System.Windows.Forms.CheckBox chxAD;
        private System.Windows.Forms.TextBox txtSoyad_arama;
        private System.Windows.Forms.CheckBox chb_tum;
        private System.Windows.Forms.CheckBox chb_Ad_Soyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDyerAra;
        private System.Windows.Forms.RadioButton rdbTCNOara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAramaTur;
        private System.Windows.Forms.TextBox textaranan;
        private System.Windows.Forms.Label arama_alan;
        private System.Windows.Forms.Button btnbilgiislem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güvenlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}

