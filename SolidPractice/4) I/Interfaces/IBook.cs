using SolidDemo.IspViolated;

namespace SolidDemo.IspComplied;

public interface IBook : ILibraryItem{
  public string Author { get; set; }
  public int Pages { get; set; }
}