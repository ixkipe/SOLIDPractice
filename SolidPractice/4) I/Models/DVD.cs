using SolidDemo.IspComplied;

namespace SolidDemo.IspViolated;

public class DVD : IBorrowableDVD
{
  public string LibraryId {get;set;}
  public string Title {get;set;}
  public int RuntimeInMinutes { get; set; }
  public List<string> Actors { get; set; }
  public DateTime BorrowDate {get;set;}
  public string Borrower {get;set;}
  public int CheckoutDurationInDays {get;set;}

  public void CheckIn()
  {
    Borrower = string.Empty;
  }

  public void CheckOut(string borrower)
  {
    Borrower = borrower;
    BorrowDate = DateTime.Now;
  }

  public DateTime GetDueDate()
  {
    return BorrowDate.AddDays(CheckoutDurationInDays);
  }
}