using Sdk;

namespace AlternateLiskovSubstitutionPrinciple
{
    public abstract class ATaxedInvoice(IEnumerable<Item> items, decimal? rate = null) : AInvoice(items)
    {
        protected decimal? _rate = rate;

        public virtual decimal? GetTaxedTotal() => _rate.HasValue ? _items.Sum(i => i.UnitPrice * _rate) : null;
    }
}
