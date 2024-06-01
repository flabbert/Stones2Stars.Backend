using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Persistence.Repositories;
public class UnitInfoRepository : IUnitInfoRepository
{
    public Task<UnitInfo?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    Task<List<UnitInfo>> IUnitInfoRepository.GetAllAvailableUnitsForAi(string unitAi, bool isResearched)
    {
        throw new NotImplementedException();
    }
}
