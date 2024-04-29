using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
	public class StatisticController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count(); //yetenek sayısı	
			ViewBag.v2 = context.Messages.Count(); //toplam mesaj
			ViewBag.v3=context.Messages.Where(x => x.IsRead==false).Count(); //okunmayan mesaj
			ViewBag.v4=context.Messages.Where(x => x.IsRead==true).Count(); // okunan mesaj

			return View();
		}
	}
}
