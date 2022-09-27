namespace SolidDemo.LspViolated;

public class Employee
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public Employee Manager { get; set; } = null;
  public decimal Salary { get; set; }

  public virtual void AssignManager(Employee manager)
  {
    this.Manager = Manager;
  }

  public virtual void CalculatePerHourRate(int rank)
  {
    decimal baseAmount = 12.50m;

    this.Salary = baseAmount + (rank * 2);
  }
}

public class Manager : Employee{
  public override void CalculatePerHourRate(int rank)
  {
    decimal baseAmount = 19.75m;

    this.Salary = baseAmount + (rank * 4);
  }

  public void GeneratePerformanceReview(){
    System.Console.WriteLine("bla bla yada yada pretty good keep up the good work mate");
  }
}

public class CEO : Employee {
  public override void CalculatePerHourRate(int rank)
  {
    decimal baseAmount = 120m;

    this.Salary = baseAmount * rank;
  }

  public override void AssignManager(Employee manager)
  {
    throw new InvalidOperationException("CEO has no manager.");
  }

  public void GeneratePerformanceReview(){
    System.Console.WriteLine("hehe not bad");
  }

  public void Sack(Employee employee){
    System.Console.WriteLine($"{employee.FirstName} {employee.LastName}, you are fired!");
  }
}