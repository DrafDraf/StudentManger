using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class TestCSDLAccess :DatabaseAccess
    {
        public List<TestMonHoc> GetListMonHoc()
        {
            List<TestMonHoc> li = new List<TestMonHoc>();
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from MONHOC";
                com.Connection = conn;

                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ma = reader.GetString(0);
                    string ten = reader.GetString(1);

                    TestMonHoc t = new TestMonHoc() { MaMH = ma, TenMH = ten };
                    li.Add(t);
                }
                reader.Close();
                CloseConnection();
            }
            catch
            {
                MessageBox.Show("khong the ket noi toi co so du lieu, vui long kiem tra lai ket noi");
            }
            
            
            return li;
        }
    }
}
