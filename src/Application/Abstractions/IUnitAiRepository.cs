using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitAiRepository
{
    public Task<UnitAi?> GetUnitAi(string name);
}
