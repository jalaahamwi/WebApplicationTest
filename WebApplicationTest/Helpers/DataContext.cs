using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Entities;

namespace WebApplicationTest.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        

        public DbSet<Personne> Personnes { get; set; }
    }
}
