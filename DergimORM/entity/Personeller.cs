using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergimORM.entity
{
   public class Personeller
    {
        public Personeller()
        {
            Aktif = true;
        }
        public int id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TelNo { get; set; }
        public bool Aktif { get; set; }
    }
}
