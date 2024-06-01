using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitInfoRepository
{
    public List<UnitInfo> GetAllAvailableUnitsForAi(string unitAi, bool isResearched = true);

}
