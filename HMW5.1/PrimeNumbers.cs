namespace HMW5._1;

public class PrimeNumbers
{
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        if (number % i == 0) return false;
        return true;
    }

    static void Run()
    {
        Console.Write("Введіть число N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N < 1)
        {
            Console.WriteLine("Будь ласка, введіть ціле число більше або рівно 2.");
            return;
        }

        for (int i = 2; i <= N; i++)                                    
        {
            if (IsPrime(i))                                                                                                                                                                                                            
                Console.WriteLine(i);
        }  
    }
}