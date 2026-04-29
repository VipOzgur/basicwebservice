using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace isKatmani
{
    public class VerilerSP
    {
        private ArrayList _liste;

        public VerilerSP()
        {
            _liste = new ArrayList();
            Doldur();
        }

        public ArrayList Liste()
        {
            return _liste;
        }

        public void Doldur()
        {
            SqlConnection conn = sqlbaglantisi.getSqlbaglantisi();
            SqlCommand com = new SqlCommand("sp_VeriGetir", conn);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                _liste.Add(new Veriler(
                    Convert.ToInt32(reader["Id"]),
                    reader["Data"].ToString(),
                    Convert.ToDateTime( reader["CreateDate"])
                ));
            }
            conn.Close();
        }
        public void Ekle(string data)
        {
            SqlConnection conn = sqlbaglantisi.getSqlbaglantisi();
            SqlCommand com=new SqlCommand("sp_VeriEkle", conn);
            com.CommandType=CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Data", data);
            com.Parameters.AddWithValue("@CreateDate",DateTime.Now);

            com.ExecuteNonQuery();
            conn.Close();
        }
        public void Sil(int id)
        {
            SqlConnection conn = sqlbaglantisi.getSqlbaglantisi();
            SqlCommand com=new SqlCommand("sp_VeriSil", conn);
            com.CommandType=CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Id", id);

            com.ExecuteNonQuery();
            conn.Close();
        }
    }
}
