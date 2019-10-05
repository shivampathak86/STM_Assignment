using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FrameworkLibrary.Utility
{
 public  class ExcelReader
    {
        private  string TestDataFileConnection()
        {
            var fileName = Directory.GetCurrentDirectory() + @"\STM_Assignment_TestData.xls";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 8.0;", fileName);
            return con;
        }

        public  UserData GetTestData()
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [Sheet1$]");
                var value = connection.Query<UserData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }



        public class UserData
        {
           // public string Key { get; set; }
            public string Login
            { get; set; }
            public string Pwd { get; set; }
        }
    }
}
        


