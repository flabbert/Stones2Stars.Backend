namespace Stones2Stars.Backend.Domain.InfoModels.Units;


// have this be bitflags?
public class UnitAi(string name)
{
    public string Name { get; set; } = name;
    public static implicit operator string(UnitAi unit) => unit.Name;
    public static UnitAi Attack => new("UNITAI_ATTACK");
    public static UnitAi Defence => new("UNITAI_DEFENCE");
}
