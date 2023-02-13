using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace Pro_QuanLyBanHang2023.BusinessLayer
{
   public class BLL_Connections
    {
       Database data;
       public BLL_Connections()
       {
           data = new Database();
       }

       public bool KiemTraKetNoi(ref string err)
       {
           return data.KiemTraKetNoi(ref err);
       }

       public void WriteConnectionString(string path,string server,string database,string uid,string pwd, bool winNT)
       {
           data.WriteConnectionString(path, server, database, uid, pwd, winNT);
       }
    }
}
