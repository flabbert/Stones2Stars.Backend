using Stones2Stars.Backend.Domain.Players;

namespace Stones2Stars.Backend.Domain.Worlds;
public class Satellite
{
    public PlotMap Map { get; set; } = null!;
    public Player Owner { get; set; } = null!;
}
