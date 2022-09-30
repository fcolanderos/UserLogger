namespace UserLogger;

public class RevitUser : IUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; } // TODO: Implement getting Username from Revit
    public Guid Id { get; }

    #region Constructors

    public RevitUser(IUser user)
    {
        FirstName = user.FirstName;
        LastName = user.LastName;
        Id = user.Id;
    }

    public RevitUser(string firstName, string lastName, Guid id)
        : this(firstName, lastName)
    {
        Id = id;
    }
    
    public RevitUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Id = new Guid();
    }

    public override string ToString()
    {
        return string.Join(" ", FirstName, LastName);
    }

    #endregion
}