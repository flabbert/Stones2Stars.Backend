using Stones2Stars.Backend.Domain.Plots.Influences;

namespace Stones2Stars.Backend.Domain.Plots;

public class Plot
{
    public Guid Id { get; set; }
    public Coordinate Coordinate { get; set; } = new();
    public List<Influence> Influences { get; set; } = [];
}
