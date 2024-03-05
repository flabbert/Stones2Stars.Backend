namespace Stones2Stars.Backend.Domain.GameObjects;
public class World
{
    public required string Name { get; set; }
    public List<Team> Teams { get; set; } = [];
    public List<PlotMap> Maps { get; set; } = [];
}
