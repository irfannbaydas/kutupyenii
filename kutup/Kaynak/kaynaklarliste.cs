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
    public partial class kaynaklarliste : Form
    {
        public kaynaklarliste()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities(); 

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kaynaklarliste_Load(object sender, EventArgs e)
        {
            var  Kaynaklar = db.kaynaklar.ToList();
            dataGridView1.DataSource = Kaynaklar.ToList();
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Kaynak ID";
            dataGridView1.Columns[1].HeaderText = "Kaynak Adı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Yazar";
            dataGridView1.Columns[3].HeaderText = "Kaynak Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Tarihi";
        }
    }
}
