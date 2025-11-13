using Sdk;

namespace DependencyInjectionPrinciple;

public interface ITotalCalculator
{
    decimal GetTotal(IEnumerable<Item> items);
}
