using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MyConnection
    {
        #region field
       private string server;
       string database;
       string uid;
       string pwd;
       bool winNT;
        #endregion
        #region Properties
        public string Server {
            get { return server; }
            set { server = value; }
        }
        public string Database
        {
            get { return database; }
            set { database = value; }
        }
        public bool WinNT
        {
            get { return winNT; }
            set { winNT = value; }
        }
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        #endregion

        #region contructor
        public MyConnection()
        {

        }
        public MyConnection(string server, string database, string uid, string pwd, bool winNT)
        {
            this.server = server;
            this.database = database;
            this.uid = uid;
            this.pwd = pwd;
            this.winNT = winNT;
        }
        #endregion

        #region method
        public string ReadConnectionStringFormFile(string path)
        {
            //có thể đọc và đưa các giá trị của chuỗi kết nội vào thuộc tính của lớp myConnections
            //hoặc đọc nguyên chuỗi kết nối từ file.
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string line = sr.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] vs = line.Split(';');
                        this.server = vs[0].Substring(vs[0].IndexOf('='));
                        this.database = vs[1].Substring(vs[0].IndexOf('='));
                        this.uid = vs[2].Substring(vs[0].IndexOf('='));
                        this.pwd = vs[3].Substring(vs[0].IndexOf('='));
                        this.winNT = Convert.ToBoolean(vs[4].Substring(vs[0].IndexOf('=')));
                    }
                }
            }
            return GetConnectionString();

        }
        public void WriteConnectionStringToFile(string path, string server, string database, string uid, string pwd, bool winNT)
        {
            using(FileStream fs=new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write ))
            {
                using(StreamWriter sw=new StreamWriter(fs))
                {
                  sw.Write(string.Format("server={0};database={1};uid={2};pwd={3},winNt={4}",server,database,uid,pwd,winNT.ToString()));
                }
            }
        }
        public string GetConnectionString()
        {
            if(winNT)
            {
                return string.Format("server={0};database={1};integrated security=True;", server, database);
            }
            else
            {
                return string.Format("server={0};database={1};uid={2};pwd={3}", server, database,uid,pwd);
            }
        }
        #endregion 
    }
}
