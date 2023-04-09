using System.Net.Http.Json;
using Questao2;

const string apiUrl = "http://localhost/mt1";
var client = new HttpClient();
while (true)
{
    Console.WriteLine("1 - Listar Utilizadores");
    Console.WriteLine("2 - Inserir Utilizador");
    Console.WriteLine("3 - Alterar Estado de Utilizador");
    Console.WriteLine("S - Sair");
    var opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            var utilizadores = await client.GetFromJsonAsync<List<Utilizador>>($"{apiUrl}/utilizadores");
            if (utilizadores == null) break;
            foreach (var utilizador in utilizadores)
            {
                Console.WriteLine($"Id: {utilizador.Id}");
                Console.WriteLine($"Nome: {utilizador.Nome}");
                Console.WriteLine($"Username: {utilizador.Username}");
                Console.WriteLine($"Password: {utilizador.Password}");
                Console.WriteLine($"Email: {utilizador.Email}");
                Console.WriteLine($"Estado: {utilizador.Estado}");
                Console.WriteLine();
            }

            break;
        case "2":
            Console.Write("Nome: ");
            var nome = Console.ReadLine() ?? string.Empty;
            Console.Write("Username: ");
            var username = Console.ReadLine() ?? string.Empty;
            Console.Write("Password: ");
            var password = Console.ReadLine() ?? string.Empty;
            Console.Write("Email: ");
            var email = Console.ReadLine() ?? string.Empty;
            Console.Write("Estado: ");
            var estado = Convert.ToBoolean(Console.ReadLine());
            var novoUtilizador = new Utilizador
            {
                Nome = nome,
                Username = username,
                Password = password,
                Email = email,
                Estado = estado
            };
            await client.PostAsJsonAsync($"{apiUrl}/utilizadores", novoUtilizador);
            break;
        case "3":
            Console.Write("Id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Estado: ");
            var novoEstado = Convert.ToBoolean(Console.ReadLine());
            await client.PatchAsJsonAsync($"{apiUrl}/utilizadores/{id}", new { Estado = novoEstado });
            break;
        case "S":
            return;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}