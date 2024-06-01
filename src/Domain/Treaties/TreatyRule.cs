namespace Stones2Stars.Backend.Domain.Treaties;
public class TreatyRule
{
    public TreatyRule(string identifier)
    {
        Identifier = identifier;
    }
    public string Identifier { get; }
    public static TreatyRule War => new("War");
    public static TreatyRule Hostile => new("Hostile");
    public static TreatyRule OpenBorder => new("OpenBorder");
    public static TreatyRule MutualDefense => new("MutualDefense");
    public static TreatyRule Trade => new("Trade");
    public static TreatyRule FreeMovement => new("FreeMovement");
    public static implicit operator string(TreatyRule rule) => rule.Identifier;
}
