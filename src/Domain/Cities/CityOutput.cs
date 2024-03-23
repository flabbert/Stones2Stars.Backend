using Stones2Stars.Backend.Domain.Yields;

namespace Stones2Stars.Backend.Domain.Cities;
public class CityOutput
{
    public Guid CityId { get; set; }
    public List<YieldVolume> CurrentOutputs { get; set; } = [];

}