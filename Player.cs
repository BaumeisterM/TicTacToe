namespace TicTacToeGame;

public class Player
{
    private string _currentPlayer = "X";
    private Board? _board;

    public void GameLoop()
    {
        while (true)
        {
            if (_board == null)
                return;

            _board.Draw();

            int choice = SquareChoice();

            if (choice == 0)
            {
                Console.WriteLine("\nInvalid input. Only input 1 - 9 is possible.\n");
                Console.WriteLine("Press any key for continue . . .");
                Console.ReadKey();
                continue;
            }

            if (!_board.PlaceMark(choice, _currentPlayer))
            {
                Console.WriteLine("\nThis square is already filled. Please choose another one.\n");
                Console.WriteLine("Press any key for continue . . .");
                Console.ReadKey();
                continue;
            }

            _board.Draw();

            if (_board.CheckWin(_currentPlayer))
            {
                Console.WriteLine($"\nThe {_currentPlayer}-Player won!");
                break;
            }

            if (_board.IsFull())
            {
                Console.WriteLine("\nTie!");
                break;
            }

            SwitchPlayer();
        }

        Console.WriteLine("\nCongratulations!\n\nPress any key ...");
        Console.ReadKey();
    }
    private void SwitchPlayer()
    {
        // Toggle the current player marker between X and O
        _currentPlayer = _currentPlayer == "X" ? "O" : "X";
    }

    private int SquareChoice()
    {
        // Show the keypad-style board layout so the numeric input maps visually to positions
        Console.Write($"\n{_currentPlayer}'s turn:\n\n" +
            $" 7 | 8 | 9 \n" +
            $"---+---+---\n" +
            $" 4 | 5 | 6 \n" +
            $"---+---+---\n" +
            $" 1 | 2 | 3 \n\n" +
            $"\nChoose a square: ");

        string input = Console.ReadLine();

        // Convert text input into numeric choice; any other input is considered invalid (0)
        int result = input switch
        {
            "1" => 1,
            "2" => 2,
            "3" => 3,
            "4" => 4,
            "5" => 5,
            "6" => 6,
            "7" => 7,
            "8" => 8,
            "9" => 9,
            _ => 0
        };
        return result;
    }

    public void SetBoard(Board board)
    {
        _board = board;
    }
}
