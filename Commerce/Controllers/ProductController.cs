using Commerce.Panel.Core;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Commerce.Panel.Controllers
{
    
    public class ProductController : BaseController
    {
        public ProductController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
        [Route("product")]
        public async Task<IActionResult> Index()
        {
           
            var res =  (await this.db.Products.ReadAll()).Select(d => new Models.View.Product { Id = d.Id, Name = d.Name, Price = d.Price}).ToList() ;
            return View("ProductIndex",res);
        }

        [Route("product/{id}")]
        public async Task<IActionResult> Product([FromRoute]Guid id)
        {
            var res = (await this.db.Products.Read(d => d.Id == id))
                .Select(d => new Models.View.ProductInfo { 
                    Id = d.Id,
                    Name = d.Name, 
                    Price = d.Price, 
                    Features = d.Features.Select(f => new Models.View.ProductInfo.FeatureInfo { Name = f.Name, Value = f.Value, Id = f.Id}) }).FirstOrDefault();

            return View("Product", res);
        }
        [HttpGet]
        [Route("product/insert")]
        public IActionResult Insert()
        {
            return View("Insert");
        }
        //bind çalışmadığından böyle devam
        [HttpPost]
        [Route("product/insert")]
        public async Task<IActionResult> Insert(string Name, float Price)
        {
            var id = Guid.NewGuid();
            var res = (await this.db.Products.Insert(new Data.Engine.Entity.Designer.Product
            {
                Id = id,
                Name = Name,
                Price = Price,
                CreatedById = Guid.Empty
            }));
            if (res > 0) RedirectToAction("Product", "Product", new { id = id});
            return RedirectToAction("Insert", "Product");
        }
        [HttpGet]
        [Route("product/{id}/feature")]
        public IActionResult InsertFeature([FromRoute] Guid id)
        {
            ViewData.Add("ProductId", id);
            return View("InsertFeature");
        }
        //bind çalışmadı ?
        [HttpPost]
        [Route("product/{id}/feature")]
        public async Task<IActionResult> InsertFeature([FromRoute] Guid id, string Name, string Value)
            {
            var res = (await this.db.ProductFeatures.Insert(new Data.Engine.Entity.Designer.Product.Feature
            {
                Id = Guid.NewGuid(),
                Name = Name,
                ProductId = id,
                Value = Value
            }));
            return RedirectToAction("Product", "Product", new { id = id});
        }
    }
}
