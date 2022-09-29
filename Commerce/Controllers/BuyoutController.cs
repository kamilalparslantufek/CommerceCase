using Commerce.Panel.Core;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Panel.Controllers
{
    public class BuyoutController : BaseController
    {
        public BuyoutController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [Route("buyout/{id}/feature/{featureId}")]
        [Route("buyout/{id}")]
        public async Task<IActionResult> Product([FromRoute]Guid id, [FromRoute]Guid? featureId)
        {
            if(featureId == null || featureId == Guid.Empty)
            {
                var res = (await this.db.Products.Read(d => d.Id == id)).Select(d => new Panel.Models.View.BuyoutProduct
                {
                    Id = d.Id,
                    Name = d.Name,
                    Price = d.Price,
                    Features = d.Features.Select(f => new Models.View.BuyoutProduct.Feature { Id = f.Id, Name = f.Name, Value = f.Value })?.ToList(),
                    Comments = d.Comments.Select(f => new Models.View.BuyoutProduct.Comment { Id = f.Id, Text = f.Text, Name = $"{f.User.Name} {f.User.Surname}", Username = f.User.UserName })?.ToList()
                }).FirstOrDefault();
                return View("Product",res);
                    
            }
            else
            {
                return View("Product",(await this.db.ProductSales.Read(d => d.ProductId == id && d.FeatureId == featureId && d.IsActive == true)).Select(d => new Models.View.BuyoutProduct
                {
                    Id = d.Product.Id,
                    Name = $"{d.Product.Name} - {d.Feature.Name} : {d.Feature.Value}",
                    Price = d.Product.Price - (d.Product.Price * ((float)d.SalePercent/100)),
                    Features = new List<Models.View.BuyoutProduct.Feature>
                    {
                        new Models.View.BuyoutProduct.Feature
                        {
                              Id = d.FeatureId,
                              Name = d.Feature.Name,
                              Value = d.Feature.Value
                        }
                    },
                    Comments = d.Product.Comments.Select(f => new Models.View.BuyoutProduct.Comment { Id = f.Id, Text = f.Text, Name = $"{f.User.Name} {f.User.Surname}", Username = f.User.UserName }).ToList(),
                }).FirstOrDefault());
            }
        }




    }
}
