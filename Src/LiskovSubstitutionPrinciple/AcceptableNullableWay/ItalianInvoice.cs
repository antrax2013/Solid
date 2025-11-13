using Sdk;

namespace LiskovSubstitutionPrinciple.AcceptableNullableWay;

public sealed class ItalianInvoice(IEnumerable<Item> items) : AInvoice(items, 1.22m)
{ }
