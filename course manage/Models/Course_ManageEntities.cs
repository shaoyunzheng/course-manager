namespace course_manage.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class course_manageEntities : DbContext
    {
        public course_manageEntities()
            : base("name=CourseManagerContext")
        {
        }

        public virtual DbSet<ActionLinks> ActionLinks { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseManagements> CourseManagements { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<SideBars> SideBars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionLinks>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ActionLinks>()
                .Property(e => e.Controller)
                .IsFixedLength();

            modelBuilder.Entity<ActionLinks>()
                .Property(e => e.Action)
                .IsFixedLength();
        }
    }
}
