namespace SolidDemo.OcpComplied;

public class Accounts : IAccounts
{
  public EmployeeModel Create(IApplicantModel person) => new()
  {
    FirstName = person.FirstName,
    LastName = person.LastName,
    Email = $"{person.FirstName.Substring(0, 1).ToLower()}_{person.LastName.ToLower()}@suka.org"
  };
}