using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitInfoRepository
{
    public Task<UnitInfo?> GetByName(string name);
    public Task<List<UnitInfo>> GetAllAvailableUnitsForAi(string unitAi, bool isResearched = true);

}
