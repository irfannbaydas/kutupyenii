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
    public partial class kaynakekle : Form
    {
        public kaynakekle()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            kaynaklar Kaynaklar = new kaynaklar();
            Kaynaklar.kaynak_ad = adKaynaktxt.Text;
            Kaynaklar.kaynak_yazar = yazarKaynaktxt.Text;
            Kaynaklar.kaynak_yayinci = yayinciKaynaktxt.Text;
            Kaynaklar.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            Kaynaklar.kaynak_basimtarihi = dateTimePicker1.Value;
            db.kaynaklar.Add(Kaynaklar);
            db.SaveChanges();

            
           var kliste = db.kaynaklar.ToList();
           dataGridView1.DataSource = kliste.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kaynakekle_Load(object sender, EventArgs e)
        {
            var kliste = db.kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }
    }
}
