# TicTacToe (Console)

A simple two-player Tic Tac Toe console application written in C# targeting .NET 10.
This project demonstrates a minimal terminal game where two human players share a keyboard,
take turns placing `X` and `O` marks on a 3x3 board, and the game detects wins and draws.

## Features

- Two local human players (same keyboard)
- Prevents placing marks on already occupied squares
- Detects win conditions and ties (draw)
- Colored marks when supported by the console: `X` = red, `O` = green
- Simple, readable ASCII board and input prompts

## Project structure

- `Program.cs` — application entry point; sets up and starts the game
- `StartMenu.cs` — optional ASCII title screen and console setup
- `Board.cs` — holds the board state, draws the board, validates and places marks, checks for wins/ties
- `Player.cs` — manages player input, turn switching and the main game loop

## Requirements

- .NET 10 SDK
- A console that supports coloring (Windows Terminal, Visual Studio integrated console, or similar)

## Build

Open a terminal in the project folder (where `TicTacToeGame.csproj` is located) and run:

```bash
dotnet build
```

## Run

From the project root run:

```bash
dotnet run --project TicTacToeGame.csproj
```

or run the compiled binary from the output directory produced by `dotnet build`.

## How to play

- The game shows a 3x3 board in the console. Players alternate turns.
- Input a number from `1` to `9` to place your mark on the board.
- The UI maps numbers similar to a numpad layout:
  - `7 8 9` — top row (left → right)
  - `4 5 6` — middle row
  - `1 2 3` — bottom row
- If you enter invalid input or choose a filled square, the game asks you to try again.
- The game ends when a player wins or the board is full (tie). The winner (or tie) is printed, then the game exits when a key is pressed.

## Customization ideas

- Add an AI opponent for single-player mode.
- Add a scoring system across multiple rounds.
- Improve the UI with a clearer highlight for the last move.
- Add command-line options for different color schemes or rules.

## Contributing

Contributions, bug reports and pull requests are welcome. For bigger changes, please open an issue first to discuss the proposed change.

When contributing:

- Keep changes focused and small
- Include a short description of the change and how to test it
