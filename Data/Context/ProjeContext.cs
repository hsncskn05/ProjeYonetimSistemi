using Entity.EntityFramework;
using Entity.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public partial class ProjeContext : DbContext
    {
        static ProjeContext()
        {
            Database.SetInitializer<ProjeContext>(null);
        }

        //public ProjeContext()
        //    : base("Name=ProjeContext")
        //{
        //}
        public ProjeContext()
            : base("Server=.;Database=Proje;Integrated Security=True;")
        {

        }
        public DbSet<AtananKisi> AtananKisis { get; set; }

        public DbSet<GorevDurum> GorevDurums { get; set; }
        public DbSet<Gorev> Gorevs { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Proje> Projes { get; set; }
    

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GorevMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new ProjeMap());
            modelBuilder.Configurations.Add(new AtananKisiMap());
         
            modelBuilder.Configurations.Add(new GorevDurumMap());
         
        }
    }
}
