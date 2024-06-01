using Stones2Stars.Backend.Domain.Players.Teams;
using Stones2Stars.Backend.Domain.Worlds;

namespace Stones2Stars.Backend.Domain.Maps;
public class World
{
    public required string Name { get; set; }
    public List<Team> Teams { get; set; } = [];
    public List<PlotMap> Maps { get; set; } = [];
}
