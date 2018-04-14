using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergimORM.entity
{
    public class Satislar
    {
        public Satislar()
        {
            Aktif = true;
        }
        public int id { get; set; }
        public int MusteriID { get; set; }
        public int DergiSayiID { get; set; }
        public int PersonelID { get; set; }
        public int SayiAdedi { get; set; }
        public decimal SatisTutari { get; set; }
        public string Aciklama { get; set; }
        public bool Aktif { get; set; }
    }
}
