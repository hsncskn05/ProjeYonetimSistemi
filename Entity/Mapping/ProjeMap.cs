using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Mapping
{
    public class ProjeMap : EntityTypeConfiguration<Proje>
    {
        public ProjeMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjeID);

            // Properties
            this.Property(t => t.ProjeAdi)
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(500);

            this.Property(t => t.Olusturan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Proje");
            this.Property(t => t.ProjeID).HasColumnName("ProjeID");
            this.Property(t => t.ProjeAdi).HasColumnName("ProjeAdi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
            this.Property(t => t.Olusturan).HasColumnName("Olusturan");
            this.Property(t => t.KayitTarih).HasColumnName("KayitTarih");
            this.Property(t => t.KullaniciID).HasColumnName("KullaniciID");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Projes)
                .HasForeignKey(d => d.KullaniciID);

        }
    }
}
