using Sdk;

namespace OpenClosedPrinciple;

public class ItalianInvoice(IEnumerable<Item> items)
{
    const decimal TAXE_RATE = 1.22m;
    private readonly IEnumerable<Item> _items = items;

    public decimal GetTaxedTotal()
    {
        decimal total = 0.0m;

        static decimal ApplyTaxeRate(Item item) => item.UnitPrice * TAXE_RATE;

        foreach (Item item in _items)
            total += ApplyTaxeRate(item);

        return total;
    }
}
