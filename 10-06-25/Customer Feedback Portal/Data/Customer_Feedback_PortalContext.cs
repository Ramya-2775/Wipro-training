using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer_Feedback_Portal.Models;

namespace Customer_Feedback_Portal.Data
{
    public class Customer_Feedback_PortalContext : DbContext
    {
        public Customer_Feedback_PortalContext (DbContextOptions<Customer_Feedback_PortalContext> options)
            : base(options)
        {
        }

        public DbSet<Customer_Feedback_Portal.Models.Feedback> Feedback { get; set; } = default!;
    }
}
