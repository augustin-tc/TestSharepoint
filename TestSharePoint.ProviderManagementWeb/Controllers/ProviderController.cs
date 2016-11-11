using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSharePoint.ProviderManagementWeb.Models;

namespace TestSharePoint.ProviderManagementWeb.Controllers
{
    public class ProviderController : Controller
    {
        // GET: Provider
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string name)
        {
            ProviderDAL dal = new ProviderDAL();
            Provider provider = dal.GetAll().FirstOrDefault(x => x.Name == name);
            return View(provider);
        }
    }
}