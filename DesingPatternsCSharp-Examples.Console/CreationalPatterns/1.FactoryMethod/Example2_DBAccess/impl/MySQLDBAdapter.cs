using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2_DBAccess.impl
{
    internal class MySQLDBAdapter : IDBAdapter
    {
        private static readonly string DB_PROPERTIES = "./DBMySQL.properties";

        //Propiedades de los archivos properties
        private static readonly string DB_NAME_PROP = "dbname";
        private static readonly string DB_HOST_PROP = "host";
        private static readonly string DB_PASSWORD_PROP = "password";
        private static readonly string DB_PORT_PROP = "port";
        private static readonly string DB_USER_PROP = "user";

        /// <summary>
        /// MOC of a MySqlConection.
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            try
            {
                //String connectionString = CreateConnectionString();
                //DbConnection connection = new MySqlConnection(connectionString);
                DbConnection connection = null;
                //connection.Open();
                Console.WriteLine("Connection class ==> MySqlConnection ");
                return connection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }

        //private String CreateConnectionString()
        //{
        //    IDictionary<string, string> prop = null;
        //    using (TextReader reader = new StreamReader(DB_PROPERTIES))
        //    {
        //        prop = PropertiesLoader.Load(reader);
        //    }
        //    //Properties prop = PropertiesUtil.loadProperty(DB_PROPERTIES);
        //    String host = prop[DB_HOST_PROP];
        //    String port = prop[DB_PORT_PROP];
        //    String db = prop[DB_NAME_PROP];
        //    String user = prop[DB_USER_PROP];
        //    String password = prop[DB_PASSWORD_PROP];

        //    string connectionString = "SERVER=" + host + ";" + "DATABASE=" + db + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";
        //    Console.WriteLine("ConnectionString ==> " + connectionString);
        //    return connectionString;
        //}
    }
}
