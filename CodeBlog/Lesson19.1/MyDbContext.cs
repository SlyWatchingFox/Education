using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19._1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConectionString")
        {

        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
