namespace Ficha4;

public class Livro
{
    public int Id { get; set; }
    
    public string Titulo { get; set; } = string.Empty;
    
    public string Autor { get; set; } = string.Empty;
    
    public string Editor { get; set; } = string.Empty;
    
    public DateTime DataCompra { get; set; }
    
    public bool Estado { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Titulo: {Titulo}, " +
               $"Autor: {Autor}, Editor: {Editor}, " +
               $"DataCompra: {DataCompra}, Estado: {Estado}";
    }
}