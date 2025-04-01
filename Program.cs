using ClassesPract2.Class;
namespace ClassesPract2;

class Program
{
    static void Main(string[] args)
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1.Input(2, 2, 1, 5);
        matrix1.Display();

        Matrix matrix2 = new Matrix(2, 2);
        matrix2.Input(2, 2, 1, 5);
        matrix2.Display();

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine("Sum of matrices:");
        sum.Display();

        Matrix difference = matrix1 - matrix2;
        Console.WriteLine("Difference of matrices:");
        difference.Display();

        Matrix product = matrix1 * matrix2;
        Console.WriteLine("Product of matrices:");
        product.Display();

        Matrix scalarProduct = matrix1 * 2;
        Console.WriteLine("Matrix multiplied by scalar:");
        scalarProduct.Display();

        bool areEqual = matrix1 == matrix2;
        Console.WriteLine($"Matrices are equal: {areEqual}");

        bool areNotEqual = matrix1 != matrix2;
        Console.WriteLine($"Matrices are not equal: {areNotEqual}");
        
    }
}