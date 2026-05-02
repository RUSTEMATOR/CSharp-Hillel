class ToDoItem
{
    public string Name { get; set; }
    public bool IsDone { get; set; }

    public ToDoItem(string name)
    {
        Name = name;
        IsDone = false;
    }

    public override string ToString()
    {
        string status = IsDone ? "[x]" : "[ ]";
        return $"{status} {Name}";
    }
}

class Program
{
    static void AddTask(List<ToDoItem> tasks)
    {
        Console.Write("Enter task name: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Task name can not be empty.");
            return;
        }

        tasks.Add(new ToDoItem(input.Trim()));
        Console.WriteLine("Task added.");
    }

    static void ShowTasks(List<ToDoItem> tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
            return;
        }

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void MarkDone(List<ToDoItem> tasks)
    {
        ShowTasks(tasks);
        if (tasks.Count == 0) return;

        Console.Write("Enter task number to mark as done: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        tasks[index - 1].IsDone = true;
        Console.WriteLine("Done.");
    }

    static void DeleteTask(List<ToDoItem> tasks)
    {
        ShowTasks(tasks);
        if (tasks.Count == 0) return;

        Console.Write("Enter task number to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        tasks.RemoveAt(index - 1);
        Console.WriteLine("Task deleted.");
    }

    static void LoadFromStringList(List<ToDoItem> tasks, List<string> predefined)
    {
        if (predefined.Count == 0)
        {
            Console.WriteLine("No predefined tasks to load.");
            return;
        }

        foreach (string name in predefined)
        {
            tasks.Add(new ToDoItem(name));
        }

        Console.WriteLine($"{predefined.Count} predefined tasks loaded.");
    }

    static void Main(string[] args)
    {
        List<string> predefined = new List<string> { "Buy groceries", "Call dentist" };
        List<ToDoItem> tasks = new List<ToDoItem>();

        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Show all tasks");
            Console.WriteLine("3. Mark task as done");
            Console.WriteLine("4. Delete task");
            Console.WriteLine("5. Load predefined tasks");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddTask(tasks); break;
                case "2": ShowTasks(tasks); break;
                case "3": MarkDone(tasks); break;
                case "4": DeleteTask(tasks); break;
                case "5": LoadFromStringList(tasks, predefined); break;
                case "0": running = false; break;
                default: Console.WriteLine("Unknown option. Try again."); break;
            }
        }
    }
}
