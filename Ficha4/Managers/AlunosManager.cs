using Ficha4.Data;
using Ficha4.Models;

namespace Ficha4.Managers;

public static class AlunosManager
{
    public static IEnumerable<Aluno> GetAlunos()
    {
        Console.Write("Id do aluno (0 caso queira selecionar todos): ");
        return !int.TryParse(Console.ReadLine(), out var id)
            ? Enumerable.Empty<Aluno>()
            : LivrosDbContext.GetAlunos(id);
    }

    public static void AddAluno()
    {
        Console.Write("Nome do aluno: ");
        var nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome)) return;
        Console.Write("Endereço do aluno: ");
        var endereco = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(endereco)) return;
        Console.Write("Garantia do aluno: ");
        if (!decimal.TryParse(Console.ReadLine(), out var garantia)) return;
        var aluno = new Aluno
        {
            Nome = nome,
            Endereco = endereco,
            Garantia = garantia
        };
        LivrosDbContext.AdicionarAluno(aluno);
        Console.WriteLine("Aluno criado com sucesso!");
    }

    public static void UpdateGarantia()
    {
        Console.Write("Id do aluno: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        Console.Write("Garantia: ");
        if (!decimal.TryParse(Console.ReadLine(), out var garantia)) return;
        LivrosDbContext.UpdateGarantia(id, garantia);
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
        LivrosDbContext.UpdateAluno(aluno);
    }

    public static void PrintAlunos(IEnumerable<Aluno> alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine("Id: " + aluno.Id);
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Endereço: " + aluno.Endereco);
            Console.WriteLine("Garantia: " + aluno.Garantia);
            Console.WriteLine();
        }
    }

    public static void DeleteAluno()
    {
        Console.Write("Id do aluno: ");
        if (!int.TryParse(Console.ReadLine(), out var id)) return;
        LivrosDbContext.DeleteAluno(id);
    }
}