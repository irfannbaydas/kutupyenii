using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup.Kayit
{
    public partial class odunc : Form
    {
        public odunc()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void odunc_Load(object sender, EventArgs e)
        {
            var kayitlist = db.kayitlar.ToList();
            dataGridView1.DataSource = kayitlist.ToList();
            
            var kaynaklist = db.kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklist.ToList();
            
            dataGridView1.Columns[6].Visible=false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Kayıt ID";
            dataGridView1.Columns[1].HeaderText = "Kulanıcı ID";
            dataGridView1.Columns[2].HeaderText = "Kitap ID";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
            dataGridView1.Columns[5].HeaderText = "Durum";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = tctxt.Text;
            var kullanicivarmi = db.kullanicilar.Where(x=>x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (kullanicivarmi != null)
                label2.Text = kullanicivarmi.kullanici_ad + " " + kullanicivarmi.kullanici_soyad;
            else
                label2.Text = "Böyle Bir Kullanıcı Yok !";
        }
    }
}
