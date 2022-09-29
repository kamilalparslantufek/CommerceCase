using Commerce.Data.Engine.Core.Context;
using Commerce.Data.Engine.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity
{
    public partial class Product
    {
        public partial class Comment : EntityContext<Designer.Product.Comment>
        {
            public Comment(DatabaseContext db) : base(db)
            {
            }
        }
    }
}
