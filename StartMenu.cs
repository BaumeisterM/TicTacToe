using System.Text;

namespace TicTacToeGame;

public class StartMenu
{
    private readonly string _gameTitle = @$"
████████╗██╗ ██████╗  ████████╗ █████╗  ██████╗  ████████╗ ██████╗ ███████╗
╚══██╔══╝██║██╔════╝  ╚══██╔══╝██╔══██╗██╔════╝  ╚══██╔══╝██╔═══██╗██╔════╝
   ██║   ██║██║          ██║   ███████║██║          ██║   ██║   ██║█████╗  
   ██║   ██║██║          ██║   ██╔══██║██║          ██║   ██║   ██║██╔══╝  
   ██║   ██║╚██████╗     ██║   ██║  ██║╚██████╗     ██║   ╚██████╔╝███████╗
   ╚═╝   ╚═╝ ╚═════╝     ╚═╝   ╚═╝  ╚═╝ ╚═════╝     ╚═╝    ╚═════╝ ╚══════╝";
    public void Display()
    {
        // Configure the console (title, encoding, cursor) before writing the UI
        ConsoleSetup();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(_gameTitle);
        Console.ResetColor();
        // Prompt the user to start the game
        Console.WriteLine("\t\t\t\n\n\nPress any key . . .");
        Console.ReadKey();
    }

    private void ConsoleSetup()
    {
        // Set console properties so characters and layout render consistently
        Console.Title = "Tic Tac Toe";
        Console.OutputEncoding = Encoding.UTF8; // ensures Unicode box/ASCII art shows correctly
        Console.CursorVisible = false; // hide the cursor for a cleaner UI
    }
}
