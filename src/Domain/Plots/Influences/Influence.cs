using Stones2Stars.Backend.Domain.Players;

namespace Stones2Stars.Backend.Domain.Plots.Influences;
public class Influence
{
    public Player Player { get; set; } = new();
    public int Value { get; set; }
}
