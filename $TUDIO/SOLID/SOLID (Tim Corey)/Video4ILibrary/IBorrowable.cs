using System;

namespace Video4ILibrary
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        void CheckIn();
        void CheckOut();
        DateTime GetDueDate();
    }
}
