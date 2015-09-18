using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Configurations
{

    public class ComplainTypeConfiguration : EntityTypeConfiguration<ComplainType>
    {
        public ComplainTypeConfiguration()
        {
            ToTable("ComplainType");

            HasKey(p => p.ComplainTypeID).Property(p => p.ComplainTypeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //CategoryId as foreign key
            HasRequired(p => p.ComplainMaster)
                .WithMany(c => c.ComplainTypes)
                .HasForeignKey(p => p.ComplainID);
            Property(p => p.TypeName).IsRequired().HasMaxLength(200);
            Property(p => p.CreatedDate);
        }
    }

}
