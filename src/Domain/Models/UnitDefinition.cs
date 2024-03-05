namespace Stones2Stars.Backend.Domain.Models;
public class UnitDefinition
{
    public required string Type { get; set; }
    public required List<UnitBehaviour> Behaviours { get; set; }
    public required UnitStats Stats { get; set; }

}
