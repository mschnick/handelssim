public record Position(int X, int Y);

public class Stadt
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public Position Position { get; set; }
}

public class Welt
{
    public Guid Id { get; } = Guid.NewGuid();
    public List<Stadt> Staedte { get; private set; } = new();
    private static readonly Random _random = new();

    public void ErzeugeStaedte(int anzahl, int gridSize, int minAbstand)
    {
        while (Staedte.Count < anzahl)
        {
            var pos = new Position(_random.Next(gridSize), _random.Next(gridSize));
            if (Staedte.All(s => ManhattanDistanz(s.Position, pos) >= minAbstand))
            {
                Staedte.Add(new Stadt
                {
                    Name = $"Stadt_{Staedte.Count + 1}",
                    Position = pos
                });
            }
        }
    }

    private int ManhattanDistanz(Position a, Position b)
        => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
}