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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SatisForm sf = new SatisForm();
        private void sATIŞLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
            {
                sf = new SatisForm();
            }
            sf.MdiParent = this;
            sf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dERGİSAYILARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DergiSayiForm df = new DergiSayiForm();
            if (df.IsDisposed)
            {
                df = new DergiSayiForm();
            }
            df.MdiParent = this;
            df.Show();
        }
        PersonelForm pf = new PersonelForm();
        private void pERSONELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf.IsDisposed)
            {
                pf = new PersonelForm();
            }
            pf.MdiParent = this;
            pf.Show();
        }
        MusterilerForm mf = new MusterilerForm();
        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
            {
                mf = new MusterilerForm();
            }
            mf.MdiParent = this;
            mf.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
