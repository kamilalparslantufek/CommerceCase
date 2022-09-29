using Commerce.Models;
using Commerce.Panel.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Commerce.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
        [Route("/")]
        public async Task<IActionResult> Index()
        {
            var res = (await this.db.Products.ReadAll()).Select(d => new Panel.Models.View.ProductListItem
            {
                Id = d.Id,
                Name = d.Name,
                Price = d.Price
            }).ToList();
            var resSales = (await this.db.ProductFeatures.ReadAll()).Select(d => new
            {
                Id = d.ProductId,
                FeatureId = d.Id,
                Name = d.Product.Name,
                Price = d.Product.Price,
                Feature = $"{d.Name}: {d.Value}",
                IsOnSale = d.Sales.Where(d => d.IsActive == true).FirstOrDefault()?.IsActive,
                SalePercent = d.Sales.Where(d => d.IsActive == true).FirstOrDefault()?.SalePercent
            }).Where(d =>d.IsOnSale == true).ToList();
            foreach(var i in resSales)
            {
                res.Add(new Panel.Models.View.ProductListItem
                {
                    Id = i.Id,
                    Name = $"{i.Name} - {i.Feature}",
                    Price = i.Price - (i.Price * ((float?)i.SalePercent/100)),
                    FeatureId = i.FeatureId,
                });
            }
            return View(res);
        }
    }
}