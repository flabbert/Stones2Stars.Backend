using Microsoft.Extensions.DependencyInjection;
using Stones2Stars.Backend.Application.Abstractions;
using Stones2Stars.Backend.Domain.InfoModels.Units;

namespace Stones2Stars.Backend.ValueCalculator.Units;
public class UnitValueCalculator : IUnitValueCalculator
{
    private readonly IUnitInfoRepository _unitInfoRepository;
    private readonly IUnitAiRepository _unitAiRepository;
    private readonly IServiceProvider _serviceProvider;

    public UnitValueCalculator(IUnitInfoRepository unitInfoRepository, IUnitAiRepository unitAiRepository, IServiceProvider serviceProvider)
    {
        _unitInfoRepository = unitInfoRepository;
        _unitAiRepository = unitAiRepository;
        _serviceProvider = serviceProvider;
    }

    public async ValueTask<double> CalculateValue(string aiType, string unitName)
    {
        var unitInfoTask = _unitInfoRepository.GetByName(unitName);
        var unitAiTask = _unitAiRepository.GetUnitAi(aiType);

        await Task.WhenAll(unitInfoTask, unitAiTask);

        var unitInfo = await unitInfoTask ?? throw new NullReferenceException($"no unit with name {unitName} found");
        var unitAi = await unitAiTask ?? throw new NullReferenceException($"no unitAi with name {aiType} found");

        var calculator =
            _serviceProvider.GetServices<IUnitValueCalculation>()
                .First(s => s.UnitAiName == unitAi.Name);

        return await calculator.CalculateValue(unitInfo);
    }
}
