﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
