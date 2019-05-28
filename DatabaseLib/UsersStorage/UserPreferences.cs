namespace DatabaseLib.UsersStorage
{
    public class UserPreferences : IUserPreferences
    {
        public string GetUserPreference(int userId)
        {
            switch(userId)
            {
                case 1:
                    return "Cars";
                case 2:
                    return "Fast Cars";
                case 3:
                    return "Netflix w domu";
                default:
                    return "Grzybiarstwo";
            }
        }
    }
}
