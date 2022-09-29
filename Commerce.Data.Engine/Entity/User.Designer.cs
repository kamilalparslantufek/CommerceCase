using Commerce.Data.Engine.Core.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Data.Engine.Entity.Designer
{
    public partial class User : IdentityUser<Guid>, IBaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public Guid? UpdatedById { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set ; }
        public DateTime? UpdatedDate { get; set; }
        public virtual IEnumerable<UserRole> UserRoles { get; set; }
        public virtual IEnumerable<Product.Comment> UserComments { get; set; }
        public virtual IEnumerable<Transaction> Transactions { get; set; }
    }
}
namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.User> Users { get; }
    }
}