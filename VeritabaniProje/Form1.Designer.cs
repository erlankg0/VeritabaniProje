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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dataGridListele = new System.Windows.Forms.DataGridView();
            this.btn_listeme = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAc.Location = new System.Drawing.Point(733, 51);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(93, 64);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Veritabanını Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(733, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(93, 33);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Veritabanını Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dataGridListele
            // 
            this.dataGridListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListele.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridListele.Location = new System.Drawing.Point(12, 77);
            this.dataGridListele.Name = "dataGridListele";
            this.dataGridListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListele.Size = new System.Drawing.Size(494, 254);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 369);
            this.Controls.Add(this.BtnDelete);
=======
            this.ClientSize = new System.Drawing.Size(525, 369);
>>>>>>> 9202824f6858c8545325336426e91267fa53e346
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listeme);
            this.Controls.Add(this.dataGridListele);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dataGridListele;
        private System.Windows.Forms.Button btn_listeme;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button BtnDelete;
    }
}

