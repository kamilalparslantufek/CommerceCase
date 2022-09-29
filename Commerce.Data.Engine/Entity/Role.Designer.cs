using Commerce.Data.Engine.Core.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity.Designer
{
    public class Role : IdentityRole<Guid>, IBaseEntity
    {
        public override string Name { get; set; }
        public int AccessLevel { get; set; }
        public Guid? UpdatedById { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual IEnumerable<UserRole> UserRoles { get; set; }
    }
}
namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.Role> Roles { get; }
    }
}