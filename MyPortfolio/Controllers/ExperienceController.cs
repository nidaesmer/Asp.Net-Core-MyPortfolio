using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        { 
            var values = context.Experiences.ToList(); 
            return View(values);
        }

        [HttpGet] //sayfa yüklenince çalışacak
        public IActionResult CreateExperience() 
        {
            return View();
        }

		[HttpPost] //sayfada bir butona tıklandıgında calısır
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiences.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
        //silme işlemi yaptırmak için
        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");

		}

        //güncelleme işlemi yaptırmak için
        [HttpGet] //ilk önce güncellencek veriyi bulmamız gerekiyor
        public IActionResult UpdateExperience(int id) //güncellencek veriyi ıdye göre bulcak
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}

	}

