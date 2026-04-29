using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isKatmani
{
    public static class sqlbaglantisi
    {
        public static SqlConnection anahtar= new SqlConnection(@"Server=HUAWEI\SQLEXPRESS01;Database=webservice1;Trusted_Connection=True;TrustServerCertificate=True;");
        public static SqlConnection getSqlbaglantisi()
        {
            //Bağlantı kapalı ise acc 
            if (sqlbaglantisi.anahtar.State == ConnectionState.Closed)
                anahtar.Open();
            return anahtar;
        }
    }
}
