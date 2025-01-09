using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcFirmaCagri.Models.Entity;
namespace mvcFirmaCagri.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        DbisTakipEntities db= new DbisTakipEntities();
        
        public ActionResult AktifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id=db.Tbl_Firmalar.Where(x=>x.Mail==mail).Select(y=>y.Id).FirstOrDefault();
            var cagrilar=db.Tbl_Cagrilar. Where (x=> x.Durum==true&& x.CagriFirma==id). ToList();
            return View(cagrilar);
        }
        public ActionResult PasifCagrilar()
        {
            var mail = (string)Session["Mail"];
            var id = db.Tbl_Firmalar.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();
            var cagrilar = db.Tbl_Cagrilar.Where(x => x.Durum == false && x.CagriFirma == id).ToList();
            return View(cagrilar);
        }
        [HttpGet]
        public ActionResult YeniCagri()
        {  return View(); }

        [HttpPost]
        public ActionResult YeniCagri(Tbl_Cagrilar p)
        {
            var mail = (string)Session["Mail"];
            var id = db.Tbl_Firmalar.Where(x => x.Mail == mail).Select(y => y.Id).FirstOrDefault();
            p.Durum = true;
            p.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CagriFirma = id;
            db.Tbl_Cagrilar.Add(p);
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        public ActionResult CagriDetay(int  id)
        {
            var cagri=db.Tbl_CagriDetay.Where(x=>x.Cagri==id).ToList();
            return View(cagri);
        }
        public ActionResult CagriGetir(int id)
        {
            var cagri = db.Tbl_Cagrilar.Find(id);
            return View("CagriGetir",cagri);
        }
        public ActionResult CagriDuzenle(Tbl_Cagrilar p)
        {
            var cagri=db.Tbl_Cagrilar.Find(p.Id);
            cagri.Konu= p.Konu;
            cagri.Aciklama= p.Aciklama;
            db.SaveChanges();
            return RedirectToAction("AktifCagrilar");
        }
        [HttpGet]
        public ActionResult ProfilDuzenle()
        {
            var mail = (string)Session["Mail"];
            var id=db.Tbl_Firmalar.Where(x=>x.Mail==mail).Select(y=>y.Id).FirstOrDefault();
            var profil = db.Tbl_Firmalar.Where(x=>x.Id==id).FirstOrDefault();
            return View(profil);
        }

        public ActionResult AnaSayfa()
        {
            return View();
        }
    }
}