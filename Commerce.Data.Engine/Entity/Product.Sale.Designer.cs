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
        [Table("Product.Sale")]
        public class Sale : BaseEntity
        {
            public DateTime SaleStart { get; set; }
            public DateTime SaleEnd { get; set; }
            public Guid FeatureId { get; set; }
            public Guid ProductId { get; set; }
            public short SalePercent { get; set; }
            public bool IsActive { get; set; }
            [ForeignKey("FeatureId")]
            public virtual Product.Feature Feature { get; set; }
            [ForeignKey("ProductId")]
            public virtual Product Product { get; set; }

        }
    }
}

namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.Product.Sale> ProductSales { get; }
    }
}