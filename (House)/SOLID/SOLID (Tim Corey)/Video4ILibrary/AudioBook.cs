using System;

namespace Video4ILibrary
{
    public class AudioBook : IBorrowableAudiobook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; } = -1;
        public int CheckOutDurationInDays { get; set; }
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; }
        public int RuntimeInMinutes { get; set; }
        



        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }

}
