namespace SolidDemo.SrpViolated;

public class Person {
  public static void CaptureAndDisplayPersonName(){
    string name = null, surname = null;
    
    System.Console.WriteLine("Welcome!");

    while (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)){
      Console.Clear();
      System.Console.Write("Enter your name: ");
      name = Console.ReadLine();
    }

    while (string.IsNullOrEmpty(surname) || string.IsNullOrWhiteSpace(surname)){
      Console.Clear();
      System.Console.Write("Enter your surname: ");
      surname = Console.ReadLine();
    }

    System.Console.WriteLine($"Your name is: {name} {surname}");
    Console.ReadLine();
  }
}