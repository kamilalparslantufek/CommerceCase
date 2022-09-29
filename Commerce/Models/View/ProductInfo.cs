namespace Commerce.Panel.Models.View
{
    public partial class ProductInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public IEnumerable<FeatureInfo> Features { get; set; }


        public partial class FeatureInfo
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }

        }
    }
}
