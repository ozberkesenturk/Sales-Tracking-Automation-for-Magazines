
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
    public partial class DergiSayiForm : Form
    {
        public DergiSayiForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DergiSayilari d = new DergiSayilari();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            d.id = id;
            if (dataGridView1.CurrentRow!=null)
            {
                bool sonuc= dorm.Delete(d);
                if (sonuc)
                {
                    dataGridView1.DataSource = dorm.Select();
                    MessageBox.Show("Silme İşlemi Gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Hata Oluştu!");
                }
            }
            else
            {
                MessageBox.Show("Silmek İstediğiniz Satırı Seçiniz.");
            }
        }

        DergiSayilariORM dorm = new DergiSayilariORM();

        private void DergiSayiForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dorm.Select();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DergiSayilari d = new DergiSayilari();
            d.Tarih = dtpTarih.Value;
            d.Sayi =(int)nudSayi.Value;
            d.Aciklama = txtAciklama.Text;

            bool sonuc = dorm.Insert(d);
            if (sonuc)
            {
                dataGridView1.DataSource = dorm.Select();
                MessageBox.Show("Kayıt Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }
    }
}
