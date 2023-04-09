using System.Data;
using Ficha4.Models;
using Microsoft.Data.SqlClient;

namespace Ficha4.Data;

public static partial class LivrosDbContext
{
    public static IEnumerable<Aluno> GetAlunos(int id)
    {
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
        if (!reader.HasRows)
            yield break;

        while (reader.Read())
        {
            var aluno = new Aluno
            {
                Id = (int)reader["Id"],
                Nome = (string)reader["Nome"],
                Endereco = (string)reader["Endereco"],
                Garantia = (decimal)reader["Garantia"]
            };

            yield return aluno;
        }
    }

    public static void AdicionarAluno(Aluno aluno)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "CreateAluno @Nome, @Endereco, @Garantia",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Nome", aluno.Nome);
        command.Parameters.AddWithValue("@Endereco", aluno.Endereco);
        command.Parameters.AddWithValue("@Garantia", aluno.Garantia);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void UpdateGarantia(int id, decimal garantia)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "UpdateGarantia @Id, @Garantia",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Id", id);
        command.Parameters.AddWithValue("@Garantia", garantia);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void UpdateAluno(Aluno aluno)
    {
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

    public static void DeleteAluno(int id)
    {
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

    public static void GetEmprestimos(int id)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "GetEmprestimos @Id",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Id", id);

        connection.Open();
        command.ExecuteNonQuery();
    }

    public static void RequisitarLivro(int livroId, int alunoId)
    {
        using var connection = new SqlConnection(ConnectionString);
        using var command = new SqlCommand
        {
            CommandText = "CreateEmprestimo @LivroId, @AlunoId",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@LivroId", livroId);
        command.Parameters.AddWithValue("@AlunoId", alunoId);

        connection.Open();
        command.ExecuteNonQuery();
    }
}