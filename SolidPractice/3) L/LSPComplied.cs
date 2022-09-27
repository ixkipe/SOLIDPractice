namespace SolidDemo.LspComplied;

public class Employee : BaseEmployee, ISupervised
{
  public IEmployee manager { get; set; } = null;

  public void AssignManager(IEmployee manager)
  {
    throw new NotImplementedException();
  }

  public override void CalculatePerHourRate(int rank) => this.Salary = 12.50m + (rank * 2);
}

public class Manager : BaseEmployee, IManager, ISupervised
{
  public IEmployee manager { get; set; } = null;

  public void AssignManager(IEmployee manager)
  {
    this.manager = manager;
  }

  public override void CalculatePerHourRate(int rank) => this.Salary = 19.75m + (rank * 4);

  public void GeneratePerformanceReview()
  {
    System.Console.WriteLine("gut malchik gut!");
  }
}

public class CEO : BaseEmployee, IManager
{
  public override void CalculatePerHourRate(int rank) => this.Salary = 120 * rank;

  public void GeneratePerformanceReview()
  {
    System.Console.WriteLine("not half bad soldier keep it up!");
  }

  public void Sack(IEmployee employee){
    if (employee is not CEO)
      System.Console.WriteLine($"{employee.FirstName} {employee.LastName}, you are fired!");
    else
      System.Console.WriteLine("Cannot fire yourself!");
  }
}

public abstract class BaseEmployee : IEmployee
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public decimal Salary { get; set; }

  public abstract void CalculatePerHourRate(int rank);
}