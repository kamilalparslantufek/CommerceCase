using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity.Designer
{
    [Table("Product")]
    public partial class Product : BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public virtual IEnumerable<Product.Feature> Features { get; set; }
        public virtual IEnumerable<Product.Comment> Comments { get; set; }
        public virtual IEnumerable<Product.Sale> Sales { get; set; }
        public virtual IEnumerable<Transaction> Transactions { get; set; }

    }
}
namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.Product> Products { get; }
    }
}