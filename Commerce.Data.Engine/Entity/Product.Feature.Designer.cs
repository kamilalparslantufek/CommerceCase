using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity.Designer
{
    public partial class Product
    {
        [Table("Product.Feature")]
        public class Feature : BaseEntity
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public Guid ProductId { get; set; }
            [ForeignKey("ProductId")]
            public virtual Product Product { get; set; }
            public virtual IEnumerable<Sale> Sales { get; set; }

        }
    }
}
namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.Product.Feature> ProductFeatures { get; }
    }
}