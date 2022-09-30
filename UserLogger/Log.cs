namespace UserLogger;

public static class Log
{
    public static void LogUsers(IEnumerable<IUser> users)
    {
        foreach (var user in users)
        {
            LogUser(user);
        }
    }
    
    public static void LogUser(IUser user)
    {
        Console.WriteLine($"Sending data User data for {user.ToString()}. " +
                          $"which is of type {user.GetType()}");
    }
}