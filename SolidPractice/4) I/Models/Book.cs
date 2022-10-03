using SolidDemo.IspComplied;

namespace SolidDemo.IspViolated;

public class Book : IBorrowableBook
{
  public string Author {get; set;}
  public DateTime BorrowDate {get; set;}
  public string Borrower {get; set;}
  public int CheckoutDurationInDays {get; set;} = 14;
  public string LibraryId {get; set;}
  public int Pages {get; set;}
  public string Title {get; set;}

  public void CheckIn()
  {
    Borrower = String.Empty;
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