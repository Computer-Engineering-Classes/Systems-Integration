using CountriesApiConsole;

while (true)
{
    Console.WriteLine("Countries API Menu:");
    Console.WriteLine("\t1. Get all countries");
    Console.WriteLine("\t2. Get country by name");
    Console.WriteLine("\t3. Exit");
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            var countries = await CountriesApi.GetCountries();
            Console.WriteLine(countries);
            break;
        case "2":
            Console.Write("Enter name: ");
            var name = Console.ReadLine() ?? string.Empty;
            var country = await CountriesApi.GetCountry(name);
            if (country == null)
                Console.WriteLine("Country not found");
            else
                Console.WriteLine("Population: " + country["population"]);
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}