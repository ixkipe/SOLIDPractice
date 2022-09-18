namespace SolidDemo.OcpViolated;

public class PersonModel {
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
}

public class EmployeeModel {
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Email { get; set; }
  
  // imagine your boss comes in and says "we need to make a change, some of the newer employees are going to be managers"
  // so you add this property AFTER both models and the Accounts class have been created
  // this kinda violates OCP, but throughout the development phase nobody cares tbh
  // once the project is in the wild though, THEN it's time to be concerned about OCP
  public bool IsManager { get; set; } = false;

  // then your boss approaches you and says "we need another type, this time it's executive"
  public bool IsExecutive { get; set; } = false;
}

public class Accounts {
  public EmployeeModel Create(PersonModel person) => new(){
    FirstName = person.FirstName,
    LastName = person.LastName,
    Email = $"{person.FirstName.Substring(0, 1).ToLower()}_{person.LastName.ToLower()}@suka.org",

    // I added this line after receiving instructions from the boss
    // and thus violated OCP
    IsManager = person.TypeOfEmployee == EmployeeType.Manager? true : false,

    // I modified this method once again having received instructions
    // but it is risky to do because you may always forget to do something else so that the program functions as expected
    // simply put, the general rule of thumb of OCP is "if it ain't broke, don't fix it"
    IsExecutive = person.TypeOfEmployee == EmployeeType.Executive? true : false
  };
}

public class Launcher {
  List<PersonModel> people = new() {
    new() {FirstName = "Vitska", LastName = "Pidar"},
    new() {FirstName = "Yleks", LastName = "Syka"},
    new() {FirstName = "Mikl", LastName = "Blya"},
    new() {FirstName = "Anthony", LastName = "Hopkins"}
  };

  List<EmployeeModel> employees = new();
  Accounts accountsProcessor = new();

  public void Launch(){
    foreach (var person in people){
      employees.Add(accountsProcessor.Create(person));
    }

    foreach (var e in employees){
      System.Console.WriteLine($"{e.FirstName} {e.LastName}: {e.Email}");
    }
  }
}

public enum EmployeeType {
  Staff,
  Manager,
  Executive
}

