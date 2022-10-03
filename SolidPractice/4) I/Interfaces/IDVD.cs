using SolidDemo.IspViolated;

namespace SolidDemo.IspComplied;

public interface IDVD : ILibraryItem{
  public int RuntimeInMinutes { get; set; }
  public List<string> Actors { get; set; }
}