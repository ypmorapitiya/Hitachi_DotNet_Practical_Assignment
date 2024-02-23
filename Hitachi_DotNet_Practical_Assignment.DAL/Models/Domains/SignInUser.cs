using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hitachi_DotNet_Practical_Assignment.DAL.Models.Domains
{
    public class SignInUser
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
