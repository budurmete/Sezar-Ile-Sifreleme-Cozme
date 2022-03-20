using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sezar_Ile_Sifreleme_Cozme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sifrele_Click(object sender, EventArgs e)
        {
            string veri = "";
            veri = txtVeri.Text;
            char[] karakter = veri.ToCharArray();
            foreach  (char eleman in karakter)
            {
                txtSifreliVeri.Text += Convert.ToChar(eleman+3).ToString();
                // +3 yapamızın sebebi= Şifrelenecek veri örenğin A ise A'dan sonra gelen 3. kelime D ile Şifrelenir
                //Siz istediğiniz şekilde Şifreleme yapa bilirsiniz.
            }

        }

        private void btn_Coz_Click(object sender, EventArgs e)
        {
            string Sveri = "";
            Sveri = txtSifreliVeri.Text;
            char[] karakter = Sveri.ToCharArray();
            foreach (char eleman in karakter)
            {
                txtCozulmus.Text += Convert.ToChar(eleman -3).ToString();
               //Kacıncı kelimeden sonra şifrelenmiş ise örenğin 4. kelime ile şifrelenmiş iste -4 yazıyoruz.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCozulmus.Text = "";
            txtSifreliVeri.Text = "";
            txtVeri.Text = "";
        }
    }
}
