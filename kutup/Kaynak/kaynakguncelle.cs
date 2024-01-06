using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup.Kaynak
{
    public partial class kaynakguncelle : Form
    {
        public kaynakguncelle()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
       private void kaynakguncelle_Load(object sender, EventArgs e)
        {
            var Kaynaklar = db.kaynaklar.ToList();
            dataGridView1.DataSource = Kaynaklar;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Kaynak ID";
            dataGridView1.Columns[1].HeaderText = "Kaynak Adı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Yazar";
            dataGridView1.Columns[3].HeaderText = "Kaynak Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Tarihi";
        } 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void kaynakaydetbtn_Click(object sender, EventArgs e)
        {
            int secilenKaynak = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = db.kaynaklar.Where(x=>x.kaynak_id == secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.kaynak_ad = adKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yazar = yazarKaynaktxt.Text; 
            guncellenecekKaynak.kaynak_yayinci = yazarKaynaktxt.Text;
            guncellenecekKaynak.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            guncellenecekKaynak.kaynak_basimtarihi = dateTimePicker1.Value;
            db.SaveChanges();

            var Kaynak = db.kaynaklar.ToList();
            dataGridView1.DataSource = Kaynak.ToList();
        }   
    }
}
