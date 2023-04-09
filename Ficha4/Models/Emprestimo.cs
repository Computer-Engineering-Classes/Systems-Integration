namespace Ficha4.Models;

public class Emprestimo
{
    public int Id { get; set; }

    public int LivroId { get; set; }

    public int AlunoId { get; set; }

    public DateTime DataRequisicao { get; set; }

    public DateTime DataEntrega { get; set; }
}