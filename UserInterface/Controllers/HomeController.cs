using BusinessLayer.Concrete;
using DataAccess.EntitiyFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace UserInterface.Controllers
{
    public class HomeController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        ProjectManager projectManager = new ProjectManager(new EfProjectDal());
        ContactManager contactManager = new ContactManager(new EfContactDal());
        [HttpGet]
        public ActionResult Index()
        {
            var about = aboutManager.GetByID(2);
            //var aboutlist=aboutManager.GetList();
            return View(about);
        }

        public ActionResult Skill(string value)
        {
            //About sayfasında
            if (value==null)
            {
                return RedirectToAction("Index","Home");
            }
            var skillList=skillManager.GetList();
            return PartialView(skillList);
        }

        public ActionResult Service(string value)
        {
            //Service Sayfasında
            if ( value == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var serviceList = serviceManager.GetList();
            return PartialView(serviceList);
        }
        [HttpGet]
        public ActionResult Contact(string value)
        {
            if (value == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return PartialView();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
           
             
            if (contact.SenderName != null && contact.SenderMail != null && contact.SenderMessage != null)
            {
                //MailAddress to = new MailAddress("orkunceyhan44@yahoo.com");
                //MailAddress from = new MailAddress(contact.SenderMail);
                //MailMessage message = new MailMessage(from, to);
                //message.Subject = "Siteden Mesajınız Var.";
                //message.Body = contact.SenderMessage;
                //SmtpClient client = new SmtpClient("smtp.mail.yahoo.com", 465)
                //{
                //    Credentials = new NetworkCredential("orkunceyhan44@yahoo.com", "maseris11"),
                //    EnableSsl = true
                //    // specify whether your host accepts SSL connections
                //};



                //try
                //{
                //    //WebMail.SmtpServer = "	smtp.mail.yahoo.com";
                //    //WebMail.EnableSsl = true;
                //    //WebMail.UserName = "orkunceyhan44@yahoo.com";
                //    //WebMail.Password = "maseris11";
                //    //WebMail.SmtpPort = 465;

                //    //WebMail.Send("orkunceyhan44@yahoo.com", "Siteden Mesajınız var.", contact.SenderMail + contact.SenderMessage);

                //    //ViewBag.Warning = "Mesajınız gönderildi.";
                //    client.Send(message);
                //    TempData["Message"] = "Mesajınız gönderildi.";
                //}
                //catch (Exception)
                //{
                //    TempData["Message"] = "Mesajınız gönderilemedi.";
                //}
                //client.Send(message);

                contactManager.ContactAdd(contact);
                return RedirectToAction("Index", "Home");
            }
            return PartialView();
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