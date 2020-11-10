using Diploma_IS_of_Vladkhleb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Diploma_IS_of_Vladkhleb.Controllers
{
	public class EmployeeController : Controller
	{
		Diploma_DB_of_VladkhlebEntities db = new Diploma_DB_of_VladkhlebEntities();

		public ActionResult EmployeeIndex()
		{
			var работникs = db.Работникs.Include(path => path.Должность);
			return View(работникs.ToList());
		}

		// GET: Employee
		[HttpGet]
		public ActionResult EmployeeSelect()
		{
			SelectList должностьs = new SelectList(db.Должностьs, "Код_должности", "Наименование_должности");
			ViewBag.Должностьs = должностьs;
			return View();
		}

		[HttpPost]
		public ActionResult EmployeeSelect(Работник работник)
		{
			return RedirectToAction("LoginIndex", "Login", new { area = "" });
		}
	}
}
