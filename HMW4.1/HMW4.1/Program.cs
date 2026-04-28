using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static string PrintDayOfWeek(int dayNumber)
    {
        var dayNames = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
        if (dayNumber < 1 || dayNumber > 7) throw new ArgumentOutOfRangeException(nameof(dayNumber));
        return dayNames[dayNumber % 7];
    }
    static void Main()
    {
        Console.WriteLine("Enter a number from 1 to 7 to get the corresponding day of the week:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(PrintDayOfWeek(userInput));
    }
}