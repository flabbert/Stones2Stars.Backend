using MediatR;
using Stones2Stars.Backend.Domain.Plots;
using Unit = Stones2Stars.Backend.Domain.Units.Unit;

namespace Stones2Stars.Backend.Application.Combat.Commands;


public class InitiateCombatCommand : IRequest<CombatResult>
{
    public Unit Actor { get; set; } = null!;
    public Unit Victim { get; set; } = null!;
    public Plot Plot { get; set; } = null!;
}

public class CombatResult
{
    public Guid Id { get; set; }
    public int Turn { get; set; }
    public List<PostCombatAction> Results { get; set; } = [];
}

public class PostCombatAction
{
    public Unit Actor { get; set; } = null!;
    public string Result { get; set; } = "KILLED"; // WITHDREW, SUBDUED
}

public class PostCombatEffect
{
    public string Type { get; set; } = "CULTURE_CHANGE";
}

public class InitiateCombatCommandHandler : IRequestHandler<InitiateCombatCommand, CombatResult>
{
    public Task<CombatResult> Handle(InitiateCombatCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}