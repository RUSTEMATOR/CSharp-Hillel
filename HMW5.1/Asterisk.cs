namespace HMW5._1;

public static class AsteriskTask
{
    public static void Run()
    {
        Console.WriteLine("Введіть кількість рядків графіка:");

        if (!int.TryParse(Console.ReadLine(), out int rows) || rows <= 0)
        {
            Console.WriteLine("Кількість рядків має бути позитивним числом. Спробуйте ще раз.");
            return;
        }

        Console.WriteLine("\n=== Графік ===");
        for (int i = 1; i <= rows; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}
