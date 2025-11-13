using Sdk;

namespace InterfaceSegregationPrinciple
{
    public interface ITaxedInvoice
    {
        decimal GetTaxedTotal();

        protected static decimal ComputeTaxedTotal(IEnumerable<Item> items, decimal rate) //Tips DRY
            => items.Sum(i => i.UnitPrice * rate);
    }
}
