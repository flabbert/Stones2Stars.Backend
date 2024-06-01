namespace Stones2Stars.Backend.Definitions.Improvements;
public class ImprovementInfo
{
    public string Id { get; set; } = "IMPROVEMENT_LUMBER_MILL";
    public string Name { get; set; } = string.Empty;
    public List<string> Requirements { get; set; } = []; // ids of features and bonuses
}
