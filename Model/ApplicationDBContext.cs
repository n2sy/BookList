using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace booklist.Model
{
     public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options)
            {
                
            }

            public DbSet<Book> Livre {get; set; }

        }
}