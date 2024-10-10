using Microsoft.Data.Sqlite;
using WebApplication1.Database;

namespace WebApplication1.Repository
{
    public class MembersRepo : IMembersRepo
    {
        private readonly string _connectionString;

        public MembersRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Members> GetAll()
        {
            var members = new List<Members>();

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT MemberId,NICNumber ,Name";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        members.Add(new Members
                        {
                            MemberId = reader.GetInt32(0),
                            NICNumber = reader.GetDataTypeName(0),
                            Name = reader.GetString(1),

                        });
                    }
                }
            }
            return members;
        }

        //public Members GetById(int MembersId)
        //{
        //    using (var connection = new SqliteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = "SELECT MembersId, Name FROM Members WHERE MembersId = @MembersId";
        //        command.Parameters.AddWithValue("@MembersId", MembersId);
        //        using (var reader = command.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                return new Members
        //                {
        //                    MemberId = reader.GetInt32(0),
        //                    Name = reader.GetString(1),

        //                };
        //            }
        //        }
        //    }
        //    return null;
        //}

        //public void Add(Members bookCategories)
        //{
        //    using (var connection = new SqliteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = "INSERT INTO Members (CategoryName) VALUES (@Name,)";
        //        command.Parameters.AddWithValue("@CatogeryName", bookCategories.CategoryName);

        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void Update(Members bookCategories)
        //{
        //    using (var connection = new SqliteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = "UPDATE Members SET CatogeryName = @CatogeryName, Name = @Name  WHERE MembersId = @MembersId";
        //        command.Parameters.AddWithValue("@CategoryId", bookCategories.MembersId);
        //        command.Parameters.AddWithValue("@CatogeryName", bookCategories.CategoryName);

        //        command.ExecuteNonQuery();
        //    }
        //}

        //public void Delete(int MembersId)
        //{
        //    using (var connection = new SqliteConnection(_connectionString))
        //    {
        //        connection.Open();
        //        var command = connection.CreateCommand();
        //        command.CommandText = "DELETE FROM BookCategories WHERE MembersId = @MembersId";
        //        command.Parameters.AddWithValue("@MembersId", MembersId);
        //        command.ExecuteNonQuery();
        //    }
        //}
    }
}
