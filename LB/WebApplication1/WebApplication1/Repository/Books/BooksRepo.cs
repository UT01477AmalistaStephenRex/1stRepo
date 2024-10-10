//using Microsoft.Data.Sqlite;
//using WebApplication1.Database;

//namespace WebApplication1.Repository.Books
//{
//    public class BooksRepo:IBooksRepo
//    {
//        private readonly string _connectionString;

//        public BooksRepo(string connectionString)
//        {
//            _connectionString = connectionString;
//        }

//        public IEnumerable<BookCategories> GetAll()
//        {
//            var bookscato = new List<BookCategories>();

//            using (var connection = new SqliteConnection(_connectionString))
//            {
//                connection.Open();
//                var command = connection.CreateCommand();
//                command.CommandText = "SELECT CategoryId, CategoryName";
//                using (var reader = command.ExecuteReader())
//                {
//                    while (reader.Read())
//                    {
//                        bookscato.Add(new BookCategories
//                        {
//                            CategoryId = reader.GetInt32(0),
//                            CategoryName = reader.GetString(1),

//                        });
//                    }
//                }
//            }
//            return bookscato;
//        }
//        public BookCategories GetById(int CatogeryId)
//        {
//            using (var connection = new SqliteConnection(_connectionString))
//            {
//                connection.Open();
//                var command = connection.CreateCommand();
//                command.CommandText = "SELECT CatogeryId, CatogeryName FROM BookCategories WHERE EmpId = @empId";
//                command.Parameters.AddWithValue("@CatogeryId", CatogeryId);
//                using (var reader = command.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        return new BookCategories
//                        {
//                            CategoryId = reader.GetInt32(0),
//                            CategoryName = reader.GetString(1),

//                        };
//                    }
//                }
//            }
//            return null;
//        }

//        public void Add(BookCategories bookCategories)
//        {
//            using (var connection = new SqliteConnection(_connectionString))
//            {
//                connection.Open();
//                var command = connection.CreateCommand();
//                command.CommandText = "INSERT INTO BookCategories (CategoryName) VALUES (@CatogeryName,)";
//                command.Parameters.AddWithValue("@CatogeryName", bookCategories.CategoryName);

//                command.ExecuteNonQuery();
//            }
//        }

//        public void Update(BookCategories bookCategories)
//        {
//            using (var connection = new SqliteConnection(_connectionString))
//            {
//                connection.Open();
//                var command = connection.CreateCommand();
//                command.CommandText = "UPDATE BookCategories SET CatogeryName = @CatogeryName, CatogeryName = @CategoryName  WHERE CatogeryId = @CatogeryId";
//                command.Parameters.AddWithValue("@CategoryId", bookCategories.CategoryId);
//                command.Parameters.AddWithValue("@CatogeryName", bookCategories.CategoryName);

//                command.ExecuteNonQuery();
//            }
//        }

//        public void Delete(int CategoryId)
//        {
//            using (var connection = new SqliteConnection(_connectionString))
//            {
//                connection.Open();
//                var command = connection.CreateCommand();
//                command.CommandText = "DELETE FROM BookCategories WHERE CategoryId = @CategoryId";
//                command.Parameters.AddWithValue("@CategoryId", CategoryId);
//                command.ExecuteNonQuery();
//            }
//        }
//    }
//}
