char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char currentSymbol = 'X';

while (true)
{
    DisplayBoard(board);
    Console.WriteLine($"Player {(currentSymbol == 'X' ? 1 : 2)} ({currentSymbol}), your turn.");

    int index = GetValidMove(board);
    board[index] = currentSymbol;

    if (CheckWin(board, currentSymbol))
    {
        DisplayBoard(board);
        Console.WriteLine($"Player {(currentSymbol == 'X' ? 1 : 2)} wins!");
        break;
    }

    if (CheckDraw(board))
    {
        DisplayBoard(board);
        Console.WriteLine("It's a draw!");
        break;
    }

    currentSymbol = (currentSymbol == 'X') ? 'O' : 'X';
}

static void DisplayBoard(char[] board)
{
    Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
}

static bool CheckWin(char[] board, char symbol)
{
    if (board[0] == symbol && board[1] == symbol && board[2] == symbol) return true;
    if (board[3] == symbol && board[4] == symbol && board[5] == symbol) return true;
    if (board[6] == symbol && board[7] == symbol && board[8] == symbol) return true;
    if (board[0] == symbol && board[3] == symbol && board[6] == symbol) return true;
    if (board[1] == symbol && board[4] == symbol && board[7] == symbol) return true;
    if (board[2] == symbol && board[5] == symbol && board[8] == symbol) return true;
    if (board[0] == symbol && board[4] == symbol && board[8] == symbol) return true;
    if (board[2] == symbol && board[4] == symbol && board[6] == symbol) return true;
    return false;
}

static bool CheckDraw(char[] board)
{
    foreach (char cell in board)
        if (char.IsDigit(cell))
            return false;
    return true;
}

static int GetValidMove(char[] board)
{
    while (true)
    {
        Console.Write("Enter cell (1-9): ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int index) && index >= 1 && index <= 9)
        {
            index = index - 1;
            if (char.IsDigit(board[index]))
                return index;
            else
                Console.WriteLine("Cell already taken. Try again.");
        }
        else
        {
            Console.WriteLine("Invalid input. Enter a number from 1 to 9.");
        }
    }
}
