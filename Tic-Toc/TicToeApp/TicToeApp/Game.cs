public class Game
{
    private readonly Player _player1;
    private readonly Player _player2;
    private readonly Board _board;
    private Player _currentPlayer;

    public Game(Player player1, Player player2)
    {
        _player1 = player1;
        _player2 = player2;
        _board = new Board();
        _currentPlayer = _player1;
    }

    public void Play()
    {
        while (true)
        {
            Console.Clear();
            _board.Display();
            Console.WriteLine($"{_currentPlayer.Name}'s turn ({_currentPlayer.Symbol}):");
            Console.Write("Enter row (0, 1, 2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter col (0, 1, 2): ");
            int col = int.Parse(Console.ReadLine());

            if (_board.MakeMove(row, col, _currentPlayer.Symbol))
            {
                if (_board.CheckWin(_currentPlayer.Symbol))
                {
                    Console.Clear();
                    _board.Display();
                    Console.WriteLine($"{_currentPlayer.Name} wins!");
                    break;
                }
                if (_board.IsFull())
                {
                    Console.Clear();
                    _board.Display();
                    Console.WriteLine("It's a draw!");
                    break;
                }
                _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
            }
            else
            {
                Console.WriteLine("Invalid move! Try again.");
            }
        }
    }
}
