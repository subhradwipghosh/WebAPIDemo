using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTry30Sept21.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions options):base(options)
        {

        }

        public virtual DbSet<Employee> EmployeesDatabase { get; set; }  //Try after removing this table and updating database again

        public virtual DbSet<User> Users { get; set; }
    }
}
