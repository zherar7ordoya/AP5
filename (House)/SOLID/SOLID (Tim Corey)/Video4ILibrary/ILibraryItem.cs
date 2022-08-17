namespace Video4ILibrary
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }

        /*
        string Author { get; set; }
        int Pages { get; set; }

        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; } 
        void CheckIn();
        void CheckOut();
        DateTime GetDueDate();
        */
    }

}
