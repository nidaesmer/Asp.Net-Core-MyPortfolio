using Microsoft.AspNetCore.Mvc;
//sekmede gorunecek isim için yapıldı

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
