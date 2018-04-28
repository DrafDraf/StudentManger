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
    public class HinhThucKiemTraAccess:DatabaseAccess
    {
        public HinhThucKiemTraAccess() : base()
        {}

        public List<HinhThucKiemTra> GetAllHinhThucKiemTra()
        {
            OpenConnection();
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * from HinhThucKiemTra";
            com.Connection = conn;

            SqlDataReader reader = com.ExecuteReader();
            List<HinhThucKiemTra> listHinhThucKiemTra = new List<HinhThucKiemTra>();

            while (reader.Read())
            {
                string ma = reader.GetString(0);
                String ten = reader.GetString(1);
                int heSo = reader.GetInt32(2);

                HinhThucKiemTra hinhThuc = new HinhThucKiemTra(ma, ten, heSo);
                listHinhThucKiemTra.Add(hinhThuc);
            }

            CloseConnection();
            return listHinhThucKiemTra;
        
        }
    }
}
