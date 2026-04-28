using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter expression to use calculator or 'exit' to quit");

            string input = Console.ReadLine();

            if (input.ToLower() == "exit") break;

            try
            {
                string[] parts = input.Split(' ');
                double a = double.Parse(parts[0]);
                string operand = parts[1];
                double b = double.Parse(parts[2]);
                
                double result = operand switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => b !=0 ? a / b : throw new DivideByZeroException("Division by zero is impossible"),
                    "%" => a % b,
                    _ => throw new ArgumentException($"Invalid operator {operand}")
                };
                Console.WriteLine($"Result: {result}");
            } 
            catch (DivideByZeroException error) {Console.WriteLine(error.Message);}
            catch (FormatException error) {Console.WriteLine(error.Message);}
            catch (Exception error)  {Console.WriteLine(error.Message);}
        }
    }
}
