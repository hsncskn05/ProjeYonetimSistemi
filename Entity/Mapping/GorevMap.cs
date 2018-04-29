using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Mapping
{
    public class GorevMap : EntityTypeConfiguration<Gorev>
    {
        public GorevMap()
        {
            // Primary Key
            this.HasKey(t => t.GorevID);

            // Properties
            this.Property(t => t.GorevAdi)
                .HasMaxLength(50);

            this.Property(t => t.GorevDurum)
                .HasMaxLength(50);

            this.Property(t => t.Olusturan)
                .HasMaxLength(50);

            this.Property(t => t.AtananKisi)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Gorev");
            this.Property(t => t.GorevID).HasColumnName("GorevID");
            this.Property(t => t.GorevAdi).HasColumnName("GorevAdi");
            this.Property(t => t.GorevDurum).HasColumnName("GorevDurum");
            this.Property(t => t.Olusturan).HasColumnName("Olusturan");
            this.Property(t => t.OlusturmaTarih).HasColumnName("OlusturmaTarih");
            this.Property(t => t.BitisTarih).HasColumnName("BitisTarih");
            this.Property(t => t.AtananKisi).HasColumnName("AtananKisi");
            this.Property(t => t.ProjeID).HasColumnName("ProjeID");
            this.Property(t => t.KullaniciID).HasColumnName("KullaniciID");

            // Relationships
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Gorevs)
                .HasForeignKey(d => d.KullaniciID);
            this.HasOptional(t => t.Proje)
                .WithMany(t => t.Gorevs)
                .HasForeignKey(d => d.ProjeID);

        }
    }
}
