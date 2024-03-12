namespace Contador_de_interrupcao.Model
{
    using System;
    using System.Data;
    using System.Data.SQLite;

    namespace csharp_Sqlite
    {
        public class interruptorDao
        {

            public interruptorDao()
            { }

            public static void CriarTabelaSQlite()
            {
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Interruptores(id INTEGER PRIMARY KEY AUTOINCREMENT, Nome Varchar(50), Setor VarChar(80))";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static DataTable Get()
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Interruptores";
                        da = new SQLiteDataAdapter(cmd.CommandText, DatabaseConnection.DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static DataTable GetRelatorio()
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"SELECT it.id,nome,count(i.id) as Interrupcoes,setor 
                                            FROM interruptores it
                                            left join Interrupcoes i on i.idInterruptor = it.id
                                            group by it.id,nome,setor";

                        da = new SQLiteDataAdapter(cmd.CommandText, DatabaseConnection.DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static DataTable Get(int id)
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Interruptores Where Id=" + id;
                        da = new SQLiteDataAdapter(cmd.CommandText, DatabaseConnection.DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Add(Interruptor interruptor)
            {
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Interruptores(Nome, setor ) values (@Nome, @Setor)";
                        cmd.Parameters.AddWithValue("@Nome", interruptor.nome);
                        cmd.Parameters.AddWithValue("@Setor", interruptor.setor);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Update(Interruptor interruptor)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(DatabaseConnection.DbConnection()))
                    {
                        if (interruptor.id > 0)
                        {
                            cmd.CommandText = "UPDATE Interruptores SET Nome=@Nome,Setor = @Setor WHERE Id=@Id";
                            cmd.Parameters.AddWithValue("@Id", interruptor.id);
                            cmd.Parameters.AddWithValue("@Nome", interruptor.nome);
                            cmd.Parameters.AddWithValue("@Setor", interruptor.setor);
                            cmd.ExecuteNonQuery();
                        }
                    };
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Delete(int Id)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(DatabaseConnection.DbConnection()))
                    {
                        cmd.CommandText = "DELETE FROM Interruptores Where Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            internal static void Insert(Interruptor interruptor)
            {
                throw new NotImplementedException();
            }
        }
    }
}
