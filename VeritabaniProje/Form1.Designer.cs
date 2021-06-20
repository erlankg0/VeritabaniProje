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
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.btn_listeme = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBirArama_Ad = new System.Windows.Forms.TextBox();
            this.btnBirArama = new System.Windows.Forms.Button();
            this.txtSoyad_arama = new System.Windows.Forms.TextBox();
            this.chxAD = new System.Windows.Forms.CheckBox();
            this.chb_soyad = new System.Windows.Forms.CheckBox();
            this.chb_Ad_Soyad = new System.Windows.Forms.CheckBox();
            this.chb_tum = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridListele
            // 
            this.dataGridListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridListele.Location = new System.Drawing.Point(12, 77);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListele.Size = new System.Drawing.Size(577, 254);
            this.dataGridListele.TabIndex = 2;
            this.dataGridListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_listeme
            // 
            this.btn_listeme.Location = new System.Drawing.Point(13, 12);
            this.btn_listeme.Name = "btn_listeme";
            this.btn_listeme.Size = new System.Drawing.Size(75, 40);
            this.btn_listeme.TabIndex = 3;
            this.btn_listeme.Text = "Listeleme";
            this.btn_listeme.UseVisualStyleBackColor = true;
            this.btn_listeme.Click += new System.EventHandler(this.btn_listeme_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(94, 12);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 40);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Kayıt Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(176, 13);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(81, 39);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Kayıt Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(263, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(595, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bire bir Arama";
            // 
            // txtBirArama_Ad
            // 
            this.txtBirArama_Ad.Enabled = false;
            this.txtBirArama_Ad.Location = new System.Drawing.Point(102, 26);
            this.txtBirArama_Ad.Name = "txtBirArama_Ad";
            this.txtBirArama_Ad.Size = new System.Drawing.Size(104, 20);
            this.txtBirArama_Ad.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Plum;
            this.groupBox2.Location = new System.Drawing.Point(595, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 174);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Benzer Arama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listeme);
            this.Controls.Add(this.dataGridListele);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

