using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Helper;

namespace WebApplication4.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View(new WebApplication4.Models.User());
        }
        public ActionResult ChangeCulture(int id)
        {
            LangHelper.currentculture = id;
            Session["currentculture"] = id;
            return Redirect(Request.UrlReferrer.ToString());
        }
        
    }
}