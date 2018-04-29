using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjeYonetimSistemi_UI.Models
{
    public class GorevProjeViewModel
    {
        public List<Gorev> Gorevler { get; set; }
        public List<Proje> Projeler { get; set; }
    }
}