namespace SampleNuGet;

/// <summary>
/// Customer Entity Class
/// </summary>
public class Customer
{
    /// <summary>
    /// Firstname of the customer
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Lastname of the customer
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// Method to get full name
    /// </summary>
    /// <returns>Returns Fullname</returns>
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    
}