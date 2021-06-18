using EFSchoolPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFSchoolPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFSchoolPortal;Trusted_Connection=True;MultipleActiveResultSets=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<Student>().HasKey(s => new { s.ID });
            modelBuilder.Entity<Course>().HasKey(c => new { c.ID });
            modelBuilder.Entity<Teacher>().HasKey(t => new { t.ID });
            modelBuilder.Entity<Assignment>().HasKey(a => new { a.ID });

            modelBuilder.Entity<Assignment>()
                .HasOne<Course>(a => a.Course)
                .WithMany(c => c.Assignments)
                .HasForeignKey(a => a.CourseID);

            modelBuilder.Entity<Course>()
                .HasOne<Teacher>(t => t.Teacher)
                .WithOne(t => t.Course)
                .HasForeignKey<Teacher>(t => t.CourseId);

            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, Fname = "Hans", Lname = "Danielsson", Email = "HansDanielsson11@domain.com" },
                new Student { ID = 2, Fname = "Alexsandra", Lname = "Gustafsson", Email = "AlexsandraGustafsson23@domain.com" },
                new Student { ID = 3, Fname = "Karl", Lname = "Olofsson", Email = "Karl_Olofsson21@domain.com" }
                );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { ID = 1, Fname = "Hans", Lname = "Andersson", Email = "HansAndersson11@stud.port.com", CourseId = 1 },
                new Teacher { ID = 2, Fname = "Cornelia", Lname = "Johnsson", Email = "CorneliaJohnsson22@stud.port.com", CourseId = 2 },
                new Teacher { ID = 3, Fname = "Yusuf", Lname = "Ekström", Email = "YusufEkstrom23@stud.port.com", CourseId = 3 }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { ID = 1, Acronym = "C001", Topic = "Data Structures" },
                new Course { ID = 2, Acronym = "C030", Topic = "Object Oriented Programming in Java" },
                new Course { ID = 3, Acronym = "C022", Topic = "Programming in C#" }
                );

            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { ID = 1, Name = "Linear Data Structures", DueDate = "v40", CourseID = 1 },
                new Assignment { ID = 2, Name = "Binary Tree Implementation", DueDate = "v45", CourseID = 1 },
                new Assignment { ID = 3, Name = "Inheritance and Polymorphism", DueDate = "v42", CourseID = 2 },
                new Assignment { ID = 4, Name = "Collections and Exceptions", DueDate = "v43", CourseID = 2 },
                new Assignment { ID = 5, Name = "Hello World in C#", DueDate = "v41", CourseID = 3 },
                new Assignment { ID = 6, Name = "Data types in C#", DueDate = "v44", CourseID = 3 }
                );

        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }



    }
}
