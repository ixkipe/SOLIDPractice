using SolidDemo.LspComplied;

public class LSPLauncher {
  public void Launch(){
    var ceo = new CEO(){
      FirstName = "Robert",
      LastName = "Curry"
    };
    IEmployee worker = new Employee(){
      FirstName = "Jill",
      LastName = "Papa"
    };

    ceo.Sack(ceo);
    ceo.Sack(worker);
  }
}