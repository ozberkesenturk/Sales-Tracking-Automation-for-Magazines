using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergimORM.entity
{
   public class DergiSayilari
    {
        public DergiSayilari()
        {
            Aktif = true;
        }
        public int id { get; set; }
        public DateTime Tarih { get; set; }
        public int Sayi { get; set; }
        public string Aciklama { get; set; }
        public bool Aktif { get; set; }
    }
}
