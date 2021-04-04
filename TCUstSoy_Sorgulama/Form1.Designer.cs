
namespace TCUstSoy_Sorgulama
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
            this.textBox1 = new System.Windows.Forms.TextBox();          
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox(); 
            this.TxtTarih = new System.Windows.Forms.TextBox();
           this.btn_Sorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 13);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Kimlik No Giriniz..";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(26, 39);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 2;
            this.TxtAd.Text = "İsim Giriniz..";
            this.TxtAd.Enter += new System.EventHandler(this.TxtAd_Enter);
            this.TxtAd.Leave += new System.EventHandler(this.TxtAd_Leave);
           
          
           
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(26, 65);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyad.TabIndex = 4;
            this.TxtSoyad.Text = "Soyisim Giriniz..";
            this.TxtSoyad.Enter += new System.EventHandler(this.TxtSoyad_Enter);
            this.TxtSoyad.Leave += new System.EventHandler(this.TxtSoyad_Leave);
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(26, 91);
            this.TxtTarih.MaxLength = 4;
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Size = new System.Drawing.Size(100, 20);
            this.TxtTarih.TabIndex = 3;
            this.TxtTarih.Text = "Doğum Tarihi Giriniz..";
            this.TxtTarih.Enter += new System.EventHandler(this.TxtTarih_Enter);
            this.TxtTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarih_KeyPress);
            this.TxtTarih.Leave += new System.EventHandler(this.TxtTarih_Leave);
            // 
            // btn_Sorgula
            // 
            this.btn_Sorgula.Location = new System.Drawing.Point(26, 117);
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.Size = new System.Drawing.Size(101, 23);
            this.btn_Sorgula.TabIndex = 1;
            this.btn_Sorgula.Text = "TC No Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtTarih);
            
            this.Controls.Add(this.btn_Sorgula);
           
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;      
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtTarih;
        private System.Windows.Forms.Button btn_Sorgula;
    }
}

