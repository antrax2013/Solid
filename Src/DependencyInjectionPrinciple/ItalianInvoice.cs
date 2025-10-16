using Sdk;

namespace DependencyInjectionPrinciple;

public sealed class ItalianInvoice(IEnumerable<Item> items) : AInvoice(items), IInvoice, ITaxedInvoice
{
    const decimal TAXE_RATE = 1.22m;

    public decimal GetTaxedTotal()
    {
        decimal total = 0.0m;

        static decimal ApplyTaxeRate(Item item) => item.UnitPrice * TAXE_RATE;

        foreach (Item item in _items)
            total += ApplyTaxeRate(item);

        return total;
    }

    public decimal GetTotal() => _items.Sum(i => i.UnitPrice);
}
