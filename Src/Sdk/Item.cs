namespace Sdk;

public enum Category
{
    Clothe,
    Food,
    HigthTech,
}

public enum ItemType
{
    Service,
    Good
}

public record Item(string Name, decimal UnitPrice, ItemType ItemType, Category? Category = null)
{
}
