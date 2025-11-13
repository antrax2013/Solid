using Sdk;

namespace LiskovSubstitutionPrinciple.TransparentRateWay
{
    public abstract class AInvoice(IEnumerable<Item> items, decimal rate = 1)
    {
        protected decimal _rate = rate;

        protected readonly IEnumerable<Item> _items = items;

        public decimal GetTotal() => _items.Sum(i => i.UnitPrice);

        public virtual decimal GetTaxedTotal() => _items.Sum(i => i.UnitPrice * _rate);
    }
}
