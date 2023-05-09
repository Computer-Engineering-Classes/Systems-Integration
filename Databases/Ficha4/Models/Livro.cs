namespace Ficha4.Models;

public class Livro
{
    public int Id { get; init; }

    public string Titulo { get; init; } = string.Empty;

    public string Autor { get; init; } = string.Empty;

    public string Editor { get; init; } = string.Empty;

    public bool Estado { get; init; }

    public DateTime DataCompra { get; init; }
}