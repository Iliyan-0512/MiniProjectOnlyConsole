using System.Collections.Generic;

public class GameService
{
    private Dictionary<string, Game> activeGames;

    public GameService()
    {
        activeGames = new Dictionary<string, Game>();
    }

    public string CreateGame(string player1Id, string player2Id)
    {
        var player1 = new Player(player1Id, 'X');
        var player2 = new Player(player2Id, 'O');
        var game = new Game(player1, player2);
        var gameId = Guid.NewGuid().ToString();
        activeGames[gameId] = game;
        return gameId;
    }

    public bool MakeMove(string gameId, string playerId, int row, int col, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (!activeGames.ContainsKey(gameId))
        {
            errorMessage = "Invalid game ID.";
            return false;
        }

        var game = activeGames[gameId];
        var currentPlayer = game.GetCurrentPlayer();
        if (currentPlayer.Id != playerId)
        {
            errorMessage = "It's not your turn.";
            return false;
        }

        return game.MakeMove(row, col, out errorMessage);
    }

    public bool CheckWin(string gameId, out bool isDraw)
    {
        isDraw = false;
        if (!activeGames.ContainsKey(gameId))
            return false;

        var game = activeGames[gameId];
        if (game.CheckWin())
            return true;

        isDraw = game.IsBoardFull();
        return false;
    }

    public char[,] GetBoard(string gameId)
    {
        if (!activeGames.ContainsKey(gameId))
            return null;

        return activeGames[gameId].GetBoard();
    }
}
