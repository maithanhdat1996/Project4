using Microsoft.AspNet.Identity;
using SocialFashion.Model.Models;
using SocialFashion.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SocialFashion.Web.Controllers
{
    public class HomeController : Controller
    {
        SocialFashionDbContext db;
        public HomeController(IProductService productServicer)
        {
            db = new SocialFashionDbContext();
        }

        public ActionResult Index()
        {
            IEnumerable<GetAllStutusByUserId_Result> list = db.GetAllStutusByUserId(User.Identity.GetUserId()).ToList<GetAllStutusByUserId_Result>();
            return View(list);
        }

        public ActionResult Chat()
        {
            return PartialView();
        }

        public ActionResult ToolbarDesktopPartial()
        {
            return PartialView();
        }

        public JsonResult GetNotificationAPI()
        {
            
            NotificationComponent NC = new NotificationComponent();
            var list = NC.GetNotification();
      
            return new JsonResult { Data = list,JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetCountNotificationAPI()
        {

            NotificationComponent NC = new NotificationComponent();
            var count = NC.GetCountNotification();

            return new JsonResult { Data = count, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}