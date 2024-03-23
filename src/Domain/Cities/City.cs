using Stones2Stars.Backend.Domain.Players;
using Stones2Stars.Backend.Domain.Plots;

namespace Stones2Stars.Backend.Domain.Cities;
public class City
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Plot Plot { get; set; } = null!;
    public Player Owner { get; set; } = null!;
    public CityStorage Storage { get; set; } = new();
    public CityOutput Output { get; set; } = new();
}
