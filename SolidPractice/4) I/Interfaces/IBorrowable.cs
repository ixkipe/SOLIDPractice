using SolidDemo.IspViolated;

namespace SolidDemo.IspComplied;

public interface IBorrowable {
  public DateTime BorrowDate { get; set; }
  public string Borrower { get; set; }
  public int CheckoutDurationInDays { get; set; }

  public void CheckIn();
  public void CheckOut(string borrower);
  public DateTime GetDueDate();
}