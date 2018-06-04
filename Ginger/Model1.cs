namespace Ginger
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Master> Masters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Master>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Master>()
                .Property(e => e.Value)
                .IsFixedLength();
        }
    }
}
