using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Team1Centric940.Models;


namespace Team1Centric940.DAL
{
    public class MIS4200Team1Context : DbContext
    {
        public MIS4200Team1Context() : base("name=DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Team1Context, Team1Centric940.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet<Giver> Givers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Gratitude> Gratitudes { get; set; }
    }
}