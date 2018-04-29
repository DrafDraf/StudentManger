using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChuongTrinhDaoTaoAccess:DatabaseAccess
    {
        public ChuongTrinhDaoTaoAccess() : base()
        {  }

        public List<ChuongTrinhDaoTao> GetAllCTDT()
        {
            OpenConnection();
            List<ChuongTrinhDaoTao> listCTDT = new List<ChuongTrinhDaoTao>();

            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from ChuongTrinhDaoTao";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                string maLop = reader.GetString(0);
                string maMon = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                ChuongTrinhDaoTao ctdt = new ChuongTrinhDaoTao(maLop, maMon, heSo);
                listCTDT.Add(ctdt);
            }

            reader.Close();
            CloseConnection();
            return listCTDT;
        }
        
    }
}
