
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
    public partial class MusterilerForm : Form
    {
        public MusterilerForm()
        {
            InitializeComponent();
        }
        MusterilerORM morm = new MusterilerORM();
        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = morm.Select();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.Adi = txtAdi.Text;
            m.Soyadi = txtSoyadi.Text;
            m.Aciklama = txtAciklama.Text;
            m.SirketAdi = txtSirketAdi.Text;
            m.TelNo = mskTel.Text;

            bool sonuc = morm.Insert(m);
            if (sonuc)
            {
                dataGridView1.DataSource = morm.Select();
                MessageBox.Show("Kayıt Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            m.id = id;
            if (dataGridView1.CurrentRow!=null)
            {
               bool sonuc = morm.Delete(m);
                if (sonuc)
                {
                    dataGridView1.DataSource = morm.Select();
                    MessageBox.Show("Silme İşlemi Gerçekleşti.");
                }
                else
                {
                    MessageBox.Show("Hata oluştu!");
                }
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Satırı Seçiniz.");
            }
        }
    }
}
