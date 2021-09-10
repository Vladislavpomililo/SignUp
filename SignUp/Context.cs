using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SignUp
{
    class Context : DbContext
    {
        public DbSet<User> Users {get; set; }

        public Context() : base("DefaultConnection") { }
    }
}
