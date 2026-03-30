using TicTacToeGame;

// Program entry: create a player controller and a board. The Board constructor will
// initialize the board and start the main game loop by calling Player.GameLoop().
Player player = new Player();
Board board = new Board(player);
