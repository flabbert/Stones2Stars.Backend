using Stones2Stars.Backend.Domain.Players.Teams;

namespace Stones2Stars.Backend.Domain.Treaties;
public class Treaty
{
    public List<Team> Teams { get; set; } = [];
    public List<TreatyType> AllianceTypes { get; set; } = [];
}
