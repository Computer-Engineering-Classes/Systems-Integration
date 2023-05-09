using System.Data;
using Ficha4.Models;
using Microsoft.Data.SqlClient;

namespace Ficha4.Managers;

public static class AlunosManager
{
    private const string ConnectionString =
        "Server=localhost;Database=Livros;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void GetAlunos()
    {
        Console.Write("Id do aluno (0 caso queira selecionar todos): ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "GetAlunos @Id",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Id", id);

        connection.Open();
        var reader = command.ExecuteReader();
        if (!reader.HasRows) return;

        while (reader.Read())
        {
            var aluno = new Aluno
            {
                Id = (int)reader["Id"],
                Nome = (string)reader["Nome"],
                Endereco = (string)reader["Endereco"],
                Garantia = (decimal)reader["Garantia"]
            };

            Console.WriteLine("Id: " + aluno.Id);
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Endereço: " + aluno.Endereco);
            Console.WriteLine("Garantia: " + aluno.Garantia);
            Console.WriteLine();
        }
    }

    public static void AddAluno()
    {
        Console.Write("Nome do aluno: ");
        var nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome)) return;
        Console.Write("Endereço do aluno: ");
        var endereco = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(endereco)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "CreateAluno @Nome, @Endereco",
            CommandType = CommandType.Text,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Nome", nome);
        command.Parameters.AddWithValue("@Endereco", endereco);

        connection.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("Aluno criado com sucesso!");
    }

    public static void UpdateAluno()
    {
        Console.Write("Id do aluno: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        Console.Write("Nome do aluno: ");
        var nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome)) return;
        Console.Write("Endereço do aluno: ");
        var endereco = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(endereco)) return;
        var aluno = new Aluno
        {
            Id = id,
            Nome = nome,
            Endereco = endereco
        };
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "UpdateAluno @Id, @Nome, @Endereco",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Id", aluno.Id);
        command.Parameters.AddWithValue("@Nome", aluno.Nome);
        command.Parameters.AddWithValue("@Endereco", aluno.Endereco);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void DeleteAluno()
    {
        Console.Write("Id do aluno: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "DeleteAluno @Id",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Id", id);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void GetEmprestimos()
    {
        Console.Write("Id do aluno (0 caso queira selecionar todos): ");
        if (!int.TryParse(Console.ReadLine(), out var alunoId)) return;
        Console.Write("Id do livro (0 caso queira selecionar todos): ");
        if (!int.TryParse(Console.ReadLine(), out var livroId)) return;
        Console.Write("Atrasados? (y/n) ");
        var key = Console.ReadKey();
        var atrasados = key.Key == ConsoleKey.Y;
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "GetEmprestimos @AlunoId, @LivroId, @Atrasados",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@AlunoId", alunoId);
        command.Parameters.AddWithValue("@LivroId", livroId);
        command.Parameters.AddWithValue("@Atrasados", atrasados);

        connection.Open();
        var reader = command.ExecuteReader();
        if (!reader.HasRows)
            return;

        while (reader.Read())
        {
            var emprestimo = new Emprestimo
            {
                LivroId = (int)reader["LivroId"],
                AlunoId = (int)reader["AlunoId"],
                DataRequisicao = (DateTime)reader["DataRequisicao"],
                DataEntrega = (DateTime)reader["DataEntrega"]
            };

            Console.WriteLine("Livro: " + emprestimo.LivroId);
            Console.WriteLine("Aluno: " + emprestimo.AlunoId);
            Console.WriteLine("Data de Requisição: " + emprestimo.DataRequisicao);
            Console.WriteLine("Data de Entrega: " + emprestimo.DataEntrega);
            Console.WriteLine();
        }
    }
}