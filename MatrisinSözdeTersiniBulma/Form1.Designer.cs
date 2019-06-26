namespace MatrisinSözdeTersiniBulma
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
            this.components = new System.ComponentModel.Container();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkRastgele = new System.Windows.Forms.CheckBox();
            this.checkManuel = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatir = new System.Windows.Forms.TextBox();
            this.txtSütun = new System.Windows.Forms.TextBox();
            this.btnDegerGiris = new System.Windows.Forms.Button();
            this.lblToplamSayisi = new System.Windows.Forms.Label();
            this.lblCarpimSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(149, 393);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçim yapınız. ";
            // 
            // checkRastgele
            // 
            this.checkRastgele.AutoSize = true;
            this.checkRastgele.Location = new System.Drawing.Point(149, 84);
            this.checkRastgele.Name = "checkRastgele";
            this.checkRastgele.Size = new System.Drawing.Size(68, 17);
            this.checkRastgele.TabIndex = 2;
            this.checkRastgele.Text = "Rastgele";
            this.checkRastgele.UseVisualStyleBackColor = true;
            // 
            // checkManuel
            // 
            this.checkManuel.AutoSize = true;
            this.checkManuel.Location = new System.Drawing.Point(260, 83);
            this.checkManuel.Name = "checkManuel";
            this.checkManuel.Size = new System.Drawing.Size(61, 17);
            this.checkManuel.TabIndex = 3;
            this.checkManuel.Text = "Manuel";
            this.checkManuel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satır: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sütun:";
            // 
            // txtSatir
            // 
            this.txtSatir.Location = new System.Drawing.Point(578, 51);
            this.txtSatir.Name = "txtSatir";
            this.txtSatir.Size = new System.Drawing.Size(34, 20);
            this.txtSatir.TabIndex = 6;
            // 
            // txtSütun
            // 
            this.txtSütun.Location = new System.Drawing.Point(578, 77);
            this.txtSütun.Name = "txtSütun";
            this.txtSütun.Size = new System.Drawing.Size(34, 20);
            this.txtSütun.TabIndex = 7;
            // 
            // btnDegerGiris
            // 
            this.btnDegerGiris.Location = new System.Drawing.Point(673, 79);
            this.btnDegerGiris.Name = "btnDegerGiris";
            this.btnDegerGiris.Size = new System.Drawing.Size(75, 23);
            this.btnDegerGiris.TabIndex = 8;
            this.btnDegerGiris.Text = "Değer Gir";
            this.btnDegerGiris.UseVisualStyleBackColor = true;
            this.btnDegerGiris.Click += new System.EventHandler(this.btnDegerGiris_Click);
            // 
            // lblToplamSayisi
            // 
            this.lblToplamSayisi.AutoSize = true;
            this.lblToplamSayisi.Location = new System.Drawing.Point(598, 398);
            this.lblToplamSayisi.Name = "lblToplamSayisi";
            this.lblToplamSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblToplamSayisi.TabIndex = 9;
            // 
            // lblCarpimSayisi
            // 
            this.lblCarpimSayisi.AutoSize = true;
            this.lblCarpimSayisi.Location = new System.Drawing.Point(598, 431);
            this.lblCarpimSayisi.Name = "lblCarpimSayisi";
            this.lblCarpimSayisi.Size = new System.Drawing.Size(0, 13);
            this.lblCarpimSayisi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ToplamSayisi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ÇarpımSayisi : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarpimSayisi);
            this.Controls.Add(this.lblToplamSayisi);
            this.Controls.Add(this.btnDegerGiris);
            this.Controls.Add(this.txtSütun);
            this.Controls.Add(this.txtSatir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkManuel);
            this.Controls.Add(this.checkRastgele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkRastgele;
        private System.Windows.Forms.CheckBox checkManuel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatir;
        private System.Windows.Forms.TextBox txtSütun;
        private System.Windows.Forms.Button btnDegerGiris;
        private System.Windows.Forms.Label lblToplamSayisi;
        private System.Windows.Forms.Label lblCarpimSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

