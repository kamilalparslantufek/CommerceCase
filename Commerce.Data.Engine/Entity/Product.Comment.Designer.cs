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
        [Table("Product.Comment")]
        public partial class Comment : BaseEntity
        {
            public Guid ProductId { get; set; }

            public Guid UserId { get; set; }

            public string Text { get; set; }

            [ForeignKey("UserId")]
            public virtual User User { get; set; }

            [ForeignKey("ProductId")]
            public virtual Product Product { get; set; }
        }
    }
}
