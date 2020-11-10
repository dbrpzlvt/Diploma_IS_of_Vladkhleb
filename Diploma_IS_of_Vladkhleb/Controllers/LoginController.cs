using Diploma_IS_of_Vladkhleb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Diploma_IS_of_Vladkhleb.Controllers
{
    public class LoginController : Controller
    {
        Diploma_DB_of_VladkhlebEntities db = new Diploma_DB_of_VladkhlebEntities();

        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginIndex(Работник работник)
        {
            // this action is for handle post (login)
            if (ModelState.IsValid) // this is check validity
            {
                {
                    var v = db.Работникs.Where(a => a.Имя_пользователя.Equals(работник.Имя_пользователя) && 
                                               a.Пароль.Equals(работник.Пароль)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["LogedUserID"] = v.Код_работника.ToString();
                        Session["LogedUserFullname"] = v.ФИО_работника.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(работник);
        }

        //[HttpGet]
        public ActionResult AfterLogin()
        {
            if (Session["LogedUserID"] != null)
            {
                return RedirectToAction("AdministratorIndex", "Administrator", new { area = "" });
            }
            else
            {
                return View();
            }
        }
    }
}