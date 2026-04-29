while (true)
{
    Console.Write("Enter a number:");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        Console.WriteLine($"You entered: {number}");
        break;
    }
    Console.WriteLine($"{input} is not a valid number. Please try again.");
}