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

    public class UsersConfiguration : EntityTypeConfiguration<User>
    {
        public UsersConfiguration()
        {
            ToTable("Users");

            HasKey(p => p.UserID).Property(p => p.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


        }
    }

}
