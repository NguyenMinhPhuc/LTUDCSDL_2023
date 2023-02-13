using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
   public class Database
    {
       SqlConnection cnn;
       SqlCommand cmd;
       SqlDataAdapter da;
       MyConnection myConnection;
       public Database()
       {
           myConnection=new MyConnection("MINHPHUC\\MSSQL2019","AdventureWorks2019","","",true);
           cnn = new SqlConnection() { ConnectionString = myConnection.GetConnectionString() };
       }
       public bool KiemTraKetNoi(ref string err)
       {
           try
           {
               cnn.Open();
               return true;
           }
           catch (Exception ex)
           {
               err = ex.Message;
               return false;
           }
           finally
           {
               cnn.Close();
           }
       }

       public void WriteConnectionString(string path, string server,string database,string uid, string pwd, bool winNT)
       {
           myConnection.WriteConnectionStringToFile(path, server, database, uid, pwd, winNT);
       }
        #region Các phương thức thác tác dữ liệu
       //1. Đọc dữ liệu theo dạng DataReader
       //2. Đọc dữ liệu trả về dataTable
       //3. Đọc dữ liệu trả về 1 giá trị duy nhất (object)
       //4. Thực thi các thử tục (thêm, sửa, xóa) ExcuteNonQuery
       //5. Đọc dữ liệu trả về cấu trức XML Document
        #endregion
    }
}
