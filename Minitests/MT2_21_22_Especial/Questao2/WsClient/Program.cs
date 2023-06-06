using System.Text;
using WsClient.CurrencyConverter;
using WsClient.TaxCalculator;

var currencyClient = new CurrencyConverterClient();
var taxClient = new TaxCalculatorClient();

Console.WriteLine("Escudos: ");
var escudos = decimal.Parse(Console.ReadLine() ?? string.Empty);

Console.OutputEncoding = Encoding.UTF8;
var euros = await currencyClient.EscudoToEuroAsync(escudos);
Console.WriteLine($"{escudos} escudos = {euros:C}");

var withTax = await taxClient.AddTaxAsync(euros);
Console.WriteLine($"With tax: {withTax:C}");