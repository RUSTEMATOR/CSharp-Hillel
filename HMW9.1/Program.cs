string? fullName = Console.ReadLine();

if (string.IsNullOrWhiteSpace(fullName))
{
    Console.WriteLine("Введіть ім'я та прізвище.");
    return;
}

string[] parts = fullName.Split(' ');

if (parts.Length < 2)
{
    Console.WriteLine("Будь ласка, введіть і ім'я, і прізвище через пробіл.");
    return;
}

char firstLetterOfName = parts[0][0];
char firstLetterOfSurname = parts[1][0];

if (char.ToUpper(firstLetterOfName) == char.ToUpper(firstLetterOfSurname))
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім'я");                                                                                                                                                               
else                                                                                                                                                                                                                                   
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім'я");