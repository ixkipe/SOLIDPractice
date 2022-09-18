namespace SolidDemo.OcpComplied;

// Ctrl + .
// Extract interface
public class PersonModel : IApplicantModel
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public IAccounts AccountProcessor { get; set; } = new Accounts();
}