// ReSharper disable IdentifierTypo, StringLiteralTypo, CommentTypo, InconsistentNaming

using Questao2;

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Criar campeonato");
    Console.WriteLine("2 - Listar jogos de um campeonato");
    Console.WriteLine("3 - Criar jogo");
    Console.WriteLine("4 - Adicionar resultado");
    Console.Write("Opção: ");
    var opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.Write("Ano: ");
            var ano = Convert.ToInt32(Console.ReadLine());
            CampeonatoManager.CreateCampeonato(ano);
            break;
        case "2":
            Console.Write("Ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            var jogos = CampeonatoManager.CalendarioCampeonato(ano);
            foreach (var jogo in jogos)
                Console.WriteLine($"Casa: {jogo.Casa} - Fora: {jogo.Fora} - Resultado: {jogo.ResultadoFinal}");
            break;
        case "3":
            Console.Write("Ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Casa: ");
            var casa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fora: ");
            var fora = Convert.ToInt32(Console.ReadLine());
            if (casa == fora)
            {
                Console.WriteLine("Casa e Fora não podem ser iguais!");
                break;
            }

            CampeonatoManager.CreateJogo(ano, casa, fora);
            break;
        case "4":
            Console.Write("Ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Casa: ");
            casa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fora: ");
            fora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Resultado: ");
            var resultado = Console.ReadLine() ?? "Jogo não realizado";
            CampeonatoManager.AddResultado(ano, casa, fora, resultado);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}