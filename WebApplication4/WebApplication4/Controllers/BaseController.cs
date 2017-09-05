using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Helper;


namespace WebApplication4.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        //public ActionResult Index()
        //{

        //    return View();
        //}
        protected override void ExecuteCore()
        {
            int culture = 0;
            if (this.Session == null || this.Session["currentculture"] == null)
            {
                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                this.Session["currentculture"] = culture;

            }
            else culture = (int)this.Session["currentculture"];
            LangHelper.currentculture = culture;
            base.ExecuteCore();
        }
        protected override bool DisableAsyncSupport
        {
            get
            {
                return true;
            }
        }

    }
}