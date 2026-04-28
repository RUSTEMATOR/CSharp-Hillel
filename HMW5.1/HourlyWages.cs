namespace HMW5._1;

public static class HourlyWages
{
    public static void Run()
    {
        Console.Write("Введіть кількість відпрацьованих годин: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal hours) || hours <= 0)
        {
            Console.WriteLine("Кількість годин має бути числом більше нуля.");
            return;
        }

        Console.Write("Введіть годинну ставку (грн): ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal hourlyRate) || hourlyRate <= 0)
        {
            Console.WriteLine("Годинна ставка має бути числом більше нуля.");
            return;
        }

        decimal totalWages = hours * hourlyRate;
        Console.WriteLine($"Загальна заробітна плата: {totalWages}");
    }
}
