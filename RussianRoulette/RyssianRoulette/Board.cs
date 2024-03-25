namespace RyssianRoulette;
using Raylib_cs;


// Jag har inte skrivit så mycket av den här koden själv på Board
// Det är "char" som jag fick hjälp med att skriva och förstå
class Board
{
    private char[,] grid;
    // char stores information

    public Board()
    {
        grid = new char[3, 3];
        InitializeBoard();
    }

    public void InitializeBoard()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                grid[row, col] = ' ';
            }
        }
    }

    public char GetCell(int row, int col)
    {
        return grid[row, col];
    }

    public void SetCell(int row, int col, char symbol)
    {
        grid[row, col] = symbol;
    }

    public bool IsCellEmpty(int row, int col)
    {
        return grid[row, col] == ' ';
    }
}
