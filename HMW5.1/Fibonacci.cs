namespace HMW5._1;

public static class FibonacciTask
{
    public static void Run()
    {
        Console.Write("Введіть кількість чисел N: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("N має бути цілим числом більше нуля.");
            return;
        }

        long a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a);
            if (i < n - 1) Console.Write(", ");

            long next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine();
    }
}
