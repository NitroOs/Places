//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using Places.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Places.DAL
{
    public class PlaceContext: DbContext
    {
        public DbSet<County> Countys { get; set; }
        public DbSet<Place> Places { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer<PlaceContext>(null);
        }
    }
}