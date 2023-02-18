using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Xml;

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
        /// <summary>
        /// Phương thức kiểm tra kết nối
        /// </summary>
        /// <param name="err">Hiển thị lỗi. lỗi sẽ được lưu vào biến tham chiếu</param>
        /// <returns>True nếu kết nối thành công; ngược lại trả về false</returns>
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
        /// <summary>
        /// Phương thức lưu thông tin chuỗi kết nói vào file
        /// </summary>
        /// <param name="path">Đường dẫn file</param>
        /// <param name="server">Tên server name</param>
        /// <param name="database">Tên database</param>
        /// <param name="uid">Tên user name đăng nhập</param>
        /// <param name="pwd">Mật khẩu</param>
        /// <param name="winNT">Trạng thái kết nối</param>
       public void WriteConnectionString(string path, string server,string database,string uid, string pwd, bool winNT)
       {
           myConnection.WriteConnectionStringToFile(path, server, database, uid, pwd, winNT);
       }
        #region Các phương thức thác tác dữ liệu
       //1. Đọc dữ liệu theo dạng DataReader

       public SqlDataReader ReadDataBySqlDataReader(ref string err,string commandText,CommandType commandType,params SqlParameter[] param)
        {
            SqlDataReader sqlDataReader = null;
            try
            {
                //Mở kết nối
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                //Tạo đối tượng SqlCommand
                cmd = new SqlCommand() 
                {
                    Connection=cnn,
                    CommandText= commandText,
                    CommandType= commandType,
                    CommandTimeout=3600,
                };
                //Thêm tham số cho thủ tục
                if (param != null)
                {
                    foreach (SqlParameter item in param)
                    {
                        cmd.Parameters.Add(item);
                    }
                }  
                //Thực thi đối tượng Command
                sqlDataReader = cmd.ExecuteReader();
                //Chú ý không đóng kết nối trong trường hợp trả về đối tượng SqlDatareader.
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return sqlDataReader;
        }
        //2. Đọc dữ liệu trả về dataTable
        //3. Đọc dữ liệu trả về 1 giá trị duy nhất (object)
        public object MyExcuteScalar(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            try
            {
                //B1. Mở kết nối
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                //B2. Khởi tạo SqlCommand
                cmd = new SqlCommand()
                {
                    Connection = cnn,
                    CommandText = commandText,
                    CommandType = commandType,
                    CommandTimeout = 3600
                };
                //B3. Thêm tham số cho SqlCommand
                if (sqlParameters != null)
                {
                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //B4. Thực thi phương thức của Command
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }
        //4. Thực thi các thử tục (thêm, sửa, xóa) ExcuteNonQuery
        public bool MyExcuteNonQuery(ref string err,ref int rows,string commandText,CommandType  commandType,params SqlParameter[] sqlParameters)
        {
            try
            {
                //B1. Mở kết nối
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                //B2. Khởi tạo SqlCommand
                cmd = new SqlCommand()
                {
                    Connection = cnn,
                    CommandText = commandText,
                    CommandType = commandType,
                    CommandTimeout = 3600
                };
                //B3. Thêm tham số cho SqlCommand
                if (sqlParameters != null)
                {
                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //B4. Thực thi phương thức của Command
                rows = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                err=ex.Message;
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
        //5. Đọc dữ liệu trả về cấu trức XML Document
        public XmlReader MyExcuteXmlReader(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            try
            {
                //B1. Mở kết nối
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                //B2. Khởi tạo SqlCommand
                cmd = new SqlCommand()
                {
                    Connection = cnn,
                    CommandText = commandText,
                    CommandType = commandType,
                    CommandTimeout = 3600
                };
                //B3. Thêm tham số cho SqlCommand
                if (sqlParameters != null)
                {
                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //B4. Thực thi phương thức của Command
                return cmd.ExecuteXmlReader();
               
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return null;
            }
            finally
            {
                cnn.Close();
            }
        }
        //6 trả về datatable
        public DataTable GetDataTable(ref string err, string commandText, CommandType commandType, params SqlParameter[] sqlParameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //B1. Mở kết nối
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
                cnn.Open();
                //B2. Khởi tạo SqlCommand
                cmd = new SqlCommand()
                {
                    Connection = cnn,
                    CommandText = commandText,
                    CommandType = commandType,
                    CommandTimeout = 3600
                };
                //B3. Thêm tham số cho SqlCommand
                if (sqlParameters != null)
                {
                    foreach (SqlParameter item in sqlParameters)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                //B4. Thực thi phương thức của Command
                da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return dataTable;
            }
            finally
            {
                cnn.Close();
            }
        }

        #endregion
    }
}
