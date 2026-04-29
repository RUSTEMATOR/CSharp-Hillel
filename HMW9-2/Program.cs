using System;
using System.Text;

class Program
{
    static void Main()
    {
        string reportTitle = "Daily Report";
        string reportDate = DateTime.Now.ToString("MM/dd/yyyy");
        StringBuilder eventList = new StringBuilder();

        Console.WriteLine("Enter action items (type 'done' to finish):");
        Console.WriteLine();

        int eventNumber = 1;

        while (true)
        {
            string actionItem = Console.ReadLine();
            if (actionItem.ToLower() == "done")
                break;
            eventList.AppendLine("- " + actionItem);
            eventNumber++;
        }

        StringBuilder report = new StringBuilder();
        report.AppendLine("╔══════════════════════════════╗");
        report.AppendLine($"  {reportTitle}");
        report.AppendLine($"  Date: {reportDate}");
        report.AppendLine("╚══════════════════════════════╝");
        report.AppendLine();
        report.AppendLine("── Action Items ──");
        report.AppendLine();

        if (eventList.Length > 0)
            report.Append(eventList);
        else
            report.AppendLine("No items added");

        report.AppendLine();
        report.AppendLine("──────────────────────────────");
        report.AppendLine($"Total number of action items: {eventNumber - 1}");

        Console.WriteLine();
        Console.WriteLine("REPORT");
        Console.WriteLine(report.ToString());
    }
}