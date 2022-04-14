using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace samet_turgut.Controllers
{
    public class EmlakController : Controller
    {
        public ActionResult Anasayfa()
        {   

            return View("Anasayfa");
        }
        public ActionResult KurumsalUyelik()
        {
            return View("Anasayfa");
        }
        public ActionResult Projeler()
        {
            return View("Anasayfa");
        }

        public PartialViewResult SiteBaslik()
        {
            return PartialView("SiteBaslik");
        }

        public PartialViewResult SiteAltBaslik()
        {
            return PartialView("SiteAltBaslik");
        }

        public PartialViewResult OneCikanilanlar()
        {
            return PartialView("OneCikanilanlar");
        }

        public PartialViewResult EnYeniilanlar()
        {
            return PartialView("EnYeniilanlar");
        }
        public ActionResult EmlakDetay1()
        { Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 1;
            emlakBilgi.MetreKare = 100;
            emlakBilgi.BanyoSayisi = 1;
            emlakBilgi.OdaSayisi = 4;
            emlakBilgi.BinaYasi = 5;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay1", emlakBilgi);
        }
        public ActionResult EmlakDetay2()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 2;
            emlakBilgi.MetreKare = 150;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 6;
            emlakBilgi.BinaYasi = 7;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay2", emlakBilgi);
        }
        public ActionResult EmlakDetay3()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 3;
            emlakBilgi.MetreKare = 120;
            emlakBilgi.BanyoSayisi = 1;
            emlakBilgi.OdaSayisi = 5;
            emlakBilgi.BinaYasi = 9;
            emlakBilgi.KullanimDurumu = "Eşyalı";
            emlakBilgi.Kimden = "Emlakçıdan";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay3", emlakBilgi);
        }
        public ActionResult EmlakDetay4()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 4;
            emlakBilgi.MetreKare = 200;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 7;
            emlakBilgi.BinaYasi = 10;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay4", emlakBilgi);
        }
        public ActionResult EmlakDetay5()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 5;
            emlakBilgi.MetreKare = 165;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 5;
            emlakBilgi.BinaYasi = 15;
            emlakBilgi.KullanimDurumu = "Eşyalı";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay5", emlakBilgi);
        }
        public ActionResult EmlakDetay6()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 6;
            emlakBilgi.MetreKare = 250;
            emlakBilgi.BanyoSayisi = 3;
            emlakBilgi.OdaSayisi = 7;
            emlakBilgi.BinaYasi = 3;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay6", emlakBilgi);
        }
        public ActionResult EmlakDetay7()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 7;
            emlakBilgi.MetreKare = 225;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 5;
            emlakBilgi.BinaYasi = 12;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay7", emlakBilgi);
        }
        public ActionResult EmlakDetay8()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 8;
            emlakBilgi.MetreKare = 190;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 4;
            emlakBilgi.BinaYasi = 5;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Emlakçıdan";
            emlakBilgi.IlanTarihi = DateTime.Today;
            return View("EmlakDetay8", emlakBilgi);
        }
        public ActionResult EmlakDetay9()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 9;
            emlakBilgi.MetreKare = 150;
            emlakBilgi.BanyoSayisi = 2;
            emlakBilgi.OdaSayisi = 4;
            emlakBilgi.BinaYasi = 9;
            emlakBilgi.KullanimDurumu = "Eşyalı";
            emlakBilgi.Kimden = "Sahibinden";
            emlakBilgi.IlanTarihi = DateTime.Now;
            return View("EmlakDetay9", emlakBilgi);
        }
        public ActionResult EmlakDetay10()
        {
            Models.EmlakBilgi emlakBilgi = new Models.EmlakBilgi();
            emlakBilgi.IlanNo = 10;
            emlakBilgi.MetreKare = 350;
            emlakBilgi.BanyoSayisi = 3;
            emlakBilgi.OdaSayisi = 7;
            emlakBilgi.BinaYasi = 2;
            emlakBilgi.KullanimDurumu = "Eşyasız";
            emlakBilgi.Kimden = "Emlakçıdan";
            emlakBilgi.IlanTarihi = DateTime.Today;
            return View("EmlakDetay10", emlakBilgi);
        }
        public ActionResult EmlaklarListe()
        {
            return View("EmlaklarListe");
        }
    }
}