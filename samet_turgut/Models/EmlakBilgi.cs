using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace samet_turgut.Models
{
    public class EmlakBilgi
    {
        public int IlanNo { get; set; }
        public int MetreKare { get; set; }
        public int BanyoSayisi { get; set; }
        public int OdaSayisi { get; set; }
        public int BinaYasi { get; set; }
        public string KullanimDurumu { get; set; }
        public string Kimden { get; set; }
        public DateTime IlanTarihi { get; set; }

    }
}