using Hitachi_DotNet_Practical_Assignment.DAL.Models.Domains;

namespace Hitachi_DotNet_Practical_Assignment.DAL.Repositories
{
    public interface IUserRepository
    {
        string SignIn(SignInUser signInuser);
        string SignUp(User newUser);
    }
}