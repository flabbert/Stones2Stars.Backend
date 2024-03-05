namespace Stones2Stars.Backend.Domain.GameObjects;
public class TreatyType
{
    public required string Identifier { get; set; }
    public List<string> Rules { get; set; } = []; // OpenBorder, Defensive, Research
}
