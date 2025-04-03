using ClassesPract2.Classes;
namespace ClassesPract2;

class Program
{
    static void Main(string[] args)
    {
        City city1 = new City("CityA", "CountryA", 100000, "CodeA", new string[] { "District1", "District2" });
        City city2 = new City("CityB", "CountryB", 150000, "CodeB", new string[] { "District3", "District4" });

        Console.WriteLine("City 1 information:");
        city1.DisplayData();
        Console.WriteLine("\nCity 2 information:");
        city2.DisplayData();

        Console.WriteLine("\nAdding 5000 to City 1 population:");
        city1 += 5000;
        city1.DisplayData();

        Console.WriteLine("\nSubtracting 3000 from City 2 population:");
        city2 -= 3000;
        city2.DisplayData();

        Console.WriteLine($"\nCity 1 == City 2: {city1 == city2}");
        Console.WriteLine($"City 1 != City 2: {city1 != city2}");
    }
}