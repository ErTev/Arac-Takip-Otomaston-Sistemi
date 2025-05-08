namespace SQl_Ödev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sıfre = new System.Windows.Forms.TextBox();
            this.txt_kllnci = new System.Windows.Forms.TextBox();
            this.btn_grs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cks
            // 
            this.btn_cks.Location = new System.Drawing.Point(446, 316);
            this.btn_cks.Name = "btn_cks";
            this.btn_cks.Size = new System.Drawing.Size(96, 30);
            this.btn_cks.TabIndex = 11;
            this.btn_cks.Text = "ÇIKIŞ";
            this.btn_cks.UseVisualStyleBackColor = true;
            this.btn_cks.Click += new System.EventHandler(this.btn_cks_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(300, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_sıfre
            // 
            this.txt_sıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sıfre.Location = new System.Drawing.Point(417, 222);
            this.txt_sıfre.Name = "txt_sıfre";
            this.txt_sıfre.PasswordChar = '*';
            this.txt_sıfre.Size = new System.Drawing.Size(139, 23);
            this.txt_sıfre.TabIndex = 8;
            // 
            // txt_kllnci
            // 
            this.txt_kllnci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kllnci.Location = new System.Drawing.Point(417, 169);
            this.txt_kllnci.Name = "txt_kllnci";
            this.txt_kllnci.Size = new System.Drawing.Size(139, 23);
            this.txt_kllnci.TabIndex = 7;
            // 
            // btn_grs
            // 
            this.btn_grs.Location = new System.Drawing.Point(321, 316);
            this.btn_grs.Name = "btn_grs";
            this.btn_grs.Size = new System.Drawing.Size(96, 30);
            this.btn_grs.TabIndex = 6;
            this.btn_grs.Text = "GİRİŞ";
            this.btn_grs.UseVisualStyleBackColor = true;
            this.btn_grs.Click += new System.EventHandler(this.btn_grs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "ADMİN PANELİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Edwardian Script ITC", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 51);
            this.label4.TabIndex = 15;
            this.label4.Text = "By ErTev";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(861, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sıfre);
            this.Controls.Add(this.txt_kllnci);
            this.Controls.Add(this.btn_grs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ERTEV OTOMOTIV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sıfre;
        private System.Windows.Forms.TextBox txt_kllnci;
        private System.Windows.Forms.Button btn_grs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

