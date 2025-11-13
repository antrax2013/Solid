using Sdk;

namespace LiskovSubstitutionPrinciple.NonsensWay;

public sealed class FrenchInvoice(IEnumerable<Item> items) : ATaxedInvoice(items)
{
    const decimal TAXE_RATE = 1.2m;

    public override decimal GetTaxedTotal()
    {
        decimal total = 0.0m;

        static decimal ApplyTaxeRate(Item item) => item.UnitPrice * TAXE_RATE;

        foreach (Item item in _items)
            total += ApplyTaxeRate(item);

        return total;
    }
}
