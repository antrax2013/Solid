using Sdk;

namespace LiskovSubstitutionPrinciple.AcceptableNullableWay
{
    public abstract class AInvoice(IEnumerable<Item> items, decimal? rate = null)
    {

        protected readonly IEnumerable<Item> _items = items;
        protected decimal? _rate = rate;

        public decimal GetTotal() => _items.Sum(i => i.UnitPrice);

        public virtual decimal? GetTaxedTotal() => _rate.HasValue ? _items.Sum(i => i.UnitPrice * _rate) : null;
    }
}
