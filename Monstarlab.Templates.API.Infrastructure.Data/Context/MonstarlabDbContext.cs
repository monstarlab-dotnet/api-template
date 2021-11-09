using Microsoft.EntityFrameworkCore;
using Monstarlab.Templates.API.Domain.Models;
using System.Diagnostics.CodeAnalysis;

namespace Monstarlab.Templates.API.Infrastructure.Context
{
    public class MonstarlabDbContext : DbContext
    {
        public MonstarlabDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aarhus = new Department
            {
                Id = new Guid("4f1759f7-58fa-429b-a7b9-2fb375258df3"),
                City = "Aarhus",
                Country = "Denmark",
                Floor = "9",
                Number = "2F",
                Street = "Mariane Thomsens Gade",
                ZipCode = "8000"
            };
            var copenhagen = new Department
            {
                Id = new Guid("d8f7f42e-23a6-48b8-af97-a8cc3cb6c58b"),
                City = "Copenhagen",
                Country = "Denmark",
                Street = "Orientkaj",
                Number = "4",
                ZipCode = "2150"
            };

            modelBuilder.Entity<Department>()
                .HasData(new[]
                {
                    aarhus,
                    copenhagen
                });

            modelBuilder.Entity<Employee>()
                .HasOne<Department>(e => e.Department)
                .WithMany(d => d.Employees)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Employee>()
                .HasData(new[]
                {
                    new Employee
                    {
                        Id = new Guid("efb8f31e-cdd3-4d6b-96a3-3ee6fe9ae679"),
                        FirstName = "Morten",
                        LastName = "Turn Pedersen",
                        Age = 32,
                        DepartmentId = aarhus.Id
                    },
                    new Employee
                    {
                        Id = new Guid("35607bf7-9a00-489d-bf71-bbdb53f2f7d8"),
                        FirstName = "Morten",
                        LastName = "Pløger",
                        Age = 29,
                        DepartmentId = aarhus.Id
                    },
                    new Employee
                    {
                        Id = new Guid("fa4b4f52-0c8b-4839-bbc1-d33a9bf2ca38"),
                        FirstName = "Kasper",
                        LastName = "Welner",
                        Age = 31,
                        DepartmentId = copenhagen.Id
                    }
                });
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}