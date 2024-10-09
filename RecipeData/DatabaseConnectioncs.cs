using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeData
{
    internal class DatabaseConnection
    {
        public static string DbConnection()
        {
            string server = //server;
            string database = // database name;
            string uid = "root";
            string password = //database password;
            string constring = "Server=" + server + "; database=" + database + "; uid=" + uid + "; pwd=" + password;


            return constring;
        }
    }
}
