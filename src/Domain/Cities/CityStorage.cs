using Stones2Stars.Backend.Domain.Yields;

namespace Stones2Stars.Backend.Domain.Cities;
public class CityStorage
{
    public Guid CityId { get; set; }
    public List<YieldVolume> CurrentStorage { get; set; } = [];
}
