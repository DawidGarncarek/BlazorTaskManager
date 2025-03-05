using BlazorTaskManager.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorTaskManager.Models.Task
{
    public class TaskContext : IdentityDbContext<ApplicationUser>
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Description).HasMaxLength(1000);
                entity.Property(e => e.DueDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
                entity.Property(e => e.UserName).HasMaxLength(50);
            });
        }
    }
}
