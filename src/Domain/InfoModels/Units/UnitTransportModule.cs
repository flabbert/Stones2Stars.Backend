namespace Stones2Stars.Backend.Domain.InfoModels.Units;
public class UnitTransportModule : IUnitModule
{
    public string Name { get; } = "UNIT_TRANSPORT";
    public int Capacity { get; set; }
}
