using Microsoft.AspNetCore.Mvc;

namespace Commerce.Panel.Core
{
    public class BaseController : Controller
    {
        protected IServiceProvider ServiceProvider { get; }
        protected Data.Engine.Core.Database.IDatabaseContext db { get; }

        public BaseController(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
            this.db = serviceProvider?.GetService<Data.Engine.Core.Database.DatabaseContext>();
        }
    }
}
