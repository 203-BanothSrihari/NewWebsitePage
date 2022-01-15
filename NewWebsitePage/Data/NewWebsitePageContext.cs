using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewWebsitePage.Models;

namespace NewWebsitePage.Data
{
    public class NewWebsitePageContext : DbContext
    {
        public NewWebsitePageContext (DbContextOptions<NewWebsitePageContext> options)
            : base(options)
        {
        }

        public DbSet<NewWebsitePage.Models.Employee> Employee { get; set; }
    }
}
