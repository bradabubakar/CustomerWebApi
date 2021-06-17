using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICustomer.Models
{
    public class CustomerDBContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
            : base(options)
        {
            
        }
    }
}
