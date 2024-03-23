namespace Stones2Stars.Backend.Definitions.Technologies;
public class TechRequirementInfo
{
    public string TechnologyId { get; set; } = string.Empty;
    public bool Optional { get; set; } = false;
    public decimal Boost { get; set; }
}
