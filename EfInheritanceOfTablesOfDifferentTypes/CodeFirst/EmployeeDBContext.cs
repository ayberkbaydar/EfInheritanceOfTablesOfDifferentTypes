using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<ContractEmployee>().ToTable("ContractEmployees");
            modelBuilder.Entity<PermanentEmployee>().ToTable("PermanentEmployees");
            base.OnModelCreating(modelBuilder);
        }
    }
}