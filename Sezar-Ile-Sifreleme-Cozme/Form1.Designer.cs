
namespace Sezar_Ile_Sifreleme_Cozme
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.btn_Sifrele = new System.Windows.Forms.Button();
            this.txtSifreliVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCozulmus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Coz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrelenecek Veri";
            // 
            // txtVeri
            // 
            this.txtVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVeri.Location = new System.Drawing.Point(282, 96);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(240, 26);
            this.txtVeri.TabIndex = 1;
            // 
            // btn_Sifrele
            // 
            this.btn_Sifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sifrele.Location = new System.Drawing.Point(282, 235);
            this.btn_Sifrele.Name = "btn_Sifrele";
            this.btn_Sifrele.Size = new System.Drawing.Size(91, 36);
            this.btn_Sifrele.TabIndex = 2;
            this.btn_Sifrele.Text = "Şifrele";
            this.btn_Sifrele.UseVisualStyleBackColor = true;
            this.btn_Sifrele.Click += new System.EventHandler(this.btn_Sifrele_Click);
            // 
            // txtSifreliVeri
            // 
            this.txtSifreliVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifreliVeri.Location = new System.Drawing.Point(282, 140);
            this.txtSifreliVeri.Name = "txtSifreliVeri";
            this.txtSifreliVeri.Size = new System.Drawing.Size(240, 26);
            this.txtSifreliVeri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Veri";
            // 
            // txtCozulmus
            // 
            this.txtCozulmus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCozulmus.Location = new System.Drawing.Point(282, 182);
            this.txtCozulmus.Name = "txtCozulmus";
            this.txtCozulmus.Size = new System.Drawing.Size(240, 26);
            this.txtCozulmus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Şifresi Çözülmüş Veri";
            // 
            // btn_Coz
            // 
            this.btn_Coz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Coz.Location = new System.Drawing.Point(406, 235);
            this.btn_Coz.Name = "btn_Coz";
            this.btn_Coz.Size = new System.Drawing.Size(116, 37);
            this.btn_Coz.TabIndex = 7;
            this.btn_Coz.Text = "Şifreyi Çöz";
            this.btn_Coz.UseVisualStyleBackColor = true;
            this.btn_Coz.Click += new System.EventHandler(this.btn_Coz_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(282, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Verileri Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(295, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sezar İle Şifreleme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Coz);
            this.Controls.Add(this.txtCozulmus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifreliVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Sifrele);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Button btn_Sifrele;
        private System.Windows.Forms.TextBox txtSifreliVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCozulmus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Coz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

