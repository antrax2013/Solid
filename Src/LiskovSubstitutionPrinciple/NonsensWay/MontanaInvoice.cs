using Sdk;

namespace LiskovSubstitutionPrinciple.NonsensWay;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{
}
