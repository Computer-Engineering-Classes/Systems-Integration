using System.Data;
using Microsoft.Data.SqlClient;

namespace Ficha4;

public static class LivrosDbContext
{
    private const string ConnectionString =
        "Server=localhost;Database=Livros;Trusted_Connection=True;TrustServerCertificate=True;";

    public static IEnumerable<Livro> GetLivros(int id)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "GetLivros @Id",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();
        var reader = command.ExecuteReader();
        if (!reader.HasRows)
            yield break;
        while (reader.Read())
        {
            var livro = new Livro
            {
                Id = (int)reader["Id"],
                Titulo = (string)reader["Titulo"],
                Autor = (string)reader["Autor"],
                Editor = (string)reader["Editor"],
                Estado = (bool)reader["Estado"],
                DataCompra = reader.GetFieldValue<DateOnly>("DataCompra")
            };
            yield return livro;
        }
    }

    public static void AddLivro(Livro livro)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "CreateLivro @Titulo, @Autor, @Editor",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Titulo", livro.Titulo);
        command.Parameters.AddWithValue("@Autor", livro.Autor);
        command.Parameters.AddWithValue("@Editor", livro.Editor);
        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void UpdateLivro(int id, bool estado)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "UpdateLivro @Id, @Estado",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Id", id);
        command.Parameters.AddWithValue("@Estado", estado);
        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void DeleteLivro(int id)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "DeleteLivro @Id",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();
        command.ExecuteNonQuery();
    }
}