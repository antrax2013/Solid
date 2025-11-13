using Sdk;

namespace SOLIDPrinciples
{
    public interface ICategoryMapper
    {
        decimal GetTaxeRate(Category? category) => 1;
    }
}
