using System;

namespace liwy
{
    public class Loan
    {
        public int ID { get; set; }

        public User Borrower { get; set; }

        public Book BorrowedBook { get; set; }

        public DateTime DateTaken { get; set; }

        public int Duration { get; set; }

        public bool IsReturned { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        public DateTime ExpectedReturnDate
        {
            get { return DateTaken.AddDays(Duration); }
        }
    }
}
