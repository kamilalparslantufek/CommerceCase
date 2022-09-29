using Commerce.Data.Engine.Core.Database;
using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commerce.Data.Engine.Enum;

namespace Commerce.Data.Engine.Entity
{
    public partial class Product
    {
        public class Sale : EntityContext<Designer.Product.Sale>
        {
            public Sale(DatabaseContext db) : base(db)
            {
            }
            //need a better validation for adding sales for features
            public override async Task<string[]> Validate(ActionTypes type, Designer.Product.Sale Entity)
            {
                var msgs = new List<string>();
                if ((await this.Read(d => d.Id != Entity.Id && d.ProductId == Entity.ProductId && d.FeatureId == Entity.FeatureId && d.IsActive == Entity.IsActive)).ToList().Count > 0)
                    msgs.Add("There is a sale");
                return msgs.ToArray();
            }
        }
    }
}
