using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSharePoint.ProviderManagementWeb.Models;

namespace TestSharePoint.ProviderManagementWeb.Controllers
{
    public class HomeController : Controller
    {
        [SharePointContextFilter]
        public ActionResult Index()
        {
            User spUser = null;

            var spContext = SharePointContextProvider.Current.GetSharePointContext(HttpContext);

            using (var clientContext = spContext.CreateUserClientContextForSPHost())
            {
                if (clientContext != null)
                {
                    spUser = clientContext.Web.CurrentUser;

                    clientContext.Load(spUser, user => user.Title);

                    clientContext.ExecuteQuery();

                    ViewBag.UserName = spUser.Title;
                }
            }

            return View();
        }

        [HttpPost]
        public JsonResult ProviderList()
        {
            try
            {
                ProviderDAL dal = new ProviderDAL();
                List<Provider> persons = dal.GetAll();
                return Json(new { Result = "OK", Records = persons });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
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
