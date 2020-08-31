using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Pramod Kumar",
                    Email = "pramodv@chetu.com",
                    Department = Dept.Development
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rameshwar",
                    Email = "ramup@chetu.com",
                    Department = Dept.IT
                }
                );
        }
    }
}
