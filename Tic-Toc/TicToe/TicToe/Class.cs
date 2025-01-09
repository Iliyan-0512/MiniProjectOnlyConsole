public class Player
{
    public string Id { get; private set; }
    public char Symbol { get; private set; }

    public Player(string id, char symbol)
    {
        Id = id;
        Symbol = symbol;
    }
}
