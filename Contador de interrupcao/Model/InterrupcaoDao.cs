namespace Contador_de_interrupcao.Model
{
    using System;
    using System.Data;
    using System.Data.SQLite;

    namespace csharp_Sqlite
    {
        public class InterrupcaoDao
        {
            public InterrupcaoDao()
            { }

            public static void CriarTabelaSQlite()
            {
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS Interrupcoes(id INTEGER PRIMARY KEY AUTOINCREMENT, idInterruptor integer,Horario Varchar(50))";
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
                        cmd.CommandText = "SELECT * FROM Interrupcoes";
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
                        cmd.CommandText = "SELECT * FROM Interrupcoes Where Id=" + id;
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

            public static DataTable GetList()
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = @"select it.id as id,IIF(nome is null,'Indefinido',nome) as nome,Horario from Interrupcoes it
                                            left join Interruptores i on i.id = it.idInterruptor ";
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

            public static void Add(Interrupcao interrupcao)
            {
                try
                {
                    using (var cmd = DatabaseConnection.DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Interrupcoes(idInterruptor, Horario ) values (@idInterruptor, @Horario)";
                        cmd.Parameters.AddWithValue("@idInterruptor", interrupcao.idInterruptor);
                        cmd.Parameters.AddWithValue("@Horario", interrupcao.Horario);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Update(Interrupcao interrupcao)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(DatabaseConnection.DbConnection()))
                    {
                        if (interrupcao.id > 0)
                        {
                            cmd.CommandText = "UPDATE Interrupcoes SET idInterruptor=@idInterruptor,Horario = @Horario WHERE Id=@Id";
                            cmd.Parameters.AddWithValue("@Id", interrupcao.id);
                            cmd.Parameters.AddWithValue("@idInterruptor", interrupcao.idInterruptor);
                            cmd.Parameters.AddWithValue("@Horario", interrupcao.Horario);
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
                        cmd.CommandText = "DELETE FROM Interrupcoes Where Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void DeleteByInterruptor(int Id)
            {
                try
                {
                    using (var cmd = new SQLiteCommand(DatabaseConnection.DbConnection()))
                    {
                        cmd.CommandText = "DELETE FROM Interrupcoes Where IdInterruptor=@Id";
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
