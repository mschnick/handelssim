using Microsoft.Extensions.Logging;

namespace Handelssim.Domain 
{
    public record Position(int X, int Y);

    public class SimulationTime
    {
        public int Day { get; private set; } = 1;
        public int Week { get; private set; } = 1;
        public int Month { get; private set; } = 1;
        public int Year { get; private set; } = 1;

        public void AdvanceDay()
        {
            Day++;

            if (Day > 7)
            {
                Day = 1;
                Week++;

                if (Week > 4)
                {
                    Week = 1;
                    Month++;

                    if (Month > 12)
                    {
                        Month = 1;
                        Year++;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/W{Week}/M{Month}/Y{Year}";
        }
    }

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
        ILogger logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("Test");


        public World()
        { 

        }
        public void GenerateCities()
        {
            GenerateCities(5, 10, 3);
        }


        public void GenerateCities(int count, int gridSize, int minDistance)
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
        public void Tick()
        {
            Time.AdvanceDay();
            _logger.LogInformation($"New simulation day: {Time}");
        }        

        private int ManhattanDistance(Position a, Position b)
            => Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
    }
}
