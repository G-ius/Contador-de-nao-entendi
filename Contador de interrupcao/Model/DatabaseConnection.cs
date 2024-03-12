using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_interrupcao.Model
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    public class DatabaseConnection
    {
        private static SQLiteConnection sqliteConnection;
        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection($@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\\dados\\Cadastro.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                if (!File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory}\\dados\\Cadastro.sqlite"))
                {
                    System.IO.Directory.CreateDirectory("dados");
                    SQLiteConnection.CreateFile($@"{AppDomain.CurrentDomain.BaseDirectory}\dados\Cadastro.sqlite");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
