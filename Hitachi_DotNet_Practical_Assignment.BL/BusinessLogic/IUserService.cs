using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;

namespace Hitachi_DotNet_Practical_Assignment.BL.BusinessLogic
{
    public interface IUserService
    {
        string SignIn(SignInDTO user);
        string SignUp(SignUpDTO user);
    }
}