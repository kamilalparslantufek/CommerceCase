using Commerce.Data.Engine.Core.Context;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Commerce.Data.Engine.Entity.Designer
{
    [Table("User.Role")]
    public class UserRole : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
namespace Commerce.Data.Engine.Core.Database
{
    public partial interface IDatabaseContext
    {
        public IEntityContext<Entity.Designer.UserRole> UserRoles { get; }
    }
}