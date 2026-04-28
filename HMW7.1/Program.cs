Random random = new Random();

int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(-10, 11);
}

Console.WriteLine("Елементи з парними індексами:");

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"numbers[{i}] = {numbers[i]}");
    }
}

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

if (sum >= 0)
{
    Console.WriteLine($"Сума: {sum} -- не від'ємне число");
}
else
{
    Console.WriteLine($"Сума: {sum} -- від'ємне число");
}

//=====================================================

int[,] table = new int[9, 9];

for (int row = 0; row < 9; row++)
{
    for (int col = 0; col < 9; col++)
    { 
        table[row, col] = (col + 1) * (row + 1);
    }    
}

Console.WriteLine("Таблиця множення:");

for (int row = 0; row < 9; row++)
{
    for (int col = 0; col < 9; col++)
    {
        Console.Write(table[row, col].ToString().PadLeft(3));  
    }
    Console.WriteLine();
}
//===============================================


int[,] grid = new int[5, 5]
{                                                                                                                                                                                                                                      
    {  3, 17, -5,  8,  2 },                                     
    { 12, -9,  4, 21,  0 },                                                                                                                                                                                                            
    {  7,  1, 33, -2,  6 },                                                                                                                                                                                                            
    { 15, -8,  9,  5, 11 },                                                                                                                                                                                                            
    { -1, 28,  4, -7, 19 }                                                                                                                                                                                                             
}; 

int max = grid[0, 0];                                           
int min = grid[0, 0];                                                                                                                                                                                                                  
int maxRow = 0, maxCol = 0;                                     
int minRow = 0, minCol = 0;   


for (int row = 0; row < 5; row++)                               
{
    for (int col = 0; col < 5; col++)
    {                                                                                                                                                                                                                                  
        if (grid[row, col] > max)
        {                                                                                                                                                                                                                              
            max = grid[row, col];                               
            maxRow = row;
            maxCol = col;
        }
        if (grid[row, col] < min)
        {                                                                                                                                                                                                                              
            min = grid[row, col];
            minRow = row;                                                                                                                                                                                                              
            minCol = col;                                       
        }
    }
}
Console.WriteLine($"Max = {max}, coordinates: [{maxRow}, {maxCol}]");                                                                                                                                                                  
Console.WriteLine($"Min = {min}, coordinates: [{minRow}, {minCol}]");

//====================================================================

Console.Write("Введіть кількість днів: ");
int days = int.Parse(Console.ReadLine()!);

int resultIndex = days % 7;

DayOfWeek resultDay = (DayOfWeek)resultIndex;

Console.WriteLine(resultDay);

enum DayOfWeek
{
    Monday = 0,
    Tuesday = 1,
    Wednesday = 2,
    Thursday = 3,
    Friday = 4,
    Saturday = 5,
    Sunday = 6
}