using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class EmployeeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7DLHQPG\\SQLEXPRESS;Database=Authenticauthor;User Id = employe; Password=13579;");
        }
       // public DbSet<StudentModel> Students { get; set; }
       public DbSet<Employee> employee { get; set; }
        //public DbSet<Student> student { set; get; }
    }
}
