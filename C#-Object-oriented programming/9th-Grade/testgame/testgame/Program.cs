using System;

class MathTricksGame
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the game board (NxM):");
        Console.Write("N: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("M: ");
        int cols = int.Parse(Console.ReadLine());

        // Create the game board
        int[,] gameBoard = GenerateGameBoard(rows, cols);

        // Start positions for the players
        int player1Row = 0;
        int player1Col = 0;
        int player2Row = rows - 1;
        int player2Col = cols - 1;

        // Initialize scores for the players
        int player1Score = 0;
        int player2Score = 0;

        // Game loop
        bool gameOver = false;
        int currentPlayer = 1;

        while (!gameOver)
        {
            Console.Clear();
            PrintGameBoard(gameBoard, player1Row, player1Col, player2Row, player2Col);

            if (currentPlayer == 1)
            {
                Console.WriteLine("Player 1's turn:");
                Console.Write("Enter row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column: ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(gameBoard, row, col, player1Row, player1Col))
                {
                    int cellValue = gameBoard[row, col];
                    UpdateScore(ref player1Score, cellValue);
                    player1Row = row;
                    player1Col = col;
                    currentPlayer = 2;
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Player 2's turn:");
                Console.Write("Enter row: ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Enter column: ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(gameBoard, row, col, player2Row, player2Col))
                {
                    int cellValue = gameBoard[row, col];
                    UpdateScore(ref player2Score, cellValue);
                    player2Row = row;
                    player2Col = col;
                    currentPlayer = 1;
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                    Console.ReadLine();
                }
            }

            // Check if any player has valid moves left
            if (!HasValidMoves(gameBoard, player1Row, player1Col) ||
                !HasValidMoves(gameBoard, player2Row, player2Col))
            {
                gameOver = true;
            }
        }

        Console.Clear();
        PrintGameBoard(gameBoard, player1Row, player1Col, player2Row, player2Col);
        Console.WriteLine("Game over!");
        Console.WriteLine($"Player 1 score: {player1Score}");
        Console.WriteLine($"Player 2 score: {player2Score}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int[,] GenerateGameBoard(int rows, int cols)
    {
        Random random = new Random();
        int[,] gameBoard = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Generate a random cell value between -20 and 20 (inclusive)
                gameBoard[i, j] = random.Next(-20, 21);
            }
        }

        return gameBoard;
    }

    static void PrintGameBoard(int[,] gameBoard, int player1Row, int player1Col, int player2Row, int player2Col)
    {
        int rows = gameBoard.GetLength(0);
        int cols = gameBoard.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == player1Row && j == player1Col)
                {
                    Console.Write("P1\t");
                }
                else if (i == player2Row && j == player2Col)
                {
                    Console.Write("P2\t");
                }
                else
                {
                    Console.Write($"{gameBoard[i, j]}\t");
                }
            }

            Console.WriteLine();
        }
    }

    static bool IsValidMove(int[,] gameBoard, int row, int col, int currentPlayerRow, int currentPlayerCol)
    {
        // Check if the move is within the bounds of the game board
        if (row < 0 || row >= gameBoard.GetLength(0) || col < 0 || col >= gameBoard.GetLength(1))
        {
            return false;
        }

        // Check if the move is to a neighboring cell
        if (Math.Abs(row - currentPlayerRow) > 1 || Math.Abs(col - currentPlayerCol) > 1)
        {
            return false;
        }

        return true;
    }

    static void UpdateScore(ref int score, int cellValue)
    {
        if (cellValue > 0)
        {
            score += cellValue;
        }
        else if (cellValue < 0)
        {
            score -= Math.Abs(cellValue);
        }
        else if (cellValue == 0)
        {
            score = 0;
        }
        else if (cellValue == 2)
        {
            score *= 2;
        }
        else if (cellValue == -2)
        {
            score /= 2;
        }
    }

    static bool HasValidMoves(int[,] gameBoard, int currentPlayerRow, int currentPlayerCol)
    {
        int rows = gameBoard.GetLength(0);
        int cols = gameBoard.GetLength(1);

        for (int i = currentPlayerRow - 1; i <= currentPlayerRow + 1; i++)
        {
            for (int j = currentPlayerCol - 1; j <= currentPlayerCol + 1; j++)
            {
                if (i >= 0 && i < rows && j >= 0 && j < cols)
                {
                    if (IsValidMove(gameBoard, i, j, currentPlayerRow, currentPlayerCol))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}