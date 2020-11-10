using Diploma_IS_of_Vladkhleb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
using System.Data.Entity.Core;

namespace Diploma_IS_of_Vladkhleb.Controllers
{
	public class HomeController : Controller
	{
		Diploma_DB_of_VladkhlebEntities db = new Diploma_DB_of_VladkhlebEntities();

		public ActionResult Index()
		{
			var raw_materials = db.Сырьеs.Include(path => path.Поставщик);
			return View(raw_materials.ToList());
		}

		//Добавление данных в модель
		[HttpGet]
		public ActionResult Create()
		{
			// Формируем список поставщиков для передачи в представление
			SelectList поставщикs = new SelectList(db.Поставщикs, "Код_поставщика", "Наименование_поставщика");
			ViewBag.Поставщикs = поставщикs;
			return View();
		}

		[HttpPost]
		public ActionResult Create(Сырье сырье)
		{
			//Добавляем сырье в таблицу
			db.Сырьеs.Add(сырье);
			db.SaveChanges();
			// перенаправляем на главную страницу
			return RedirectToAction("Index");
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}