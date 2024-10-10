using Microsoft.Data.Sqlite;

namespace WebApplication1.Data
{
    public class Databaseinitializer
    {
        private readonly string _connectionstring;

        public Databaseinitializer(string connectionstring)
        {
            _connectionstring = connectionstring;
        }

        public void Initialize()
        {
            Console.WriteLine("Running DatabaseInitializer Initialize Fuction...");
            using (var connection = new SqliteConnection(_connectionstring))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        BookId INTEGER PRIMARY KEY,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Genre TEXT NOT NULL
                    );

   CREATE TABLE IF NOT EXISTS Members (
                        MemberId INTEGER PRIMARY KEY,
                        Name TEXT NOT NULL
                       
                    );

                    -- Insert sample data if tables are empty
                    INSERT OR IGNORE INTO Members (MemberId, Name) 
                             
                ";
                command.ExecuteNonQuery();
            }
        }
    }
}
