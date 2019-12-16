namespace course_manage.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SideBars")
        {
        }

        public virtual DbSet<SideBars> SideBars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SideBars>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Controller)
                .IsFixedLength();

            modelBuilder.Entity<SideBars>()
                .Property(e => e.Action)
                .IsFixedLength();
        }
    }
}
