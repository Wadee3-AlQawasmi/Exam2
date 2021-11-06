using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Data
{
    public class CompanyContext:DbContext
    {
        IConfiguration configuration;
        public CompanyContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> Employee { set; get; }
        public DbSet<Country> Country { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Exam2"));
            base.OnConfiguring(optionsBuilder);
        }

    }
}
