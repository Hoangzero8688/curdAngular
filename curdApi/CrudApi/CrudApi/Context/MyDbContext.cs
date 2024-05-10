using CrudApi.Data;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace CrudApi.Context
{
    public class MyDbContext : DbContext    
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
