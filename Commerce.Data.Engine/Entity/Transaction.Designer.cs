using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity.Designer
{
    [Table("Transaction")]
    public class Transaction : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public float Price { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}

namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.Transaction> Transactions { get; }
    }
}