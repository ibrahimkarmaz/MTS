using EntityLayer.Entity;
using EntityLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMAP());
            modelBuilder.Configurations.Add(new NoteMAP());
            modelBuilder.Configurations.Add(new SupportMAP());
            modelBuilder.Configurations.Add(new SupportPeriodMAP());
            modelBuilder.Configurations.Add(new CountyMAP());
            modelBuilder.Configurations.Add(new DistrictMAP());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<SupportPeriod> SupportPeriods { get; set; }
        public DbSet<County> Countys { get; set; }
        public DbSet<District> Districts { get; set; }
    }
}
