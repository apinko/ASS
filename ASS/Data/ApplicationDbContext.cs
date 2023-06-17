using ASS.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

public virtual DbSet<Class> Classes { get; set; }

public virtual DbSet<Course> Courses { get; set; }

public virtual DbSet<Enrollment> Enrollments { get; set; }

public virtual DbSet<Lecturer> Lecturers { get; set; }

public virtual DbSet<Student> Students { get; set; }


protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Course>().HasData(
        new Course
        {
            Id = 1,
            Name = "Kurs WWW"
        },
         new Course
         {
             Id = 2,
             Name = "Kurs JS"
         },
          new Course
          {
              Id = 3,
              Name = "Kurs Photoshop"
          }
        );

    modelBuilder.Entity<Lecturer>().HasData(
        new Lecturer
        {
            Id = 1,
            FirstName = "Tomasz",
            LastName = "Bury"
        },
         new Lecturer
         {
             Id = 2,
             FirstName = "Barbara",
             LastName = "Kowalska"
         },
          new Lecturer
          {
              Id = 3,
              FirstName = "Zofia",
              LastName = "Tarka"
          }
        );

    modelBuilder.Entity<Student>().HasData(
        new Student
        {
            Id = 1,
            FirstName = "Jan",
            LastName = "Dom"
        },
         new Student
         {
             Id = 2,
             FirstName = "Piot",
             LastName = "Zajazd"
         },
          new Student
          {
              Id = 3,
              FirstName = "Kasia",
              LastName = "Bura"
          }
        );

        }
    }
}