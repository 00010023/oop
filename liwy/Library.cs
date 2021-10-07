using System;
using System.Collections.Generic;

namespace liwy
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public List<User> Users { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<Loan> Loans { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Users = new List<User>();
            Reservations = new List<Reservation>();
            Loans = new List<Loan>();
        }       
    }
}