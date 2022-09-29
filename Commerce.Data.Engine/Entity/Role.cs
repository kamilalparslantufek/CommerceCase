using Commerce.Data.Engine.Core.Database;
using Commerce.Data.Engine.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity
{
    public partial class Role : EntityContext<Designer.Role>
    {
        public Role(DatabaseContext db) : base(db)
        {
        }
    }
}
