try
{
    Console.Write("Enter the dividend: ");
    double dividend = double.Parse(Console.ReadLine());

    Console.Write("Enter the divisor: ");
    double divisor = double.Parse(Console.ReadLine());

    if (divisor == 0)
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    else
    {
        double result = dividend / divisor;
        Console.WriteLine($"{dividend} / {divisor} = {result}");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
}
