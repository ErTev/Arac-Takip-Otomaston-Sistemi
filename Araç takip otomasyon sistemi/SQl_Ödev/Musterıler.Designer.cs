namespace SQl_Ödev
{
    partial class Musterıler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LABEL5 = new System.Windows.Forms.Label();
            this.txt1_ad = new System.Windows.Forms.TextBox();
            this.txt1_soyad = new System.Windows.Forms.TextBox();
            this.txt1_mail = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.btn1_ekle = new System.Windows.Forms.Button();
            this.btn1_sil = new System.Windows.Forms.Button();
            this.btn1_gncll = new System.Windows.Forms.Button();
            this.btn_temzl = new System.Windows.Forms.Button();
            this.LABEL4 = new System.Windows.Forms.Label();
            this.txt1_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(779, 510);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(848, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // LABEL5
            // 
            this.LABEL5.AutoSize = true;
            this.LABEL5.Location = new System.Drawing.Point(848, 263);
            this.LABEL5.Name = "LABEL5";
            this.LABEL5.Size = new System.Drawing.Size(34, 13);
            this.LABEL5.TabIndex = 6;
            this.LABEL5.Text = "Adres";
            // 
            // txt1_ad
            // 
            this.txt1_ad.Location = new System.Drawing.Point(905, 73);
            this.txt1_ad.Name = "txt1_ad";
            this.txt1_ad.Size = new System.Drawing.Size(148, 20);
            this.txt1_ad.TabIndex = 7;
            // 
            // txt1_soyad
            // 
            this.txt1_soyad.Location = new System.Drawing.Point(905, 128);
            this.txt1_soyad.Name = "txt1_soyad";
            this.txt1_soyad.Size = new System.Drawing.Size(148, 20);
            this.txt1_soyad.TabIndex = 8;
            // 
            // txt1_mail
            // 
            this.txt1_mail.Location = new System.Drawing.Point(905, 176);
            this.txt1_mail.Name = "txt1_mail";
            this.txt1_mail.Size = new System.Drawing.Size(148, 20);
            this.txt1_mail.TabIndex = 9;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(905, 263);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(148, 20);
            this.txt_adres.TabIndex = 11;
            // 
            // btn1_ekle
            // 
            this.btn1_ekle.Location = new System.Drawing.Point(890, 320);
            this.btn1_ekle.Name = "btn1_ekle";
            this.btn1_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn1_ekle.TabIndex = 12;
            this.btn1_ekle.Text = "Ekle";
            this.btn1_ekle.UseVisualStyleBackColor = true;
            this.btn1_ekle.Click += new System.EventHandler(this.btn1_ekle_Click);
            // 
            // btn1_sil
            // 
            this.btn1_sil.Location = new System.Drawing.Point(1000, 320);
            this.btn1_sil.Name = "btn1_sil";
            this.btn1_sil.Size = new System.Drawing.Size(75, 23);
            this.btn1_sil.TabIndex = 13;
            this.btn1_sil.Text = "Sil";
            this.btn1_sil.UseVisualStyleBackColor = true;
            this.btn1_sil.Click += new System.EventHandler(this.btn1_sil_Click);
            // 
            // btn1_gncll
            // 
            this.btn1_gncll.Location = new System.Drawing.Point(890, 387);
            this.btn1_gncll.Name = "btn1_gncll";
            this.btn1_gncll.Size = new System.Drawing.Size(75, 23);
            this.btn1_gncll.TabIndex = 14;
            this.btn1_gncll.Text = "Güncelle";
            this.btn1_gncll.UseVisualStyleBackColor = true;
            this.btn1_gncll.Click += new System.EventHandler(this.btn1_gncll_Click);
            // 
            // btn_temzl
            // 
            this.btn_temzl.Location = new System.Drawing.Point(1000, 387);
            this.btn_temzl.Name = "btn_temzl";
            this.btn_temzl.Size = new System.Drawing.Size(75, 23);
            this.btn_temzl.TabIndex = 15;
            this.btn_temzl.Text = "Temizle";
            this.btn_temzl.UseVisualStyleBackColor = true;
            this.btn_temzl.Click += new System.EventHandler(this.btn_temzl_Click);
            // 
            // LABEL4
            // 
            this.LABEL4.AutoSize = true;
            this.LABEL4.Location = new System.Drawing.Point(848, 183);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(26, 13);
            this.LABEL4.TabIndex = 5;
            this.LABEL4.Text = "Mail";
            // 
            // txt1_tel
            // 
            this.txt1_tel.Location = new System.Drawing.Point(905, 224);
            this.txt1_tel.Name = "txt1_tel";
            this.txt1_tel.Size = new System.Drawing.Size(148, 20);
            this.txt1_tel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefon";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(988, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Musterıler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 534);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_temzl);
            this.Controls.Add(this.btn1_gncll);
            this.Controls.Add(this.btn1_sil);
            this.Controls.Add(this.btn1_ekle);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt1_tel);
            this.Controls.Add(this.txt1_mail);
            this.Controls.Add(this.txt1_soyad);
            this.Controls.Add(this.txt1_ad);
            this.Controls.Add(this.LABEL5);
            this.Controls.Add(this.LABEL4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Musterıler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musterıler";
            this.Load += new System.EventHandler(this.Musterıler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LABEL5;
        private System.Windows.Forms.TextBox txt1_ad;
        private System.Windows.Forms.TextBox txt1_soyad;
        private System.Windows.Forms.TextBox txt1_mail;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Button btn1_ekle;
        private System.Windows.Forms.Button btn1_sil;
        private System.Windows.Forms.Button btn1_gncll;
        private System.Windows.Forms.Button btn_temzl;
        private System.Windows.Forms.Label LABEL4;
        private System.Windows.Forms.TextBox txt1_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}