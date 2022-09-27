namespace SolidDemo.LspComplied;

public interface ISupervised {
  public IEmployee manager { get; set; }
  
  public void AssignManager(IEmployee manager);
}