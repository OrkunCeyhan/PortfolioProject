using BusinessLayer.Concrete;
using DataAccess.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        [HttpGet]
        public ActionResult Index()
        {
            var about = aboutManager.GetByID(2);
            //var aboutlist=aboutManager.GetList();
            return View(about);
        }

        public ActionResult Skill(string value)
        {
            if (value==null)
            {
                return RedirectToAction("Index","Home");
            }
            var skillList=skillManager.GetList();
            return PartialView(skillList);
        }
        public PartialViewResult Service()
        {
            var serviceList = serviceManager.GetList();
            return PartialView(serviceList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Project(string value)
        {
            if (value == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var projectList = projectManager.GetList();
            return PartialView(projectList);
        }

    }
}