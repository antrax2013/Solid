using Sdk;

namespace InterfaceSegregationPrinciple;

public interface IInvoice
{
    decimal GetTotal();

    protected static decimal ComputeTotal(IEnumerable<Item> items) => items.Sum(i => i.UnitPrice); //Tips DRY
}
