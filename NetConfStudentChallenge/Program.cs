using Humanizer;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quantities: ");
HumanizerQuantities();
Console.WriteLine($"\nDate/Time manipulation: ");
HumanizerDates();

static void HumanizerQuantities()
{
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(3));
    Console.WriteLine("case".ToQuantity(0));
}

static void HumanizerDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

