namespace Ficha4.Models;

public class Emprestimo
{
    public int LivroId { get; init; }

    public int AlunoId { get; init; }

    public DateTime DataRequisicao { get; init; }

    public DateTime DataEntrega { get; init; }
}