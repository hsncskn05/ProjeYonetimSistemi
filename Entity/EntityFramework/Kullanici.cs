using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityFramework
{
    public partial class Kullanici:IEntity
    {
        public Kullanici()
        {
            this.Gorevs = new List<Gorev>();
            this.Projes = new List<Proje>();
        }

        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public virtual ICollection<Gorev> Gorevs { get; set; }
        public virtual ICollection<Proje> Projes { get; set; }
    }
}
