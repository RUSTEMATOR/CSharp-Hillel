namespace HMW5._1;

public static class SalariesTask
{
    public static void Run()
    {
        Console.WriteLine("Кількість працівників Вашої комипанії:");

        if (!int.TryParse(Console.ReadLine(), out int employeeCount) || employeeCount <= 0)
        {
            Console.WriteLine("Кількість працівників має бути невід'ємним цілим числом. Спробуйте ще раз.");
            return;
        }

        decimal[] salaries = new decimal[employeeCount];
        decimal totalSalary = 0;

        for (int i = 0; i < employeeCount; i++)
        {
            while (true)
            {
                Console.Write($"Введіть заробіток працівника #{i + 1}:");

                if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
                {
                    Console.WriteLine("Невірний формат заробітку. Введіть число. Спробуйте ще раз.");
                    continue;
                }

                if (salary < 0)
                {
                    Console.WriteLine("Заробіток не може бути від'ємним. Спробуйте ще раз.");
                    continue;
                }

                salaries[i] = salary;
                totalSalary += salary;
                break;
            }
        }

        decimal averageSalary = totalSalary / employeeCount;

        Console.WriteLine("\n=== Результати ===");
        Console.WriteLine($"Кількість працівників: {employeeCount}");
        Console.WriteLine($"Загальний заробіток: {totalSalary:C2}");
        Console.WriteLine($"Середній заробіток: {averageSalary:C2}");

        Console.WriteLine("\n=== Деталі заробітків ===");
        for (int i = 0; i < salaries.Length; i++)
        {
            Console.WriteLine($"Працівник #{i + 1}: {salaries[i]:C2}");
        }
    }
}