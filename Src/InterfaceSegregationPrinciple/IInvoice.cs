using Sdk;

namespace InterfaceSegregationPrinciple;

public interface IInvoice
{
    decimal GetTotal();

    protected static decimal Get(IEnumerable<Item> items) => items.Sum(i => i.UnitPrice); //Tips DRY
}
