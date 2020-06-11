using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YOSis
{
    public class SqlBaglantim
    {
        public SqlConnection baglanti() {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-IOLHRBT\SQLEXPRESS;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
