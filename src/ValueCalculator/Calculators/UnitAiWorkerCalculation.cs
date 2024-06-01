using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.ValueCalculator.Calculators;
public class UnitAiWorkerCalculation : IUnitValueCalculation
{
    public string UnitAiName { get; } = "UNITAI_WORKER";
    public ValueTask<double> CalculateValue(UnitInfo unitInfo)
    {
        return new ValueTask<double>(unitInfo.CivilianStats?.WorkPoints ?? 0 * unitInfo.MovementPoints);
    }
}