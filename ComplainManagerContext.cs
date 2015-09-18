using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Data.Configurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration;

namespace ResourceMetadata.Data
{
    public class ComplainManagerEntities : DbContext
    {
        public ComplainManagerEntities()
            : base("ComplainManagerEntities")
        {

        }

        public virtual DbSet<ComplainMaster> ComplainMasters { get; set; }
        public virtual DbSet<ComplainType> ComplainTypes { get; set; }
        public virtual DbSet<Technician> Technicians { get; set; }
        public virtual DbSet<User> Users { get; set; }

        //public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //        modelBuilder.Entity<ComplainMaster>()
            //.HasMany(e => e.ComplainTypes)
            //.WithRequired(e => e.ComplainMaster)
            //.WillCascadeOnDelete(false);
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
       .Where(type => !String.IsNullOrEmpty(type.Namespace))
       .Where(type => type.BaseType != null && type.BaseType.IsGenericType
            && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
        
    }

    public class ComplainManagerDbInitializer : DropCreateDatabaseIfModelChanges<ComplainManagerEntities>
    {
        //protected override void Seed(ComplainManagerEntities context)
        //{
        //    try
        //    {
        //        var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //        userManager.UserValidator = new UserValidator<ApplicationUser>(userManager)
        //        {
        //            AllowOnlyAlphanumericUserNames = false
        //        };
        //        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

        //        if (!roleManager.RoleExists("Admin"))
        //        {
        //            roleManager.Create(new IdentityRole("Admin"));
        //        }

        //        if (!roleManager.RoleExists("Member"))
        //        {
        //            roleManager.Create(new IdentityRole("Member"));
        //        }

        //        var user = new ApplicationUser();
        //        user.FirstName = "Admin";
        //        user.LastName = "Marlabs";
        //        user.Email = "admin@marlabs.com";
        //        user.UserName = "admin@marlabs.com";

        //        var userResult = userManager.Create(user, "Marlabs");

        //        if (userResult.Succeeded)
        //        {
        //            //var user = userManager.FindByName("admin@marlabs.com");
        //            userManager.AddToRole<ApplicationUser>(user.Id, "Admin");
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

        //    //context.Users.Add(new ApplicationUser { Email = "abc@yahoo.com", Password = "Marlabs" });
        //    //context.SaveChanges();           
        //}
    }

}
