using Ficha4.Managers;

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Selecionar Livros");
    Console.WriteLine("2 - Adicionar Livro");
    Console.WriteLine("3 - Remover Livro");
    Console.WriteLine("4 - Selecionar Alunos");
    Console.WriteLine("5 - Criar Aluno");
    Console.WriteLine("6 - Atualizar Aluno");
    Console.WriteLine("7 - Remover Aluno");
    Console.WriteLine("8 - Requisitar Livro");
    Console.WriteLine("9 - Devolver Livro");
    Console.WriteLine("10 - Selecionar Empréstimos");
    Console.WriteLine("S - Sair");
    Console.Write("Opção: ");
    switch (Console.ReadLine())
    {
        case "1":
            LivrosManager.GetLivros();
            break;
        case "2":
            LivrosManager.AddLivro();
            break;
        case "3":
            LivrosManager.DeleteLivro();
            break;
        case "4":
            AlunosManager.GetAlunos();
            break;
        case "5":
            AlunosManager.AddAluno();
            break;
        case "6":
            AlunosManager.UpdateAluno();
            break;
        case "7":
            AlunosManager.DeleteAluno();
            break;
        case "8":
            LivrosManager.RequisitarLivro();
            break;
        case "9":
            LivrosManager.DevolverLivro();
            break;
        case "10":
            AlunosManager.GetEmprestimos();
            break;
        case "S":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}