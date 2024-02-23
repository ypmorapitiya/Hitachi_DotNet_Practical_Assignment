using Hitachi_DotNet_Practical_Assignment.DAL.Models.Domains;
using Hitachi_DotNet_Practical_Assignment.DAL.UserDBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Hitachi_DotNet_Practical_Assignment.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbContext;

        public UserRepository()
        {
            dbContext = new UserDbContext();
        }

        public string SignUp(User newUser)
        {
            var user= dbContext.Users.Where(e=>e.Email==newUser.Email).FirstOrDefault();
            if (user!=null)
            {
                return "User with same email already exist"; 
            }
            try
            {
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                return "registration success";
            }
            catch (Exception ex)
            {
                return "registration fail";
            }

        }

        public string SignIn(SignInUser signInuser)
        {
           
            
                var userfound = dbContext.Users.Where(x => x.Email == signInuser.Email &&
                                                    x.PasswordHash == signInuser.PasswordHash).FirstOrDefault();
                if (userfound != null)
                {
                    return "WelCome " + userfound.FirstName + " " + userfound.LastName;

                }
                else
                {
                    return "invalid credintials";
                }
            


        }
    }
}