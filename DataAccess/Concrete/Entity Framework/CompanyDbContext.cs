using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4SAB20T\MYSQL;Database=CompanyProject;Integrated Security = True");
        }
        public DbSet<SoldProduct> SoldProduct { get; set; }
        public DbSet<ProductRegistration> ProductRegistration { get; set; }
        public DbSet<CustomerRegistration> CustomerRegistration { get; set; }
        public DbSet<Authorized> Authorized { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
