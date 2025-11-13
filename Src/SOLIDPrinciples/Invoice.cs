using Sdk;

namespace SOLIDPrinciples;

public class Invoice(IEnumerable<Item> items, ICategoryMapper categoryMapper)
{
    private readonly IEnumerable<Item> _items = items;
    private readonly ICategoryMapper _categoryMapper = categoryMapper;

    public decimal GetTaxedTotal()
    {
        decimal total = 0.0m;

        static decimal ApplyTaxeRate(Item item, ICategoryMapper categoryMapper) => item.UnitPrice * categoryMapper.GetTaxeRate(item.Category);

        foreach (Item item in _items)
            total += ApplyTaxeRate(item, _categoryMapper);

        return total;
    }
}
