// ReSharper disable IdentifierTypo, StringLiteralTypo, CommentTypo, InconsistentNaming

namespace Questao2.Models;

public class Jogo
{
    public int Ano { get; set; }

    public int Casa { get; init; }

    public int Fora { get; init; }

    public string ResultadoFinal { get; init; } = "Por Disputar";
}