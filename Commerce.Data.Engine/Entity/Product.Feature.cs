using Commerce.Data.Engine.Core.Database;
using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity
{
    public partial class Product
    {
        public class Feature : EntityContext<Designer.Product.Feature>
        {
            public Feature(DatabaseContext db) : base(db)
            {
            }
        }
    }
}
