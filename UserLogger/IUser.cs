namespace UserLogger;

public interface IUser
{
    /// <summary>The First Name of the User.</summary>
    string FirstName { get; set; }
    
    /// <summary>The Last Name of the User.</summary>
    string LastName { get; set; }
    
    /// <summary>The UserName of the User.</summary>
    string UserName { get; }
    
    /// <summary>The Id of the User.</summary>
    Guid Id { get; }

    /// <summary>Get the human readable version of this User (typically the full name).</summary>
    /// <returns>The User as a string value.</returns>
    string ToString();
    
    /// <summary>Find the index of a User within a given list of Users.</summary>
    /// <param name="users">A list of Users.</param>
    /// <param name="user">The User to find.</param>
    /// <returns>The index of the User, -1 if not found.</returns>
    static int FindUser(List<IUser> users, IUser user)
    {
        if (!Contains(users, user)) 
            return -1;
        
        for (var i = 0; i < users.Count; i++)
        {
            if (users[i].Id == user.Id)
                return i;
        }

        return -1;

    }
    
    /// <summary>Find a User within a given list of Users</summary>
    /// <param name="users">A list of Users.</param>
    /// <param name="id">The id of a User</param>
    /// <returns>User if found, null if no User exists in list.</returns>
    static IUser FindUser(IEnumerable<IUser> users, Guid id)
    {
        foreach (var user in users)
        {
            if (user.Id == id)
                return user;
        }

        return null;
    }
    
    static bool Contains(IEnumerable<IUser> users, IUser user)
    {
        return users.Contains(user);
    }
}