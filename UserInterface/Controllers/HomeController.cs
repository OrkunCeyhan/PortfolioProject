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
        [HttpGet]
        public ActionResult Index(int id=2)
        {
            var about = aboutManager.GetByID(id);
            //var aboutlist=aboutManager.GetList();
            return View(about);
        }

        public PartialViewResult About()
        {
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

    }
}