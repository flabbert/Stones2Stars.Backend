namespace Stones2Stars.Backend.Domain.Players;
public class Player
{
    public Guid Id { get; set; }
    public Leader Leader { get; set; } = new();
    public List<Trait> Traits { get; set; } = [];
}
