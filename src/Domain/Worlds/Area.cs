using Stones2Stars.Backend.Domain.Plots;

namespace Stones2Stars.Backend.Domain.Worlds;
public class Area
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Plot> Plots { get; set; } = [];
}
