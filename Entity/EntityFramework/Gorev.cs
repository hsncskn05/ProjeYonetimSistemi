using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.EntityFramework
{
    public partial class Gorev :IEntity
    {
        public int GorevID { get; set; }
        public string GorevAdi { get; set; }
        public string GorevDurum { get; set; }
        public string Olusturan { get; set; }
        public Nullable<System.DateTime> OlusturmaTarih { get; set; }
        public Nullable<System.DateTime> BitisTarih { get; set; }
        public string AtananKisi { get; set; }
        public Nullable<int> ProjeID { get; set; }
        public Nullable<int> KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Proje Proje { get; set; }
    }
}
