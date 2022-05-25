using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiProject.Data
{
    public partial class SportsEventsContext : DbContext
    {
        public SportsEventsContext()
        {
        }

        public SportsEventsContext(DbContextOptions<SportsEventsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6E66B9L;Initial Catalog=SportsEvents;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Competition)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Opponents)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Sport)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.TimeOfEvent).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
