using Model;

namespace assignment.Data
{
    public interface IUserService
    {
         User ValidateUser(string userName, string Password);
    }
}