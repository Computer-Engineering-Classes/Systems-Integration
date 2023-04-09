using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost;Database=AlunosDb;";
using var connection = new SqlConnection(connectionString);

while (true)
{
    Console.WriteLine("1 - Listar alunos");
    Console.WriteLine("2 - Inserir aluno");
    Console.WriteLine("3 - Remover aluno");
    Console.WriteLine("4 - Atualizar média do aluno");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Digite a opção desejada: ");
    var opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            using (var command = new SqlCommand("SELECT * FROM Alunos_2019", connection))
            {
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["MT12019_ID"]}");
                    Console.WriteLine($"Nome: {reader["MT12019_Name"]}");
                    Console.WriteLine($"Data: {reader["MT12019_Data"]}");
                    Console.WriteLine($"Média: {reader["MT12019_MediaAluno"]}");
                    Console.WriteLine();
                }

                connection.Close();
            }

            break;
        case 2:
            using (var command =
                   new SqlCommand(
                       "INSERT INTO Alunos_2019 (MT12019_Name, MT12019_Data, MT12019_MediaAluno) VALUES (@Nome, @Data, @Media)",
                       connection))
            {
                Console.WriteLine("Digite o nome do aluno: ");
                var nome = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Digite a data:");
                var data = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Digite a média do aluno: ");
                var media = Convert.ToSingle(Console.ReadLine());
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Data", data);
                command.Parameters.AddWithValue("@Media", media);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            break;
        case 3:
            using (var command = new SqlCommand("DELETE FROM Alunos_2019 WHERE MT12019_ID = @Id", connection))
            {
                Console.WriteLine("Digite o ID do aluno: ");
                var id = Convert.ToInt32(Console.ReadLine());
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            break;
        case 4:
            using (var command =
                   new SqlCommand("UPDATE Alunos_2019 SET MT12019_MediaAluno = @Media WHERE MT12019_ID = @Id",
                       connection))
            {
                Console.WriteLine("Digite o ID do aluno: ");
                var id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a nova média do aluno: ");
                var media = Convert.ToSingle(Console.ReadLine());
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Media", media);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            break;
        case 5:
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}