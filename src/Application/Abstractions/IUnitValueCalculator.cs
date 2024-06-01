namespace Stones2Stars.Backend.Application.Abstractions;
public interface IUnitValueCalculator
{
    public ValueTask<double> CalculateValue(string aiType, string unitName);
}
