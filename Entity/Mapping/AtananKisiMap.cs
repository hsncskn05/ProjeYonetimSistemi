using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Mapping
{
    public class AtananKisiMap : EntityTypeConfiguration<AtananKisi>
    {
        public AtananKisiMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Atanan)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AtananKisi");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Atanan).HasColumnName("Atanan");
        }
    }
}
