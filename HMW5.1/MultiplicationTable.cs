namespace HMW5._1;

public class MultiplicationTable
{
    public static void Run()
    {
        Console.Write("Введіть число: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Будь ласка, введіть ціле число.");
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}