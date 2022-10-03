namespace SolidDemo.IspViolated;

public interface ILibraryItem {
  public string LibraryId { get; set; }
  public string Title { get; set; }
  //public DateTime BorrowDate { get; set; }
  //public string Borrower { get; set; }
  //public int CheckoutDurationInDays { get; set; }
  //public string Author { get; set; }
  //public int Pages { get; set; }

  // void CheckIn();
  // void CheckOut(string borrower);
  // DateTime GetDueDate();

  //all of the commented-out properties above had been included in the interface, making some of the library items (e.g. digital ones) implement them
  //this violated ISP, and this big interface had to be cut into smaller ones
}