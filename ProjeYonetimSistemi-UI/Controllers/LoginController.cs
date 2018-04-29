using Business.Concrete;
using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeYonetimSistemi_UI.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        KullaniciManagement _kullaniciManagement = new KullaniciManagement();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost,ActionName("Login")]
        public ActionResult Login1(string KullaniciAdi, string Password)
        {
          
            foreach (var item in _kullaniciManagement.GetAll())
            {
                if (item.KullaniciAdi == KullaniciAdi && item.Sifre == Password)
                {

                    Session["UserName"] = KullaniciAdi;
                    return RedirectToAction("Projeler", "Proje");
                    //return Json(sonuc, JsonRequestBehavior.AllowGet);
                }
                else
                {
                 
                    ViewBag.durum = "Hatalı Kullanıcı Adı veya Şifre";
                    return View();
                   // return Json(sonuc, JsonRequestBehavior.AllowGet);
                }
            }

            return View();
        }

	}
}