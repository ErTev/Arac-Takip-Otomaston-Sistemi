namespace SQl_Ödev
{
    partial class ServısKayıtları
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn3_gncll = new System.Windows.Forms.Button();
            this.btn3_sil = new System.Windows.Forms.Button();
            this.btn3_ekle = new System.Windows.Forms.Button();
            this.txt_servisUcretı = new System.Windows.Forms.TextBox();
            this.txt_tarıh = new System.Windows.Forms.TextBox();
            this.txt_aracıID = new System.Windows.Forms.TextBox();
            this.LABEL5 = new System.Windows.Forms.Label();
            this.LABEL4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temzl = new System.Windows.Forms.Button();
            this.txt_acıklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 520);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn3_gncll
            // 
            this.btn3_gncll.Location = new System.Drawing.Point(887, 338);
            this.btn3_gncll.Name = "btn3_gncll";
            this.btn3_gncll.Size = new System.Drawing.Size(75, 23);
            this.btn3_gncll.TabIndex = 27;
            this.btn3_gncll.Text = "Güncelle";
            this.btn3_gncll.UseVisualStyleBackColor = true;
            this.btn3_gncll.Click += new System.EventHandler(this.btn3_gncll_Click);
            // 
            // btn3_sil
            // 
            this.btn3_sil.Location = new System.Drawing.Point(997, 271);
            this.btn3_sil.Name = "btn3_sil";
            this.btn3_sil.Size = new System.Drawing.Size(75, 23);
            this.btn3_sil.TabIndex = 26;
            this.btn3_sil.Text = "Sil";
            this.btn3_sil.UseVisualStyleBackColor = true;
            this.btn3_sil.Click += new System.EventHandler(this.btn3_sil_Click);
            // 
            // btn3_ekle
            // 
            this.btn3_ekle.Location = new System.Drawing.Point(887, 271);
            this.btn3_ekle.Name = "btn3_ekle";
            this.btn3_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn3_ekle.TabIndex = 25;
            this.btn3_ekle.Text = "Ekle";
            this.btn3_ekle.UseVisualStyleBackColor = true;
            this.btn3_ekle.Click += new System.EventHandler(this.btn3_ekle_Click);
            // 
            // txt_servisUcretı
            // 
            this.txt_servisUcretı.Location = new System.Drawing.Point(924, 205);
            this.txt_servisUcretı.Name = "txt_servisUcretı";
            this.txt_servisUcretı.Size = new System.Drawing.Size(148, 20);
            this.txt_servisUcretı.TabIndex = 24;
            // 
            // txt_tarıh
            // 
            this.txt_tarıh.Location = new System.Drawing.Point(925, 133);
            this.txt_tarıh.Name = "txt_tarıh";
            this.txt_tarıh.Size = new System.Drawing.Size(148, 20);
            this.txt_tarıh.TabIndex = 23;
            // 
            // txt_aracıID
            // 
            this.txt_aracıID.Location = new System.Drawing.Point(924, 91);
            this.txt_aracıID.Name = "txt_aracıID";
            this.txt_aracıID.Size = new System.Drawing.Size(148, 20);
            this.txt_aracıID.TabIndex = 21;
            // 
            // LABEL5
            // 
            this.LABEL5.AutoSize = true;
            this.LABEL5.Location = new System.Drawing.Point(842, 208);
            this.LABEL5.Name = "LABEL5";
            this.LABEL5.Size = new System.Drawing.Size(67, 13);
            this.LABEL5.TabIndex = 19;
            this.LABEL5.Text = "Servis Ücreti";
            // 
            // LABEL4
            // 
            this.LABEL4.AutoSize = true;
            this.LABEL4.Location = new System.Drawing.Point(822, 140);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(97, 13);
            this.LABEL4.TabIndex = 18;
            this.LABEL4.Text = "Servise Geliş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Arac ID";
            // 
            // btn_temzl
            // 
            this.btn_temzl.Location = new System.Drawing.Point(997, 338);
            this.btn_temzl.Name = "btn_temzl";
            this.btn_temzl.Size = new System.Drawing.Size(75, 23);
            this.btn_temzl.TabIndex = 49;
            this.btn_temzl.Text = "Temizle";
            this.btn_temzl.UseVisualStyleBackColor = true;
            this.btn_temzl.Click += new System.EventHandler(this.btn_temzl_Click);
            // 
            // txt_acıklama
            // 
            this.txt_acıklama.Location = new System.Drawing.Point(924, 170);
            this.txt_acıklama.Name = "txt_acıklama";
            this.txt_acıklama.Size = new System.Drawing.Size(148, 20);
            this.txt_acıklama.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(859, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Açıklama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(998, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServısKayıtları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 537);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_acıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_temzl);
            this.Controls.Add(this.btn3_gncll);
            this.Controls.Add(this.btn3_sil);
            this.Controls.Add(this.btn3_ekle);
            this.Controls.Add(this.txt_servisUcretı);
            this.Controls.Add(this.txt_tarıh);
            this.Controls.Add(this.txt_aracıID);
            this.Controls.Add(this.LABEL5);
            this.Controls.Add(this.LABEL4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ServısKayıtları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServısKayıtları";
            this.Load += new System.EventHandler(this.ServısKayıtları_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn3_gncll;
        private System.Windows.Forms.Button btn3_sil;
        private System.Windows.Forms.Button btn3_ekle;
        private System.Windows.Forms.TextBox txt_servisUcretı;
        private System.Windows.Forms.TextBox txt_tarıh;
        private System.Windows.Forms.TextBox txt_aracıID;
        private System.Windows.Forms.Label LABEL5;
        private System.Windows.Forms.Label LABEL4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temzl;
        private System.Windows.Forms.TextBox txt_acıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}