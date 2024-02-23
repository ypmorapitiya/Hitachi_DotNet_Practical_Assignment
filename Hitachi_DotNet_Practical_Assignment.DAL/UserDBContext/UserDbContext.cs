using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitachi_DotNet_Practical_Assignment.DAL.UserDBContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext():base("UserDbContext")
        {
            
        }
        public DbSet<Models.Domains.User>Users { get; set; }
    }
}
