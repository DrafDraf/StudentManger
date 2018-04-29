using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class MonHocAccess:DatabaseAccess
    {
        public MonHocAccess():base()
        {}

        public List<MonHoc> GetAllMonHoc()
        {
            OpenConnection();

            List<MonHoc> listMonHoc = new List<MonHoc>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from MonHoc";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                string maMH = reader.GetString(0);
                string tenMH = reader.GetString(1);

                MonHoc monHoc = new MonHoc(maMH, tenMH);
                listMonHoc.Add(monHoc);
            }

            reader.Close();
            CloseConnection();
            return listMonHoc;
        }

        public bool XoaMonHoc(string maMH)
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from MonHoc where MaMonHoc=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar).Value = maMH;
            com.Connection = conn;

            try
            {
                int check = com.ExecuteNonQuery();
                if (check > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
