namespace Stones2Stars.Backend.Definitions.Leaders;
public class NationalityInfo
{
    public string Name { get; set; } = string.Empty;
    public List<LeaderInfo> DefaultLeaders { get; set; } = [];
    public List<CityName> CityNames { get; set; } = [];
}
