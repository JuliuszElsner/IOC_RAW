using System.Collections.Generic;

namespace DatabaseLib.UsersStorage
{
    public class Users : IUsers
    {
        public List<User> GetAllUsers()
        {
            return new List<User> { new User { Id = 3, Name = "Andrzej", Height = 183 }, new User { Name = "Zbysio", Height = 167 } };
        }
    }
}
