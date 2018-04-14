
using DergimORM.entity;
using DergimORM.facede;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DergimWinformUI
{
    public partial class SatisForm : Form
    {
        public SatisForm()
        {
            InitializeComponent();
        }
        SatislarORM sorm = new SatislarORM();
        MusterilerORM morm = new MusterilerORM();
        PersonellerORM porm = new PersonellerORM();
        DergiSayilariORM dorm = new DergiSayilariORM();

        private void SatisForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sorm.Select();

            cmbDergiSayilari.DisplayMember = "Sayi";
            cmbDergiSayilari.ValueMember = "id";
            cmbDergiSayilari.DataSource = dorm.Select();

            cmbMusteriler.DisplayMember = "SirketAdi";
            cmbMusteriler.ValueMember = "id";
            cmbMusteriler.DataSource = morm.Select();

            cmbPersoneller.DisplayMember = "Adi";
            cmbPersoneller.ValueMember = "id";
            cmbPersoneller.DataSource = porm.Select();

            dataGridView1.Columns["id"].Visible = false;
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Satislar s = new Satislar();
            s.DergiSayiID =(int) cmbDergiSayilari.SelectedValue;
            s.MusteriID = (int)cmbMusteriler.SelectedValue;
            s.SatisTutari = nudSatisTutari.Value;
            s.SayiAdedi = (int)nudSatilanSayiAdedi.Value;
            s.PersonelID =(int) cmbPersoneller.SelectedValue;
            s.Aciklama = textBox1.Text;
            bool sonuc = sorm.Insert(s);
            if (sonuc)
            {
                dataGridView1.DataSource = sorm.Select();
                MessageBox.Show("Satış Eklendi.");
            }
            else
            {
                MessageBox.Show("Hata Olutu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satislar s = new Satislar();
            int id =Convert.ToInt32( dataGridView1.CurrentRow.Cells["id"].Value);
            s.id = id;
            if (dataGridView1.CurrentRow!=null)
            {
                bool sonuc = sorm.Delete(s);
                if (sonuc)
                {
                    dataGridView1.DataSource = sorm.Select();
                    MessageBox.Show("Kayıt Silindi");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğini Kaydı Seçiniz");
            }
        }
    }
}
