
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
    public partial class PersonelForm : Form
    {
        public PersonelForm()
        {
            InitializeComponent();
        }
        PersonellerORM porm = new PersonellerORM();
        private void PersonelForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = porm.Select();
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["Aktif"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.TelNo = mskTel.Text;

            bool sonuc = porm.Insert(p);
            if (sonuc)
            {
                dataGridView1.DataSource = porm.Select();
                MessageBox.Show("Kayıt Ekleme Başarılı.");
            }
            else
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                Personeller p = new Personeller();
                
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                p.id = id;
                if (dataGridView1.CurrentRow!=null)
                {
                    bool sonuc = porm.Delete(p);
                    if (sonuc)
                    {
                        dataGridView1.DataSource = porm.Select();
                        MessageBox.Show("Silme İşlemi Gerçekleşti");
                    }
                    else
                    {
                        MessageBox.Show("Hata Oluştu");
                    }
                }
                else
                {
                    MessageBox.Show("Silmek İstediğiniz Satırı Seçiniz.");
                }
            }
        }
    }
}
