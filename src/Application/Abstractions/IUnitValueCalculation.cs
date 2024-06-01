using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitValueCalculation
{
    public string UnitAiName { get; }
    public ValueTask<double> CalculateValue(UnitInfo unitInfo);
}
