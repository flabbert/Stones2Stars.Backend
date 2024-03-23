namespace Stones2Stars.Backend.Definitions.Technologies;
public class TechnologyInfo
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public List<TechRequirementInfo> Requirements { get; set; } = [];
}
