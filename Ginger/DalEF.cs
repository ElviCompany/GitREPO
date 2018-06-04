using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginger
{
    class DalEF
    {
    }
    public class WorkContext : DbContext
    {
        public WorkContext() : base("CompanyWorkers") { }
        public DbSet<Appartment> Appartments { get; set; }
        public virtual DbSet<GingerSettings> Masters { get; set; }
        //public virtual DbSet<GingerSettings> Masters { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Appartment>()
                .Map(m => {
                    m.MapInheritedProperties();
                    m.ToTable("Appartments");
                    });

        }
    }
}
