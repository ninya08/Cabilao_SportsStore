using Microsoft.AspNetCore.Mvc;
using Cabilao_SportsStore.Models;
namespace Cabilao_SportsStore.Components
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private Cart cart;
		public CartSummaryViewComponent(Cart cartService)
		{
			cart = cartService;
		}
		public IViewComponentResult Invoke()
		{
			return View(cart);
		}
	}
}