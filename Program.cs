using ClassesPract2.Class;
namespace ClassesPract2;

class Program
{
    static void Main(string[] args)
    {
        Subhelper employee1 = new Subhelper("Employee1", "2020-01-01", "1234567890", "my@gmail.com", "Manager", "Manage", 1000);
        Subhelper employee2 = new Subhelper("Employee2", "2021-01-01", "0987654321", "his@gmail.com", "Boss", "Shout", 2000);

        Console.WriteLine("Employee 1:");
        employee1.Display();
        Console.WriteLine("Employee 2:");
        employee2.Display();
        
        Console.WriteLine("Enter the amount to add to Employee 1's salary:");
        int amountToAdd = int.Parse(Console.ReadLine());
        employee1.Salary += amountToAdd;
        Console.WriteLine("Employee 1's salary after addition:");
        employee1.Display();
        Console.WriteLine("Enter the amount to subtract from Employee 1's salary:");
        int amountToSubtract = int.Parse(Console.ReadLine());
        employee1.Salary -= amountToSubtract;
        Console.WriteLine("Employee 1's salary after subtraction:");
        employee1.Display();
        Console.WriteLine("Incrementing Employee 1's salary:");
        employee1.Salary++;
        employee1.Display();
        Console.WriteLine("Decrementing Employee 1's salary:");
        employee1.Salary--;
        employee1.Display();
        
    }
}