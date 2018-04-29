using Business.Concrete;
using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeYonetimSistemi_UI.Controllers
{
    public class ProjeController : Controller
    {
        //
        // GET: /Proje/
        ProjeManagement _projeManagement = new ProjeManagement();
        KullaniciManagement _kullaniciManagement = new KullaniciManagement();
        public ActionResult Projeler()
        {


           // string name=null;
            
           // try
           // {
           //     name = Session["UserName"].ToString();
           //     TempData["Hosgeldin"] = name;
           // }

           //catch
           // {
           //    return  RedirectToAction("Login", "Login");
           // }
               
        	
               
          
            
               
            
            var model = _projeManagement.GetAll();
            return View(model);
        }

        public ActionResult ProjeEkle()
        {

            return View();
        }
        [HttpPost,ActionName("ProjeEkle")]
        public ActionResult ProjeEkle1(Proje entity)
        {
            string kullanici=Session["UserName"].ToString();
            var user=_kullaniciManagement.Get(x=>x.KullaniciAdi==kullanici);

            Proje proje = new Proje();
            proje.ProjeAdi = entity.ProjeAdi;
            proje.Aciklama = entity.Aciklama;
            proje.KayitTarih = DateTime.Now;
            proje.Olusturan = user.KullaniciAdi;
            proje.KullaniciID = user.KullaniciID;

            _projeManagement.Add(proje);
            
            return RedirectToAction("Projeler");
        }

        public ActionResult ProjeDetay(int? id)
        {
            Proje proje = null;

            if (id.HasValue)
            {
                proje = _projeManagement.Get(x => x.ProjeID == id);
                return View(proje);
            }

            return RedirectToAction("Projeler");
        }
    
        [HttpPost]
        public ActionResult ProjeGuncelle(Proje entity)
        {
            Proje guncelle = null;
            if (entity.ProjeID != null)
            {
                guncelle = _projeManagement.Get(x => x.ProjeID == entity.ProjeID);
                guncelle.ProjeAdi = entity.ProjeAdi;
                guncelle.Aciklama = entity.Aciklama;
                guncelle.Olusturan = entity.Olusturan;
                guncelle.KayitTarih = entity.KayitTarih;
                try
                {
                    _projeManagement.Update(guncelle);
                }
                catch (Exception)
                {

                    return View(entity);
                }
                return RedirectToAction("Projeler");
            }
            return View();
        }

        public ActionResult ProjeDelete(int id)
        {
            var model = _projeManagement.Get(x => x.ProjeID == id);
            return View(model);
        }
        [HttpPost, ActionName("ProjeDelete")]
        public ActionResult ProjeDelete1(int ? id)
        {
            Proje proje = null;
            if(id.HasValue)
            {
                proje = _projeManagement.Get(x => x.ProjeID == id);
              
                    _projeManagement.Delete(proje);
           
            }

            return RedirectToAction("Projeler");
        }
	}
}