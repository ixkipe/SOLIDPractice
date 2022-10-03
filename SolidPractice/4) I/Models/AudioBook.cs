using SolidDemo.IspComplied;

namespace SolidDemo.IspViolated;

public class AudioBook : IBorrowableAudioBook
{
  public string LibraryId { get; set; }
  public string Title { get; set; }
  public DateTime BorrowDate {get; set;}
  public string Borrower {get; set;}
  public int CheckoutDurationInDays {get; set;} = 14;
  public int RuntimeInMinutes { get; set; }

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