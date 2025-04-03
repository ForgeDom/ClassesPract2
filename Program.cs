using ClassesPract2.Classes;
namespace ClassesPract2;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CreditCard card1 = new CreditCard("1234567890123456", "John Doe", "123", "12/23", 1000);
            CreditCard card2 = new CreditCard("6543210987654321", "Jane Smith", "321", "11/24", 2000);

            Console.WriteLine("Card 1 information:");
            Console.WriteLine(card1);
            Console.WriteLine("\nCard 2 information:");
            Console.WriteLine(card2);

            Console.WriteLine("\nAdding 500 to Card 1:");
            card1 += 500;
            Console.WriteLine(card1);

            Console.WriteLine("\nSubtracting 300 from Card 2:");
            card2 -= 300;
            Console.WriteLine(card2);

            Console.WriteLine($"\nCard 1 == Card 2: {card1 == card2}");
            Console.WriteLine($"Card 1 != Card 2: {card1 != card2}");
            Console.WriteLine($"Card 1 < Card 2: {card1 < card2}");
            Console.WriteLine($"Card 1 > Card 2: {card1 > card2}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}