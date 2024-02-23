using Hitachi_DotNet_Practical_Assignment.DAL.Models.Domains;
using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;
using Hitachi_DotNet_Practical_Assignment.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitachi_DotNet_Practical_Assignment.BL.BusinessLogic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }

        public string SignUp(SignUpDTO user)
        {
            var newUser = new User()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PasswordHash = user.Password
            };
           
            var result = userRepository.SignUp(newUser);
            
            return result;
        }

        public string SignIn(SignInDTO user)
        {
            var signInuser = new SignInUser()
            {
                Email = user.Email,
                PasswordHash = user.Password
            };

            UserRepository repo = new UserRepository();

            var result = repo.SignIn(signInuser);
            return result;
        }
    }
}
