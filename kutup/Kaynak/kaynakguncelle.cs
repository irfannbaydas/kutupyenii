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
        } 
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayinciKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

    }
}
