namespace Ficha4.Models;

public class Aluno
{
    public int Id { get; init; }

    public string Nome { get; init; } = string.Empty;

    public string Endereco { get; init; } = string.Empty;

    public decimal Garantia { get; init; }
}