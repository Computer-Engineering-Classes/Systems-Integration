using System.Data;
using Ficha4.Models;
using Microsoft.Data.SqlClient;

namespace Ficha4.Managers;

public static class LivrosManager
{
    private const string ConnectionString =
        "Server=localhost;Database=Livros;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void GetLivros()
    {
        Console.Write("Id do livro (0 caso queira selecionar todos): ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
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
        if (!reader.HasRows) return;
        while (reader.Read())
        {
            var livro = new Livro
            {
                Id = (int)reader["Id"],
                Titulo = (string)reader["Titulo"],
                Autor = (string)reader["Autor"],
                Editor = (string)reader["Editor"],
                Estado = (bool)reader["Estado"],
                DataCompra = (DateTime)reader["DataCompra"]
            };
            Console.WriteLine("Id: " + livro.Id);
            Console.WriteLine("Titulo: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Editor: " + livro.Editor);
            Console.WriteLine("Estado: " + livro.Estado);
            Console.WriteLine("Data de compra: " + livro.DataCompra);
            Console.WriteLine();
        }
    }

    public static void AddLivro()
    {
        Console.Write("Titulo do livro: ");
        var titulo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(titulo)) return;
        Console.Write("Autor do livro: ");
        var autor = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(autor)) return;
        Console.Write("Editor do livro: ");
        var editor = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(editor)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "CreateLivro @Titulo, @Autor, @Editor",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Titulo", titulo);
        command.Parameters.AddWithValue("@Autor", autor);
        command.Parameters.AddWithValue("@Editor", editor);
        connection.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Livro criado com sucesso!");
    }

    public static void DeleteLivro()
    {
        Console.Write("Id do livro: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
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
        Console.WriteLine("Livro eliminado com sucesso!");
    }

    public static void RequisitarLivro()
    {
        Console.Write("Id do aluno: ");
        if (!int.TryParse(Console.ReadLine(), out var alunoId)) return;
        Console.Write("Id do livro: ");
        if (!int.TryParse(Console.ReadLine(), out var livroId)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "RequisitarLivro",
            CommandType = CommandType.StoredProcedure,
            Connection = connection
        };
        command.Parameters.AddWithValue("@AlunoId", alunoId);
        command.Parameters.AddWithValue("@LivroId", livroId);
        var returnParameter = new SqlParameter
        {
            Direction = ParameterDirection.ReturnValue
        };
        command.Parameters.Add(returnParameter);
        connection.Open();
        command.ExecuteNonQuery();
        var result = (int)returnParameter.Value;
        Console.WriteLine(result == 0 ? "Livro requisitado com sucesso!" : "O livro já se encontra requisitado!");
    }

    public static void DevolverLivro()
    {
        Console.Write("Id do livro: ");
        if (!int.TryParse(Console.ReadLine(), out var livroId)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "DevolverLivro",
            CommandType = CommandType.StoredProcedure,
            Connection = connection
        };
        command.Parameters.AddWithValue("@LivroId", livroId);
        var returnParameter = new SqlParameter
        {
            Direction = ParameterDirection.ReturnValue
        };
        command.Parameters.Add(returnParameter);
        connection.Open();
        command.ExecuteNonQuery();
        var result = (int)returnParameter.Value;
        Console.WriteLine(result == 0 ? "Livro devolvido com sucesso!" : "O livro já se encontra devolvido!");
    }
}