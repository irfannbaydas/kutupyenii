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
            dataGridView1.Columns[6].Visible = false;


            dataGridView1.Columns[0].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyad";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı TC";
            dataGridView1.Columns[4].HeaderText = "Kullanıcı Telefon";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı Mail";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
