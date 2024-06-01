using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Persistence.Repositories;
public class UnitInfoRepository : IUnitInfoRepository
{
    public List<UnitInfo> GetAllAvailableUnitsForAi(string unitAi, bool isResearched = true)
    {
        throw new NotImplementedException();
    }
}
