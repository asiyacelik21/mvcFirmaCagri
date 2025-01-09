using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using mvcFirmaCagri.Models.Entity;

namespace mvcFirmaCagri.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DbisTakipEntities db = new DbisTakipEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult index(Tbl_Firmalar p)
        {
            var bilgiler =db.Tbl_Firmalar.FirstOrDefault(x=>x.Mail==p.Mail&& x.Sifre==p.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Mail, false);
                Session["Mail"] = bilgiler.Mail.ToString();
                return RedirectToAction("AktifCagrilar", "Default");
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }
    }
}