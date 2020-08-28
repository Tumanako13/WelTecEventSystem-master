using Microsoft.EntityFrameworkCore;

namespace WelTecEventSystem.Models
{
    public partial class WelTecOnlineRegistrationContext : DbContext
    {
        public WelTecOnlineRegistrationContext()
        {
        }

        public WelTecOnlineRegistrationContext(DbContextOptions<WelTecOnlineRegistrationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-94C3COP\\SQLEXPRESS;Database=WelTecOnlineRegistration;Integrated Security=True");
                //optionsBuilder.UseSqlServer("Server=LAPTOP-M6CFMRF3\\SQLEXPRESS;Database=WelTecOnlineRegistration;Integrated Security=True");

                optionsBuilder.UseSqlServer("Server=DESKTOP-291JE9Q\\SQLEXPRESS;Database=WelTecOnlineRegistration;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.EventName)
                    .HasName("PK__tmp_ms_x__59D2B72706406018");

                entity.Property(e => e.EventName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventClassroom)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("date");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EventHost)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventImage1).HasColumnType("image");

                entity.Property(e => e.EventImage2).HasColumnType("image");

                entity.Property(e => e.EventImage3).HasColumnType("image");

                entity.Property(e => e.EventLocation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EventRequirements)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime).HasColumnType("time(0)");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserMainEmail)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.EventNameNavigation)
                    .WithMany(p => p.Register)
                    .HasForeignKey(d => d.EventName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Register_EventName");

                entity.HasOne(d => d.UserMainEmailNavigation)
                    .WithMany(p => p.Register)
                    .HasForeignKey(d => d.UserMainEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Register_UserMainEmail");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserMainEmail)
                    .HasName("PK__tmp_ms_x__8427051057357D2E");

                entity.Property(e => e.UserMainEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserSecondEmail)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}