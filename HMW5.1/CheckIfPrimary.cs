namespace HMW5._1;

public class CheckIfPrimary
{
    public static void Run()
    {
        Console.Write("Введіть число: ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number < 1)
        {
            Console.WriteLine("Будь ласка, введіть ціле число більше або рівно 1.");
            return;
        }
        
        if (IsPrime(number))
            Console.WriteLine($"{number} є простим числом.");
        else
            Console.WriteLine($"{number} не є простим числом.");
    }

    public static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
            if (number % i == 0) return false;
        return true;
    }
}