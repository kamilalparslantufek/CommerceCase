using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public Task Migrate();
    }
}
