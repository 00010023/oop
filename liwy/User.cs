using System;
using System.Collections.Generic;

namespace liwy
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PassportNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        // create a new list called BooksCurrentlyOnLoan
        public List<Book> BooksCurrentlyOnLoan { get; set; }
    }
}