public class Game
{
    private char[,] board;
    private List<Player> players;
    private int currentPlayerIndex;

    public Game(Player player1, Player player2)
    {
        board = new char[3, 3];
        players = new List<Player> { player1, player2 };
        currentPlayerIndex = 0;
    }

    public bool MakeMove(int row, int col, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (row < 0 || row >= 3 || col < 0 || col >= 3)
        {
            errorMessage = "Invalid move. Position out of bounds.";
            return false;
        }

        if (board[row, col] != '\0')
        {
            errorMessage = "Invalid move. Position already taken.";
            return false;
        }

        board[row, col] = players[currentPlayerIndex].Symbol;
        currentPlayerIndex = (currentPlayerIndex + 1) % 2;
        return true;
    }

    public bool CheckWin()
    {
        // Проверка за победа по редове, колони и диагонали
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] != '\0' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                return true;
            if (board[0, i] != '\0' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                return true;
        }

        if (board[0, 0] != '\0' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            return true;
        if (board[0, 2] != '\0' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            return true;

        return false;
    }

    public bool IsBoardFull()
    {
        foreach (var cell in board)
        {
            if (cell == '\0')
                return false;
        }
        return true;
    }

    public char[,] GetBoard()
    {
        return board;
    }

    public Player GetCurrentPlayer()
    {
        return players[currentPlayerIndex];
    }
}
