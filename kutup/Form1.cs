using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup
{
    public partial class Form1 : Form
    {
        kutupEntities db = new kutupEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelgirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd = adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;

            var personel = db.perskutupveritabani.Where(x=>x.personel_ad.Equals(gelenAd)&& x.personel_sfire.Equals(gelenSifre)).FirstOrDefault();
 
            if (personel == null)

            {
                MessageBox.Show(text: "Kullanıcı Adı Veya Şifre Hatalı!");
            }
            else
            {
                MessageBox.Show(text: "Başarılı!");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
