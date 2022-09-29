namespace Commerce.Panel.Models.View
{
    public class ProductListItem
    {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public float? Price { get; set; }
            public Guid? FeatureId { get; set; }
    }
}
