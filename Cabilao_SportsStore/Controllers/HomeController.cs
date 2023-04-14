using Microsoft.AspNetCore.Mvc;
using Cabilao_SportsStore.Models;
using Cabilao_SportsStore.Models.ViewModels;

namespace Cabilao_SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int pageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            this.repository = repo;
        }
        public ViewResult Index(string? category, int productPage = 1)
            => View(new ProductsListViewModel {
                Products = repository.Products
                    .Where(p => category ==null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * pageSize)

                    .Take(pageSize),
                PagingInfo = new PagingInfo{
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
					TotalItems = category == null
                        ? repository.Products.Count()
                        : repository.Products.Where(e =>
	                        e.Category == category).Count()
				},
                CurrentCategory = category
            });
      
    }
}
