using Ficha4.Managers;

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Selecionar Livros");
    Console.WriteLine("2 - Adicionar Livro");
    Console.WriteLine("3 - Remover Livro");
    Console.WriteLine("4 - Selecionar Alunos");
    Console.WriteLine("5 - Criar Aluno");
    Console.WriteLine("6 - Atualizar Garantia");
    Console.WriteLine("7 - Atualizar Aluno");
    Console.WriteLine("8 - Remover Aluno");
    Console.WriteLine("9 - Requisitar Livro");
    Console.WriteLine("10 - Devolver Livro");
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
            LivrosManager.DeleteLivro();
            break;
        case "4":
            var alunos = AlunosManager.GetAlunos();
            AlunosManager.PrintAlunos(alunos);
            break;
        case "5":
            AlunosManager.AddAluno();
            break;
        case "6":
            AlunosManager.UpdateGarantia();
            break;
        case "7":
            AlunosManager.UpdateAluno();
            break;
        case "8":
            AlunosManager.DeleteAluno();
            break;
        case "9":
            LivrosManager.RequisitarLivro();
            break;
        case "10":
            LivrosManager.DevolverLivro();
            break;
        case "S":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}