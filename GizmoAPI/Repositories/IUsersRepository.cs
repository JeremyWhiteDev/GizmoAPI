using GizmoAPI.Models;

namespace GizmoAPI.Repositories
{
    public interface IUsersRepository
    {
        void AddUser(User user);
        void DeleteUser(int id);
        List<User> GetAll();
        User GetUserById(int id);
        User GetUserByUId(string uId);
        List<User> GetUsersByFirstName(string firstName);
        List<User> GetUsersByLastName(string lastName);
        bool IsEmpty();
        void UpdateUser(User newUserObject);
    }
}