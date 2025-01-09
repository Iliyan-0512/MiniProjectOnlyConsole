public class Board
{
    private readonly char[,] _grid;
    private const int Size = 3;

    public Board()
    {
        _grid = new char[Size, Size];
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                _grid[i, j] = ' ';
            }
        }
    }

    public bool MakeMove(int row, int col, char symbol)
    {
        if (row < 0 || row >= Size || col < 0 || col >= Size || _grid[row, col] != ' ')
        {
            return false;
        }
        _grid[row, col] = symbol;
        return true;
    }

    public bool CheckWin(char symbol)
    {
        for (int i = 0; i < Size; i++)
        {
            if ((_grid[i, 0] == symbol && _grid[i, 1] == symbol && _grid[i, 2] == symbol) ||
                (_grid[0, i] == symbol && _grid[1, i] == symbol && _grid[2, i] == symbol))
            {
                return true;
            }
        }

        if ((_grid[0, 0] == symbol && _grid[1, 1] == symbol && _grid[2, 2] == symbol) ||
            (_grid[0, 2] == symbol && _grid[1, 1] == symbol && _grid[2, 0] == symbol))
        {
            return true;
        }

        return false;
    }

    public bool IsFull()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (_grid[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        return true;
    }

    public void Display()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write(_grid[i, j]);
                if (j < Size - 1) Console.Write("|");
            }
            Console.WriteLine();
            if (i < Size - 1) Console.WriteLine("-----");
        }
    }
}
