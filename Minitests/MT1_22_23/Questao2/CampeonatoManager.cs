using System.Data;
using Microsoft.Data.SqlClient;
using Questao2.Models;
// ReSharper disable IdentifierTypo, StringLiteralTypo

namespace Questao2;

public static class CampeonatoManager
{
    private const string ConnStr =
        "Server=localhost;Database=MT1_22_23;Trusted_Connection=True;TrustServerCertificate=True;";

    public static void CreateCampeonato(int ano)
    {
        using var connection = new SqlConnection(ConnStr);
        using var command = new SqlCommand
        {
            CommandText = "CreateCampeonato",
            CommandType = CommandType.StoredProcedure,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Ano", ano);
        var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        connection.Open();
        try
        {
            command.ExecuteNonQuery();
        }
        catch (SqlException)
        {
            Console.WriteLine("Erro ao criar campeonato! Ano deve ser maior que 2000.");
            return;
        }

        var result = (int)returnParameter.Value;
        Console.WriteLine(result == -1 ? "Campeonato já existe!" : "Campeonato criado com sucesso!");
    }

    public static List<Jogo> CalendarioCampeonato(int ano)
    {
        using var connection = new SqlConnection(ConnStr);
        using var command = new SqlCommand
        {
            CommandText = "GetJogosByAno @Ano",
            CommandType = CommandType.Text,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Ano", ano);

        connection.Open();
        using var reader = command.ExecuteReader();

        var jogos = new List<Jogo>();
        if (!reader.HasRows)
        {
            Console.WriteLine("Nenhum jogo encontrado!");
            return jogos;
        }

        while (reader.Read())
        {
            var jogo = new Jogo
            {
                Ano = (int)reader["Ano"],
                Casa = (int)reader["Casa"],
                Fora = (int)reader["Fora"],
                ResultadoFinal = (string)reader["ResultadoFinal"]
            };

            jogos.Add(jogo);
        }

        return jogos;
    }

    public static void CreateJogo(int ano, int casa, int fora)
    {
        using var connection = new SqlConnection(ConnStr);
        using var command = new SqlCommand
        {
            CommandText = "CreateJogo",
            CommandType = CommandType.StoredProcedure,
            Connection = connection
        };
        command.Parameters.AddWithValue("@Ano", ano);
        command.Parameters.AddWithValue("@Casa", casa);
        command.Parameters.AddWithValue("@Fora", fora);
        var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;
        connection.Open();
        try
        {
            command.ExecuteNonQuery();
        }
        catch (Exception)
        {
            Console.WriteLine("Erro ao criar jogo! Verifique se as equipas são > 0.");
            return;
        }

        var result = (int)returnParameter.Value;
        switch (result)
        {
            case 0:
                Console.WriteLine("Jogo criado com sucesso!");
                break;
            case -1:
                Console.WriteLine("Campeonato não existe!");
                break;
            case -2:
                Console.WriteLine("Jogo já existe!");
                break;
            case -3:
                Console.WriteLine("Campeonato já começou!");
                break;
        }
    }

    public static void AddResultado(int ano, int casa, int fora, string resultado)
    {
        using var connection = new SqlConnection(ConnStr);
        using var command = new SqlCommand
        {
            CommandText = "InsertResultado",
            CommandType = CommandType.StoredProcedure,
            Connection = connection
        };

        command.Parameters.AddWithValue("@Ano", ano);
        command.Parameters.AddWithValue("@Casa", casa);
        command.Parameters.AddWithValue("@Fora", fora);
        command.Parameters.AddWithValue("@Resultado", resultado);
        var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
        returnParameter.Direction = ParameterDirection.ReturnValue;

        connection.Open();
        command.ExecuteNonQuery();

        var result = (int)returnParameter.Value;
        switch (result)
        {
            case -1:
                Console.WriteLine("Jogo não existe!");
                break;
            case -2:
                Console.WriteLine("Jogo já tem resultado!");
                break;
            default:
                Console.WriteLine("Resultado adicionado com sucesso!");
                break;
        }
    }
}