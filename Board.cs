namespace TicTacToeGame;

public class Board
{
    private readonly StartMenu _startMenu = new StartMenu();
    private readonly Player _player;
    public string[,] Squares { get; set; } = new string[3, 3];

    public Board(Player player)
    {
        _startMenu.Display();
        _player = player;
        InitiateBoard();
        Draw();
        _player.SetBoard(this);
        _player.GameLoop();
    }

    private void InitiateBoard()
    {
        // Fill every cell with a single space to denote an empty square
        for (int row = 0; row < Squares.GetLength(0); row++)
            for (int col = 0; col < Squares.GetLength(1); col++)
                Squares[row, col] = " ";
    }

    public void Draw()
    {
        Console.Clear();
        // Print the board so that the numeric keypad layout matches the visual board:
        // we print row index 2 first so that numbers 7-8-9 appear at the top.
        for (int row = 2; row >= 0; row--)
        {
            Console.Write(" ");
            for (int col = 0; col < 3; col++)
            {
                var val = Squares[row, col];
                // Color only the X and O characters. Empty spaces remain default color.
                if (val == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Red; // X = red
                    Console.Write(val);
                    Console.ResetColor();
                }
                else if (val == "O")
                {
                    Console.ForegroundColor = ConsoleColor.Green; // O = green
                    Console.Write(val);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(val); // empty cell prints as a space
                }

                if (col < 2)
                    Console.Write(" | ");
            }

            Console.WriteLine();
            if (row > 0)
                Console.WriteLine("---+---+---");
        }
    }

    public bool PlaceMark(int choice, string mark)
    {
        // Map the player's numeric choice (1..9) to board coordinates and place the mark
        var (row, col) = ChoiceToCoords(choice);

        if (row == -1)
            return false;

        if (Squares[row, col] != " ")
            return false;

        Squares[row, col] = mark;
        return true;
    }

    private (int, int) ChoiceToCoords(int choice)
    {
        return choice switch
        {
            1 => (0, 0),
            2 => (0, 1),
            3 => (0, 2),
            4 => (1, 0),
            5 => (1, 1),
            6 => (1, 2),
            7 => (2, 0),
            8 => (2, 1),
            9 => (2, 2),
            _ => (-1, -1)
        };
    }

    public bool CheckWin(string mark)
    {
        // Check rows for a win (three matching marks in any row)
        for (int r = 0; r < 3; r++)
            if (Squares[r, 0] == mark && Squares[r, 1] == mark && Squares[r, 2] == mark)
                return true;

        // Check columns for a win
        for (int c = 0; c < 3; c++)
            if (Squares[0, c] == mark && Squares[1, c] == mark && Squares[2, c] == mark)
                return true;

        // Check both diagonals for a win
        if (Squares[0, 0] == mark && Squares[1, 1] == mark && Squares[2, 2] == mark)
            return true;

        if (Squares[2, 0] == mark && Squares[1, 1] == mark && Squares[0, 2] == mark)
            return true;

        // No win found
        return false;
    }

    public bool IsFull()
    {
        for (int row = 0; row < Squares.GetLength(0); row++)
            for (int col = 0; col < Squares.GetLength(1); col++)
                if (Squares[row, col] == " ")
                    return false;
        return true;
    }
}
