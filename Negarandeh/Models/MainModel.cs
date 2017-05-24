namespace Negarandeh.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainModel : DbContext
    {
        public MainModel()
            : base("name=MainModel")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(e => e.Seasons)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Season)
                .WillCascadeOnDelete(false);
        }
    }
}
