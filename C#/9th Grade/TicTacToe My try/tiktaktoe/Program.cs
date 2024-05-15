using System;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			GameLoop();
		}

		static void GameLoop()
		{
			// Player 1 is O
			// Player 2 is X
			// Empty slot is ' ' (whitespace)
			char[,] board = {
				{' ', ' ', ' '},
				{' ', ' ', ' '},
				{' ', ' ', ' '}
			};
			char playerTurn = 'O';
			char winner = ' '; // ' ' means no winner

			Draw(board);
			while (true)
			{
				Console.Write($"Player {playerTurn} turn: ");
				string input = Console.ReadLine(); // eg. A1
				if (input == "END")
				{
					EndGame(winner);
					return;
				}

				int y = int.Parse("" + input[1]) - 1;
				int x;

				switch (input[0])
				{
					case 'A':
						x = 0;
						break;
					case 'B':
						x = 1;
						break;
					case 'C':
						x = 2;
						break;
					default:
						x = -1;
						break;
				}

				// Mark the move
				
				board[y, x] = playerTurn;
				if(board[y, x] == 'O' || board[y, x] == 'X')
                {
					Console.WriteLine("Space occupied!");
                }

				// Refresh the current board on the console
				Draw(board);

				// Check win condition
				winner = CheckWinCondition(board);
				if (winner != ' ')
				{
					EndGame(winner);
					return;
				}

				// Switch turns
				if (playerTurn == 'X')
				{
					playerTurn = 'O';
				}
				else
				{
					playerTurn = 'X';
				}
			}
		}

		static char CheckWinCondition(char[,] board)
		{
			char[] players = { 'X', 'O' };
			foreach (char p in players)
			{
				// rows and columns
				for (int i = 0; i < 3; i++)
				{
					if (board[i, 0] == p && board[i, 1] == p && board[i, 2] == p)
					{
						return p;
					}
					if (board[0, i] == p && board[1, i] == p && board[2, i] == p)
					{
						return p;
					}
				}
				//diagonals
				if ((board[0, 0] == p && board[1, 1] == p && board[2, 2] == p)
					||
					(board[0, 2] == p && board[1, 1] == p && board[2, 0] == p))
				{
					return p;
				}
			}


			return ' ';
		}

		static void Draw(char[,] board)
		{
			Console.Clear();
			Console.WriteLine("    A   B   C  ");
			Console.WriteLine("  -------------");
			Console.WriteLine($"1 | {board[0, 0]} | {board[0, 1]} | {board[0, 2]} |");
			Console.WriteLine("  -------------");
			Console.WriteLine($"2 | {board[1, 0]} | {board[1, 1]} | {board[1, 2]} |");
			Console.WriteLine("  -------------");
			Console.WriteLine($"3 | {board[2, 0]} | {board[2, 1]} | {board[2, 2]} |");
			Console.WriteLine("  -------------");
		}

		static void EndGame(char winner)
		{
			Console.WriteLine("Game Over!");
			if (winner == ' ')
			{
				Console.WriteLine("Draw");
			}
			else
			{
				Console.WriteLine($"Player {winner} wins");
			}
		}
	}
}