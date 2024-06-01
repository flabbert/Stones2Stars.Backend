namespace Stones2Stars.Backend.Domain.InfoModels.Units;


// have this be bitflags?
public class UnitAi(string name, bool isMilitary = true)
{
    public string Name { get; set; } = name;
    public bool IsMilitary { get; set; } = isMilitary;
    public static implicit operator string(UnitAi unitAi) => unitAi.Name;
}
