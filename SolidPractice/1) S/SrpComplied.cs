using System.Diagnostics.CodeAnalysis;

namespace SolidDemo.SrpComplied;

// a class should have only ONE responsibility and, consequently, only ONE reason to change

// here we have multiple classes, all for specific purposes 
// (albeit in a single file, which is not recommended; one-class-per-file is how it is normally done)

// notice how every time you need to change the way something is done, here you navigate to the respective class
// want to change name validation methods? you go to the PersonValidator class
// feel like changing welcome and shutdown messages? proceed to the AppMessages class

// the point is, SRP makes it easier to get around your program and understand what is going on

// ALSO, when an app is bigger than this one, you should maintain a coherent folder structure 
// so as not to get confused about where to go
public class Person {
  public string FirstName { get; set; }
  public string LastName { get; set; }
}

public class PersonDataCapture {
  public static Person Capture(){
    string name = null;

    while (!PersonValidator.IsValidName(name)){
      Console.Clear();
      System.Console.Write("Enter your name: ");
      name = Console.ReadLine();
    }

    string surname = null;

    while (!PersonValidator.IsValidName(surname)){
      Console.Clear();
      System.Console.Write("Enter your surname: ");
      surname = Console.ReadLine();
    }

    return new() {FirstName = name, LastName = surname};
  }
}

public class AppMessages {
  public static void Welcome(){
    System.Console.WriteLine("Welcome!");
    Thread.Sleep(1500);
  }

  public static void End(){
    System.Console.WriteLine("Closing application...");
    Console.ReadLine();
  }

  public static void DisplayFullName(Person person){
    System.Console.WriteLine($"Your name is: {person.FirstName} {person.LastName}");
  }
}

public class PersonValidator {
  public static bool IsValidName(string name) => !String.IsNullOrEmpty(name) && !String.IsNullOrWhiteSpace(name);
}

public class AppManager {
  public static void RunApp(Person person) {
    AppMessages.Welcome();
    AppMessages.DisplayFullName(person);
    AppMessages.End();
  }
}