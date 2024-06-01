using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Persistence.Repositories;
public class UnitAiRepository : IUnitAiRepository
{
    private readonly List<UnitAi> _unitAis = [
        new UnitAi("UNITAI_ATTACK"),
        new UnitAi("UNITAI_DEFENCE"),
        new UnitAi("UNITAI_WORKER", false)];
    public Task<UnitAi?> GetUnitAi(string name)
    {
        return Task.FromResult(_unitAis.FirstOrDefault(ai => ai.Name == name));
    }
}
