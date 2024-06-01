namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitValueCalculator
{
    public Task<int> CalculateValue(string aiType, string unitName);
}
