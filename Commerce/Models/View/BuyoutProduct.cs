namespace Commerce.Panel.Models.View
{
    public class BuyoutProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<Feature>? Features { get; set; }
        public List<Comment>? Comments { get; set; }
        public class Feature
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public class Comment
        {
            public Guid Id { get; set; }
            public string Text { get; set; }
            public string Name { get; set; }
            public string Username { get; set; }
        }
    }
}
