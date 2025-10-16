using Sdk;

namespace InterfaceSegregationPrinciple;

public sealed class MontanaInvoice(IEnumerable<Item> items) : AInvoice(items)
{ }
