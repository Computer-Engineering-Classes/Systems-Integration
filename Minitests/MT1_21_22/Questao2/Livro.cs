using System.Text.Json.Serialization;

namespace Questao2;

public class Livro
{
    [JsonPropertyName("ISBN")]
    public string Isbn { get; init; } = string.Empty;
    
    [JsonPropertyName("titulo")]
    public string Titulo { get; init; } = string.Empty;
    
    [JsonPropertyName("edicao.numero")]
    public int EdicaoNumero { get; init; }
    
    [JsonPropertyName("edicao.data")]
    public DateTime EdicaoData { get; init; }

    [JsonPropertyName("edicao.exemplares")]
    public int EdicaoExemplares { get; init; }
    
    [JsonPropertyName("preco_venda")]
    public decimal PrecoVenda { get; init; }
}