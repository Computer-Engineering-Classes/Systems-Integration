using Ficha4;

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Selecionar Livros");
    Console.WriteLine("2 - Adicionar Livro");
    Console.WriteLine("3 - Mudar Estado de Aluguer");
    Console.WriteLine("4 - Remover Livro");
    Console.WriteLine("S - Sair");
    Console.Write("Opção: ");
    switch (Console.ReadLine())
    {
        case "1":
            var livros = LivrosManager.GetLivros();
            LivrosManager.PrintLivros(livros);
            break;
        case "2":
            LivrosManager.AddLivro();
            break;
        case "3":
            LivrosManager.UpdateLivro();
            break;
        case "4":
            LivrosManager.DeleteLivro();
            break;
        case "S":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}