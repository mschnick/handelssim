public record Position(int X, int Y);

public class City
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public Position Position { get; set; }
}

public class World
{
    public Guid Id { get; } = Guid.NewGuid();
    public List<City> Cities { get; private set; } = new();
    private static readonly Random _random = new();

    public void CreateCities(int count, int gridSize, int minDistance)
    {
        while (Cities.Count < count)
        {
            var pos = new Position(_random.Next(gridSize), _random.Next(gridSize));
            if (Cities.All(s => ManhattanDistance(s.Position, pos) >= minDistance))
            {
                Cities.Add(new City
                {
                    Name = $"Stadt_{Cities.Count + 1}",
                    Position = pos
                });
            }
        }
    }

    private int ManhattanDistance(Position a, Position b)
        => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
}