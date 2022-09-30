using UserLogger;

namespace LogTest;

public static class Program
{
    public static void Main()
    {
        var users = new List<IUser>();

        var user1 = new RevitUser("Francisco", "Landeros");
        var user2 = new RhinoUser("Vale", "Corona");
        var newUser = new RevitUser(user2);
        var other = new RhinoUser("user", "hi");
        
        users.Add(user1);
        users.Add(user2);
        users.Add(newUser);
        
        Log.LogUsers(users);
        Console.WriteLine(IUser.FindUser(users, other));
    }
}