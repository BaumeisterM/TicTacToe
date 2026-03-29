// [] Two human players take turns entering their choice using the same keyboard
// [] The players designate which square they want to play in. Hint: You might consider using the number
//    pad as a guide.For example, if they enter 7, they have chosen the top left corner of the board.
// [] The game should prevent players from choosing squares that are already occupied. If such a move
//    is attempted, the player should be told of the problem and given another chance.
// [] The game must detect when a player wins or when the board is full with no winner (draw/”cat”).
// [] When the game is over, the outcome is displayed to the players.
// [] The state of the board must be displayed to the player after each play. Hint: One possible way to
//    show the board could be like this:

using TicTacToeGame;

// Program entry: create a player controller and a board. The Board constructor will
// initialize the board and start the main game loop by calling Player.GameLoop().
Player player = new Player();
Board board = new Board(player);
