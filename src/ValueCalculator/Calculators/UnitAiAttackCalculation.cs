using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.ValueCalculator.Calculators;
public class UnitAiAttackCalculation : IUnitValueCalculation
{
    public string UnitAiName { get; set; } = "UNITAI_ATTACK";
    public ValueTask<double> CalculateValue(UnitInfo unitInfo)
    {
        return new ValueTask<double>(unitInfo.CombatStats?.Strength ?? 0 * unitInfo.MovementPoints);
    }
}
