using Entity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Mapping
{
    public class GorevDurumMap : EntityTypeConfiguration<GorevDurum>
    {
        public GorevDurumMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.Gorev)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GorevDurum");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.Gorev).HasColumnName("Gorev");
        }
    }
}
