namespace Data.Migrations
{
    using Entity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.ProjeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Data.Context.ProjeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            GorevDurum gd1 = new GorevDurum();
            gd1.Gorev = "Development";
            GorevDurum gd2 = new GorevDurum();
            gd2.Gorev = "Done";
            GorevDurum gd3 = new GorevDurum();
            gd3.Gorev = "To do";
            context.GorevDurums.Add(gd1);
            context.GorevDurums.Add(gd2);
            context.GorevDurums.Add(gd3);
            context.SaveChanges();

            AtananKisi a1 = new AtananKisi();
            a1.Atanan = "Hasan";
            AtananKisi a2 = new AtananKisi();
            a2.Atanan = "Ahmet";
            AtananKisi a3 = new AtananKisi();
            a3.Atanan = "enes";
            AtananKisi a4 = new AtananKisi();
            a4.Atanan = "Gurkan";
            context.AtananKisis.Add(a1);
            context.AtananKisis.Add(a2);
            context.AtananKisis.Add(a3);
            context.AtananKisis.Add(a4);
            context.SaveChanges();

            Kullanici k1 = new Kullanici();
            k1.KullaniciAdi = "hasan";
            k1.Sifre = "123";

            Kullanici k2 = new Kullanici();
            k2.KullaniciAdi = "gurkan";
            k2.Sifre = "123";

            context.Kullanicis.Add(k1);
            context.Kullanicis.Add(k2);
            context.SaveChanges();

            Proje p1 = new Proje();
            p1.ProjeAdi = "Teknik Servis Yazýlýmý";
            p1.Aciklama = "deneme projesi";
            p1.Olusturan = k1.KullaniciAdi;
            p1.KayitTarih = DateTime.Now;
            p1.KullaniciID = k1.KullaniciID;

            Proje p2 = new Proje();
            p2.ProjeAdi = "General Mobile Servis Yazýlýmý";
            p2.Aciklama = "deneme projesi";
            p2.Olusturan = k2.KullaniciAdi;
            p2.KayitTarih = DateTime.Now;
            p2.KullaniciID = k2.KullaniciID;

            context.Projes.Add(p1);
            context.Projes.Add(p2);
            context.SaveChanges();

            Gorev g1 = new Gorev();

            g1.GorevAdi = "BC2";
            g1.GorevDurum = "Done";
            g1.Olusturan = k1.KullaniciAdi;
            g1.OlusturmaTarih = DateTime.Now;
            g1.BitisTarih = DateTime.Now;
            g1.AtananKisi = "hasan";
            g1.ProjeID = p1.ProjeID;
            g1.KullaniciID = k1.KullaniciID;

            Gorev g2 = new Gorev();

            g2.GorevAdi = "Geliþtirme";
            g2.GorevDurum = "Done";
            g2.Olusturan = k1.KullaniciAdi;
            g2.OlusturmaTarih = DateTime.Now;
            g2.BitisTarih = DateTime.Now;
            g2.AtananKisi = "hasan";
            g2.ProjeID = p1.ProjeID;
            g2.KullaniciID = k1.KullaniciID;

            context.Gorevs.Add(g1);
            context.Gorevs.Add(g2);
            context.SaveChanges();

        }
    }
}
