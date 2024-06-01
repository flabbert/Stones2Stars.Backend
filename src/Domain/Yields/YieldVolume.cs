namespace Stones2Stars.Backend.Domain.Yields;
public class YieldVolume
{
    public int Amount { get; set; }
    public Yield Yield { get; set; } = new Yield();
}
