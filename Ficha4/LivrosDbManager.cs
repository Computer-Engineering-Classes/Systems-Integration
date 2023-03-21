using System.Data;
using Microsoft.Data.SqlClient;

namespace Ficha4;

public static class LivrosDbManager
{
    private const string ConnectionString =
        "Server=localhost;Database=Livros;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void GetLivros()
    {
        Console.WriteLine("Id do livro: ");
        var id = int.Parse(Console.ReadLine() ?? string.Empty);
        // Call the stored procedure
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand();
        command.CommandText = "GetLivros";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = connection;
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var livro = new Livro
            {
                Id = (int)reader["Id"],
                Titulo = (string)reader["Titulo"],
                Autor = (string)reader["Autor"],
                Editor = (string)reader["Editor"],
                DataCompra = (DateTime)reader["DataCompra"],
                Estado = (bool)reader["Estado"]
            };
            Console.WriteLine("Livro: " + livro);
        }
    }

    public static void CriarLivro()
    {
        Console.WriteLine("Titulo do livro: ");
        var titulo = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Autor do livro: ");
        var autor = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Editor do livro: ");
        var editor = Console.ReadLine() ?? string.Empty;
        var livro = new Livro
        {
            Titulo = titulo,
            Autor = autor,
            Editor = editor
        }; 
        // Call the stored procedure
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand();
        command.CommandText = "CreateLivro";
        command.CommandType = CommandType.StoredProcedure;
        command.Connection = connection;
        command.Parameters.AddWithValue("@Titulo", livro.Titulo);
        command.Parameters.AddWithValue("@Autor", livro.Autor);
        command.Parameters.AddWithValue("@Editor", livro.Editor);
        connection.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Livro criado com sucesso!");
    }
}