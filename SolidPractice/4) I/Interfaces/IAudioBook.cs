using SolidDemo.IspViolated;

namespace SolidDemo.IspComplied;

public interface IAudioBook : ILibraryItem {
  int RuntimeInMinutes {get;set;}
}