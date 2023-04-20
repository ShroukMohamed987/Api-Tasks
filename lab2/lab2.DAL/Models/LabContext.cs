using Lab2.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.DAL.Models
{
    public class LabContext:DbContext
    {
       public  DbSet<Ticket> tickets => Set<Ticket>();
       public DbSet<Develpoer>develpoers => Set<Develpoer>();
       public DbSet<Department> department => Set<Department>();
        public LabContext(DbContextOptions<LabContext>options):base(options)
        {
            
        }

    }
}
