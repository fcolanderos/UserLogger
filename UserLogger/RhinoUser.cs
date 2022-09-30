using Rhino;


namespace UserLogger;

public class RhinoUser : IUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string UserName => RhinoApp.LoggedInUserName;

    public string RhinoVersion => RhinoApp.Version.ToString();

    public Guid Id { get; }
    
    #region Constructors

    /// <summary>A representation of a User to log data from Rhino.</summary>
    /// <param name="user">Another User to create the same user as a RhinoUser.</param>
    public RhinoUser(IUser user)
    {
        FirstName = user.FirstName;
        LastName = user.LastName;
        Id = user.Id;
    }
    
    /// <summary>A representation of a User to log data from Rhino.</summary>
    /// <param name="firstName">First name.</param>
    /// <param name="lastName">Last name.</param>
    /// <param name="id">Id.</param>
    public RhinoUser(string firstName, string lastName,  Guid id)
        : this(firstName, lastName)
    {
        Id = id;
    }
    
    /// <summary>A representation of a User to log data from Rhino.</summary>
    /// <param name="firstName">First name.</param>
    /// <param name="lastName">Last name.</param>
    public RhinoUser(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        Id = new Guid();
    }
    #endregion

    public override string ToString()
    {
        return string.Join(" ", FirstName, LastName);
    }
}