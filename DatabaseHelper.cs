using System.Data.SQLite;
using WinFormsFakeStoreAPI;

public class DatabaseHelper
{
    private string connectionString = "Data Source=products.db;Version=3;"; // cria um ficheiro Data Base file no diretório do trabalho C:\Utilizadores\Eduardo\WinFormsFakeStoreAPI\bin\Debug\net8.0-windows

    public DatabaseHelper() //Cria a tabela dos produtos no SQLITE caso não exista
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS Products (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title TEXT,
                Price REAL,
                Description TEXT,
                Category TEXT,
                Image TEXT
            )";
            using (var command = new SQLiteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

    public void SaveProducts(List<Product> products) //Guarda os produtos
    {
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            foreach (var product in products)
            {
                string insertQuery = @"
                INSERT INTO Products (Title, Price, Description, Category, Image) 
                VALUES (@Title, @Price, @Description, @Category, @Image)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Title", product.Title);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Description", product.Description);
                    command.Parameters.AddWithValue("@Category", product.Category);
                    command.Parameters.AddWithValue("@Image", product.Image ?? "n/d");
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public List<Product> GetProducts() //Procura produtos guardados na BD do SQLITE e retorna a lista de objs <Product>
    {
        var products = new List<Product>();
        using (var connection = new SQLiteConnection(connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Products";
            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Title = reader["Title"].ToString(),
                            Price = Convert.ToDouble(reader["Price"]),
                            Description = reader["Description"].ToString(),
                            Category = reader["Category"].ToString(),
                            Image = reader["Image"].ToString()
                        });
                    }
                }
            }
        }
        return products;
    }
}
