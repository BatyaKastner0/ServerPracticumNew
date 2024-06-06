using Managment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Data
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options)
        //{

        //}


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> RoleNamesArr { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BatyaData");
            optionsBuilder.LogTo((message) => Debug.Write(message));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeRole>()
                .HasKey(e => new { e.RoleId, e.EmployeeId });
        }
    }
}

