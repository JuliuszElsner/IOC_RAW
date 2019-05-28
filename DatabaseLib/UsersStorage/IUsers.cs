using System.Collections.Generic;

namespace DatabaseLib.UsersStorage
{
    public interface IUsers
    {
        List<User> GetAllUsers();
    }
}
