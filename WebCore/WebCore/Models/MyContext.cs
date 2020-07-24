using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore.Models.ManageBlog;

namespace WebCore.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

        public MyContext(DbContextOptions<MyContext> options)
            :base(options)
        {

        }
    }
}
