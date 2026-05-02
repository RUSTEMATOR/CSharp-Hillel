namespace HMW11._1;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter position number: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Fibonacci({n}) = {FibonacciHelper.Calculate(n)}");
    }
}