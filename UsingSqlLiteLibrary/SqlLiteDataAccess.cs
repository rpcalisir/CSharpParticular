using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSqlLiteLibrary
{
    public class SqlLiteDataAccess
    {
        public static List<PersonModel> LoadFromDatabase()
        {
            using (IDbConnection dbConnection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = dbConnection.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveToDatabase(PersonModel person)
        {
            using (IDbConnection db = new SQLiteConnection(LoadConnectionString()))
            {
                db.Execute("insert into Person (FirstName, LastName) values (@FirstName, @LastName)", person);
            }
        }

        public static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
