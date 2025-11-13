using Sdk;

namespace LiskovSubstitutionPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{
}
