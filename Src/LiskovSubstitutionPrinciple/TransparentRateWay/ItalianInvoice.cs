using Sdk;

namespace LiskovSubstitutionPrinciple.TransparentRateWay;

public sealed class ItalianInvoice(IEnumerable<Item> items) : AInvoice(items, 1.22m)
{ }
