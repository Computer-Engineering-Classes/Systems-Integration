namespace Ficha4;

public static class LivrosManager
{
    public static IEnumerable<Livro> GetLivros()
    {
        Console.Write("Id do livro (0 caso queira selecionar todos): ");
        return !int.TryParse(Console.ReadLine(), out var id)
            ? Enumerable.Empty<Livro>()
            : LivrosDbContext.GetLivros(id);
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
        var livro = new Livro
        {
            Titulo = titulo,
            Autor = autor,
            Editor = editor
        };
        LivrosDbContext.AddLivro(livro);
        Console.WriteLine("Livro criado com sucesso!");
    }

    public static void UpdateLivro()
    {
        Console.Write("Id do livro: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        Console.Write("Estado (true/false): ");
        if (!bool.TryParse(Console.ReadLine(), out var estado)) return;
        LivrosDbContext.UpdateLivro(id, estado);
    }

    public static void DeleteLivro()
    {
        Console.Write("Id do livro: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        Console.Write("Estado (true/false): ");
        LivrosDbContext.DeleteLivro(id);
    }

    public static void PrintLivros(IEnumerable<Livro> livros)
    {
        foreach (var livro in livros)
        {
            Console.WriteLine("Id: " + livro.Id);
            Console.WriteLine("Título: " + livro.Titulo);
            Console.WriteLine("Autor: " + livro.Autor);
            Console.WriteLine("Editor: " + livro.Editor);
            Console.WriteLine("Data de compra: " + livro.DataCompra);
            Console.WriteLine("Emprestado? " + (livro.Estado ? "Sim" : "Não"));
            Console.WriteLine();
        }
    }
}