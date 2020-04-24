using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Team1Centric940.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Team1Centric940.DAL
{
    public class MIS4200Team1Context : DbContext
    {
        public MIS4200Team1Context() : base("name=DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Team1Context, Team1Centric940.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Giver> Givers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}