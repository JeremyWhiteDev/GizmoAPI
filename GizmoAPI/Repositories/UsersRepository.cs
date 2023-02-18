using GizmoAPI.Models;

namespace GizmoAPI.Repositories;

public class UsersRepository : IUsersRepository
{
    private static List<User> _users = new List<User>()
    {
        new User() { Id = 1, Uid = "ABCDEFG", FirstName = "Jeremy", LastName = "White", Pronouns = "He/Him", Zipcode = 12345, ProfileImg = "google.com", UserCaption = "Wood Worker", Geocode = new { lat = 012345, lng = 012345 } },
          new User() { Id = 2, Uid = "HIJKL", FirstName = "Jane", LastName = "Smith", Pronouns = "She/her", Zipcode = 67890, ProfileImg = "bing.com", UserCaption = "Software Engineer", Geocode = new { lat = 67890, lng = 67890 } },
          new User() { Id = 3, Uid = "HIJKL", FirstName = "Jeremy", LastName = "Smith", Pronouns = "She/her", Zipcode = 67890, ProfileImg = "bing.com", UserCaption = "Software Engineer", Geocode = new { lat = 67890, lng = 67890 } }
    };



    public List<User> GetAll()
    {
        return _users;
    }

    public User GetUserById(int id)
    {
        return _users.Find(u => u.Id == id);
    }

    public List<User> GetUsersByFirstName(string firstName)
    {
        return _users.Where(u => u.FirstName == firstName).ToList();
    }

    public List<User> GetUsersByLastName(string lastName)
    {
        return _users.Where(u => u.LastName == lastName).ToList();
    }

    public User GetUserByUId(string uId)
    {
        return _users.Find(u => u.Uid == uId);
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void DeleteUser(int id)
    {
        var foundUser = GetUserById(id);
        _users.Remove(foundUser);
    }

    public void UpdateUser(User newUserObject)
    {
        var foundUser = GetUserById(newUserObject.Id);

        foundUser = newUserObject;
    }

    public bool IsEmpty()
    {
        return !_users.Any();
    }

}
