using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityFramework
{
    public partial class Proje:IEntity
    {
        public Proje()
        {
            this.Gorevs = new List<Gorev>();
        }

        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public string Olusturan { get; set; }
        public Nullable<System.DateTime> KayitTarih { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public virtual ICollection<Gorev> Gorevs { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
