namespace TheSimpleShopApi.Domain.Enums
{
    /// <summary>
    /// <strong>Enum representing the size of a product - example Small, Medium or Large.</strong>
    /// <br/>
    /// Possible future implementation could look at removing this enum
    /// in favour of a free-text / tag style relationship -
    /// similar to the ProductCategory implementation.
    /// <br/>
    /// This would enable the user to define their own size.
    /// </summary>
    public enum Size
    {
        SuperSmall,
        Small,
        Medium,
        Large,
        ExtraLarge,
        ExtraExtraLarge
    }
}
