using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status==false).Count(); //tamamlanmamıs bildirim sayısını gosterecek
			var values = context.ToDoLists.Where(x => x.Status==false).ToList(); //yapılmamıs olanları lıstele
			return View(values);
		}
	}
}
