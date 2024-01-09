using kutup.Kayit;
using kutup.Kaynak;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            kuleklebtn.Visible = false;
            Kullaniciguncellebtn.Visible = false;
            Kullanicisilbtn.Visible = false;

            kaynakeklebtn.Visible = false;
            kaynaksilbtn.Visible = false;
            kaynakguncellebtn.Visible = false;


            
        }

        private void Kullaniciislembtn_Click(object sender, EventArgs e)
        {
            if (kuleklebtn.Visible == false)
            {
                kuleklebtn.Visible = true;
                Kullaniciguncellebtn.Visible = true;
                Kullanicisilbtn.Visible = true;
            }

            else
            {
                kuleklebtn.Visible = false;
                Kullaniciguncellebtn.Visible = false;
                Kullanicisilbtn.Visible = false;
            }
            kullanicilarform klisteform = new kullanicilarform();
            klisteform.MdiParent = this;
            klisteform.Show();
        }

        private void kuleklebtn_Click(object sender, EventArgs e)
        {
            kullaniciekleform ekleform = new kullaniciekleform();
            ekleform.MdiParent = this;
            ekleform.Show();
        }

        private void Kullanicisilbtn_Click(object sender, EventArgs e)
        {
            kulsilform ksil = new kulsilform();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void kuleklebtn_Click_1(object sender, EventArgs e)
        {

            kullaniciekleform ekleform = new kullaniciekleform();
            ekleform.MdiParent = this;
            ekleform.Show();
        }

        private void Kullanicisilbtn_Click_1(object sender, EventArgs e)
        {
            kulsilform ksil = new kulsilform();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void Kullaniciguncellebtn_Click(object sender, EventArgs e)
        {
            Kullaniciguncelle kguncel = new Kullaniciguncelle();
            kguncel.MdiParent = this;
            kguncel.Show();
        }

        private void kaynaklarbtn_Click(object sender, EventArgs e)
        {
            if (kaynakeklebtn.Visible == false)
            {
                kaynakeklebtn.Visible = true;
                kaynaksilbtn.Visible = true;
                kaynakguncellebtn.Visible = true;
            }

            else
            {
                kaynakeklebtn.Visible = false;
                kaynaksilbtn.Visible = false;
                kaynakguncellebtn.Visible = false;
                
            }
            kullanicilarform klisteform = new kullanicilarform();
            klisteform.MdiParent = this;
            klisteform.Show();

            kaynaklarliste kliste = new kaynaklarliste();
            kliste.MdiParent = this;
            kliste.Show();
        }

        private void kaynakeklebtn_Click(object sender, EventArgs e)
        {
            kaynakekle kekle = new kaynakekle();
            kekle.MdiParent = this;
            kekle.Show();
        }

        private void kaynaksilbtn_Click(object sender, EventArgs e)
        {
            kaynaksil kSil = new kaynaksil();
            kSil.MdiParent = this;
            kSil.Show();    
        }

        private void kaynakguncellebtn_Click(object sender, EventArgs e)
        {
            kaynakguncelle kguncelle = new kaynakguncelle();
            kguncelle.MdiParent = this;
            kguncelle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odunc oduncver = new odunc();
            oduncver.MdiParent = this;
            oduncver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerial geri = new gerial();
            geri.MdiParent = this;
            geri.Show();
        }
    }
}
