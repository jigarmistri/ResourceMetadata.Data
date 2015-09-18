using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DataModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Configurations
{

    public class TechnicianConfiguation : EntityTypeConfiguration<Technician>
    {
        public TechnicianConfiguation()
        {
            ToTable("Technician");

            HasKey(p => p.TechnicianID).Property(p => p.TechnicianID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //CategoryId as foreign key
            HasRequired(p => p.ComplainMasters); 
                //.WithMany(c => c.)
            //    .HasForeignKey(p => p.ComplainID);
            //Property(p => p.TypeName).IsRequired().HasMaxLength(200);
            //Property(p => p.CreatedDate);

        }
    }

}
