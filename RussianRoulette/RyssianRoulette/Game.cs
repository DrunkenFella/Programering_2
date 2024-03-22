namespace RyssianRoulette;

using System.Numerics;
using System.Runtime.CompilerServices;
using Raylib_cs;

class Game
{
    private int screenWidth;
    private int screenHeight;
    private Board board;
    private char currentPlayer;
    private bool gameOver;

    public Game(int screenWidth, int screenHeight)
    {
        this.screenWidth = screenWidth;
        this.screenHeight = screenHeight;
        board = new Board();
        currentPlayer = 'X';
        gameOver = false;
    }

    public void Update()
    {
        if (!gameOver && Raylib.IsMouseButtonPressed(0))
        {
            int mouseX = Raylib.GetMouseX();
            int mouseY = Raylib.GetMouseY();

            int row = mouseY / (screenHeight / 3);
            int col = mouseX / (screenWidth / 3);

            if (board.IsCellEmpty(row, col))
            {
                board.SetCell(row, col, currentPlayer);

                // Check for winner
                if (CheckForWin())
                {
                    gameOver = true;
                }
                // Check for draw
                else if (CheckForDraw())
                {
                    gameOver = true;
                }
                else
                {
                    // Switch players
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
        }
    }

    public void Draw()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.White);

        // Draw grid
        for (int i = 1; i < 3; i++)
        {
            // Vertical lines
            Raylib.DrawLine(i * screenWidth / 3, 0, i * screenWidth / 3, screenHeight, Color.Black);
            // Horizontal lines
            Raylib.DrawLine(0, i * screenHeight / 3, screenWidth, i * screenHeight / 3, Color.Black);
        }

        // Draw X's and O's
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                char symbol = board.GetCell(row, col);
                if (symbol != ' ')
                {
                    Vector2 position = new Vector2(col * (screenWidth / 3) + (screenWidth / 6), row * (screenHeight / 3) + (screenHeight / 6));
                    Raylib.DrawText(symbol.ToString(), (int)position.X, (int)position.Y, screenHeight / 5, Color.Black);
                }
            }
        }

        Raylib.EndDrawing();
    }

    private bool CheckForWin()
    {
        // Check rows, columns, and diagonals for a win
        for (int i = 0; i < 3; i++)
        {
            if (board.GetCell(i, 0) == currentPlayer && board.GetCell(i, 1) == currentPlayer && board.GetCell(i, 2) == currentPlayer)
                return true;
            if (board.GetCell(0, i) == currentPlayer && board.GetCell(1, i) == currentPlayer && board.GetCell(2, i) == currentPlayer)
                return true;
        }

        if (board.GetCell(0, 0) == currentPlayer && board.GetCell(1, 1) == currentPlayer && board.GetCell(2, 2) == currentPlayer)
            return true;
        if (board.GetCell(0, 2) == currentPlayer && board.GetCell(1, 1) == currentPlayer && board.GetCell(2, 0) == currentPlayer)
            return true;

        return false;
    }

    private bool CheckForDraw()
    {
        // Check for any empty cells
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                if (board.IsCellEmpty(row, col))
                    return false;
            }
        }
        return true;
    }
}
