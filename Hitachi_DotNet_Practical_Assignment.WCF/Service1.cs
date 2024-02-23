using Hitachi_DotNet_Practical_Assignment.BL.BusinessLogic;
using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Hitachi_DotNet_Practical_Assignment.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private readonly UserService userService;

        public Service1() {
            userService = new UserService();
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string SignUp(SignUpDTO newUser)
        {
            var result = userService.SignUp(newUser);

            return result;
        }
        public string SignIn(SignInDTO user)
        {
            var result= userService.SignIn(user);

            return result;
        }


    }
}
