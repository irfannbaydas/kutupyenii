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

            dataGridView2.Columns[0].HeaderText = "Kaynak ID";
            dataGridView2.Columns[1].HeaderText = "Kaynak Ad";
            dataGridView2.Columns[2].HeaderText = "Kaynak Yazar";
            dataGridView2.Columns[3].HeaderText = "Kaynak Yayıncı";
            dataGridView2.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns[5].HeaderText = "Basım Tarihi";

            dataGridView2.Columns[6].Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.kaynaklar.Where(x=>x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource= bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string secilenKisitc = tctxt.Text;
           var secilenKisi = db.kullanicilar.Where(x=>x.kullanici_tc.Equals(secilenKisitc)).FirstOrDefault();

            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.kaynaklar.Where(x=>x.kaynak_id == secilenKitapId).FirstOrDefault();   


            kayitlar yenikayit = new kayitlar();
            yenikayit.kitap_id = secilenKitap.kaynak_id;
            yenikayit.kullanici_id = secilenKisi.kullanici_id;
            yenikayit.alis_tarih = DateTime.Today;
            yenikayit.son_tarih = DateTime.Today.AddDays(15);
            yenikayit.durum = false;
            db.kayitlar.Add(yenikayit);
            db.SaveChanges();
            var kayitList = db.kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
