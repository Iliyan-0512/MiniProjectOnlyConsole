using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TicTacToeController : ControllerBase
{
    private readonly GameService _gameService;

    public TicTacToeController(GameService gameService)
    {
        _gameService = gameService;
    }

    [HttpPost("create")]
    public ActionResult<string> CreateGame(string player1Id, string player2Id)
    {
        var gameId = _gameService.CreateGame(player1Id, player2Id);
        return Ok(gameId);
    }

    [HttpPost("move")]
    public ActionResult MakeMove(string gameId, string playerId, int row, int col)
    {
        if (_gameService.MakeMove(gameId, playerId, row, col, out var errorMessage))
        {
            return Ok();
        }

        return BadRequest(errorMessage);
    }

    [HttpGet("checkwin")]
    public ActionResult CheckWin(string gameId)
    {
        if (_gameService.CheckWin(gameId, out var isDraw))
        {
            return Ok("Win");
        }

        if (isDraw)
        {
            return Ok("Draw");
        }

        return Ok("No Win");
    }

    [HttpGet("board")]
    public ActionResult<char[,]> GetBoard(string gameId)
    {
        var board = _gameService.GetBoard(gameId);
        if (board == null)
        {
            return NotFound("Game not found.");
        }

        return Ok(board);
    }
}
