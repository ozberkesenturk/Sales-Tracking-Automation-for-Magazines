using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DergimORM
{
   public class Tools
    {
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get
            {
                if (baglanti==null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                }
                return baglanti;
            }
            
        }

    }
}
