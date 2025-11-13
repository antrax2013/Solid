using Sdk;

namespace AlternateLiskovSubstitutionPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : ATaxedInvoice(items)
{
    public override decimal? GetTaxedTotal() => null;
}
