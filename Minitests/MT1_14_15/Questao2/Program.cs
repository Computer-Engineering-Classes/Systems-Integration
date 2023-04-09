using System.Net.Http.Json;

const string calendarId = "primary";
const string apiUrl = $"https://www.googleapis.com/calendar/v3/calendars/{calendarId}/events";
var client = new HttpClient();

while (true)
{
    Console.WriteLine("1 - List events");
    Console.WriteLine("2 - Add event");
    Console.WriteLine("3 - Bogus POST request (for testing)");
    Console.WriteLine("4 - Exit");
    Console.Write("Enter your choice: ");
    var choice = Console.ReadLine();
    HttpResponseMessage response;
    string content;
    switch (choice)
    {
        case "1":
            response = await client.GetAsync(apiUrl);
            content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            break;
        case "2":
            Console.Write("Enter event summary: ");
            var summary = Console.ReadLine();
            Console.Write("Enter event start date (yyyy-MM-dd): ");
            var startDate = Console.ReadLine();
            Console.Write("Enter event start time (HH:mm): ");
            var startTime = Console.ReadLine();
            Console.Write("Enter event end date (yyyy-MM-dd): ");
            var endDate = Console.ReadLine();
            Console.Write("Enter event end time (HH:mm): ");
            var endTime = Console.ReadLine();
            var eventToAdd = new
            {
                Summary = summary,
                Start = new
                {
                    DateTime = DateTime.Parse($"{startDate}T{startTime}:00"),
                    TimeZone = "America/New_York"
                },
                End = new
                {
                    DateTime = DateTime.Parse($"{endDate}T{endTime}:00"),
                    TimeZone = "America/New_York"
                }
            };
            response = await client.PostAsJsonAsync(apiUrl, eventToAdd);
            content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            break;
        case "3":
            Console.WriteLine("Always include email: ");
            var email = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Max attendees: ");
            var maxAttendees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Time zone: ");
            var timeZone = Console.ReadLine() ?? "America/New_York";
            Console.WriteLine("Fields: ");
            var fields = Console.ReadLine() ?? string.Empty;
            var query = new Dictionary<string, object>
            {
                ["alwaysIncludeEmail"] = email,
                ["maxAttendees"] = maxAttendees,
                ["timeZone"] = timeZone,
                ["fields"] = fields
            };
            response = await client.PostAsJsonAsync(apiUrl, query);
            content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}