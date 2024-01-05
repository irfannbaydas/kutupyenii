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
    public partial class kullaniciekleform : Form
    {
        public kullaniciekleform()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();


        private void button1_Click(object sender, EventArgs e)
        {
            kullanicilar kullanici = new kullanicilar();
            kullanici.kullanici_ad = kuladtxt.Text;
            kullanici.kullanici_soyad = kulsoyadtxt.Text;
            kullanici.kullanici_tc = kultctxt.Text;
            kullanici.kullanici_tel = kulteltxt.Text;
            kullanici.kullanici_mail = kulmailtxt.Text;


            db.kullanicilar.Add(kullanici);
            db.SaveChanges();
            Listele();
        }
        public void Listele()
        {

            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();

          
        }
            

        private void kullaniciekleform_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
