using System.Net.Http.Json;
using Questao2;

const string apiUrl = "http://localhost/mt1";

while (true)
{
    Console.WriteLine("1 - Listar livros");
    Console.WriteLine("2 - Inserir livro");
    Console.WriteLine("3 - Alterar preço de livro");
    Console.WriteLine("99 - Sair");
    Console.Write("Opção: ");
    var option = Convert.ToInt32(Console.ReadLine());
    var client = new HttpClient();
    switch (option)
    {
        case 1: // Listar livros
            var response = await client.GetAsync($"{apiUrl}/livros");
            var livros = await response.Content.ReadFromJsonAsync<List<Livro>>();
            if (livros == null) break;
            foreach (var livro in livros)
            {
                Console.WriteLine($"ISBN: {livro.Isbn}");
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Edição: {livro.EdicaoNumero}");
                Console.WriteLine($"Data: {livro.EdicaoData}");
                Console.WriteLine($"Exemplares: {livro.EdicaoExemplares}");
                Console.WriteLine($"Preço: {livro.PrecoVenda}");
                Console.WriteLine();
            }

            break;
        case 2: // Inserir livro
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Edição: ");
            var edicao = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data: ");
            var data = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Exemplares: ");
            var exemplares = Convert.ToInt32(Console.ReadLine());
            Console.Write("Preço: ");
            var preco = Convert.ToDecimal(Console.ReadLine());
            var novoLivro = new Livro
            {
                Isbn = isbn ?? string.Empty,
                Titulo = titulo ?? string.Empty,
                EdicaoNumero = edicao,
                EdicaoData = data,
                EdicaoExemplares = exemplares,
                PrecoVenda = preco
            };
            await client.PostAsJsonAsync($"{apiUrl}/livros", novoLivro);
            break;
        case 3: // Alterar preço de Livro (através de ISBN)
            Console.Write("ISBN: ");
            var isbnLivro = Console.ReadLine();
            Console.Write("Preço: ");
            var precoLivro = Convert.ToDecimal(Console.ReadLine());
            await client.PatchAsJsonAsync($"{apiUrl}/livros/{isbnLivro}", new
            {
                preco_venda = precoLivro
            });
            break;
        case 99:
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}