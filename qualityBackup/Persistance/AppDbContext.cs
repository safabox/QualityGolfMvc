using Microsoft.AspNet.Identity.EntityFramework;
using qualityBackup.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace qualityBackup.Persistance
{

    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<IdentityUser>().ToTable("user");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user");
            //modelBuilder.Entity<IdentityRole>().ToTable("role");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("userrole");
            //modelBuilder.Entity<IdentityUserClaim>().ToTable("userclaim");
            //modelBuilder.Entity<IdentityUserLogin>().ToTable("userlogin");
        }

        public DbSet<Planes> Planes { get; set; }
        public DbSet<PlanType> PlanTypes { get; set; }
        public DbSet<Subscripcion> Subscriptions { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}