using Business.Concrete;
using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeYonetimSistemi_UI.Controllers
{
    public class GorevController : Controller
    {
        //
        // GET: /Gorev/
        GorevManagement _gorevManagement = new GorevManagement();
        ProjeManagement _projeManagement = new ProjeManagement();
        KullaniciManagement _kullaniciManagement = new KullaniciManagement();
        GorevDurumManagement _gorevdurumManagement = new GorevDurumManagement();
        AtananKisiManagement _atananKisiManagement = new AtananKisiManagement();
   
      
   

        public ActionResult Gorevler(int ? id)
        {
            //var model = _gorevManagement.GetAll(x => x.ProjeID == id);
            //return View(model);
            int gorev;
          
            try
            {
                 gorev = (int)(_gorevManagement.Get(x => x.ProjeID == id).ProjeID);
            }
            catch
            {
                TempData["status"] = "danger";
                TempData["message"] = "Projeye ait görev yok";

                return RedirectToAction("GorevEkle", "Gorev", new { id =id });
            }


            if (gorev!=null)
                 {
                     
                         IEnumerable<Gorev> model = _gorevManagement.GetAll(x => x.ProjeID == gorev).Select(x => new Gorev
                         {
                             GorevAdi = x.GorevAdi,
                             GorevDurum = x.GorevDurum,
                             Olusturan = x.Olusturan,
                             AtananKisi = x.AtananKisi,
                             OlusturmaTarih = x.OlusturmaTarih,
                             BitisTarih = x.BitisTarih,
                             Proje = _projeManagement.Get(y => y.ProjeID == x.ProjeID),
                             ProjeID = x.ProjeID,
                             GorevID = x.GorevID



                         }).ToList();

                         return View(model);
                     
                  
               
              
            }



             return RedirectToAction("Projeler", "Proje");
            
        }

        //public ActionResult GorevEkle(int id)
        //{
        //    var model = _gorevManagement.Get(x => x.Proje.ProjeID == id);

        //    ViewBag.Gorev = _gorevManagement.GetAll();


        //    return View(model);
        //}
         [OutputCache(Duration = 15)]
        public ActionResult GorevEkle(int id)
        {
           
                var model = _projeManagement.Get(x => x.ProjeID == id);

                ViewBag.GorevDurum = _gorevdurumManagement.GetAll().Select(x => x.Gorev).Distinct();
                ViewBag.GorevAtanan = _atananKisiManagement.GetAll().Select(x => x.Atanan).Distinct();
                return View(model);
          
          
        }

        [HttpPost,ActionName("GorevEkle")]
        public ActionResult GorevEkle1(Gorev entity)
        {
            string kullanici=Session["UserName"].ToString();
            var user=_kullaniciManagement.Get(x=>x.KullaniciAdi==kullanici);
            int id;
            if(entity.ProjeID!=null)
            {

         
            Gorev gorev = new Gorev();
            gorev.GorevAdi = entity.GorevAdi;
            gorev.GorevDurum = entity.GorevDurum;
            gorev.OlusturmaTarih = DateTime.Now;
            gorev.BitisTarih = entity.BitisTarih;
            gorev.AtananKisi = entity.AtananKisi;
            gorev.ProjeID = entity.ProjeID;
            gorev.Olusturan = user.KullaniciAdi;
            gorev.KullaniciID = user.KullaniciID;
            id = (int)gorev.ProjeID;
            try
            {
                _gorevManagement.Add(gorev);
                ViewBag.status = "success";
                ViewBag.message = "Gorev Başarıyla eklendi.";
            }
            catch (Exception)
            {
                ViewBag.status = "danger";
                ViewBag.message = "Gorev eklenmedi. Lütfen Tekrar Deneyiniz.";
                return View(gorev);
            }
            return RedirectToAction("Gorevler", new { id = id });
            }
            return View();

            
           
        }



         [OutputCache(Duration = 15)]
        public ActionResult GorevDetay(int ? id)
        {
            Gorev gorev = null;

            if (id.HasValue)
            {
                gorev = _gorevManagement.Get(x => x.GorevID == id);

                ViewBag.GorevDurum = _gorevdurumManagement.GetAll().Select(x => x.Gorev).Distinct();
                ViewBag.GorevAtanan = _atananKisiManagement.GetAll().Select(x => x.Atanan).Distinct();
                //var gorevler = _gorevManagement.GetAll();
             

                return View(gorev);
            }

            return RedirectToAction("Gorevler");
        }

         [HttpPost]
         public ActionResult GorevGuncelle(Gorev entity)
         {

             Gorev guncelle = null;
             if (entity.GorevID != null)
             {
                 guncelle = _gorevManagement.Get(x => x.GorevID == entity.GorevID);
                 guncelle.GorevAdi = entity.GorevAdi;
                 guncelle.GorevDurum = entity.GorevDurum;
                 guncelle.GorevID = entity.GorevID;
                 guncelle.BitisTarih = entity.BitisTarih;
                 guncelle.AtananKisi = entity.AtananKisi; 
                 try
                 {
                     _gorevManagement.Update(guncelle);
                 }
                 catch (Exception)
                 {

                     return View(entity);
                 }
                 return RedirectToAction("Gorevler", new { id = entity.ProjeID });
             }
             return View();
         }
	}
}