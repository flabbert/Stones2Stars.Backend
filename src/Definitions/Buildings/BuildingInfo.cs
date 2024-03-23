namespace Stones2Stars.Backend.Definitions.Buildings;
public class BuildingInfo
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public Dictionary<string, int> Yields { get; set; } = [];

}
