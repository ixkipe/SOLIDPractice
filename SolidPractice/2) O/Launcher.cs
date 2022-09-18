namespace SolidDemo.OcpComplied;

public class Launcher {
  List<IApplicantModel> people = new() {
    new ExecutiveModel() {FirstName = "Vitska", LastName = "Pidar"},
    new ManagerModel() {FirstName = "Yleks", LastName = "Syka"},
    new PersonModel() {FirstName = "Mikl", LastName = "Blya"},
    new PersonModel() {FirstName = "Anthony", LastName = "Hopkins"}
  };

  List<EmployeeModel> employees = new();

  public void Launch(){
    foreach (var person in people){
      employees.Add(person.AccountProcessor.Create(person));
    }

    foreach (var e in employees){
      System.Console.WriteLine($"{e.FirstName} {e.LastName}: {e.Email}");
      System.Console.WriteLine(e.IsExecutive ? "Executive" : e.IsManager ? "Manager" : "Staff");
    }
  }
}