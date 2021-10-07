using System;
using System.Collections.Generic;

namespace liwy
{
    public class Book
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title { get; set; }

        public string Edition { get; set; }

        public int YearPublished { get; set; }

        public string Category { get; set; }

        public string Publisher { get; set; }

        public string Barcode { get; set; }

        public string ISBN { get; set; }

        public string Location { get; set; }

        //add new property for Authors
        public List<string> Authors { get; set; }

        //add new property Status using enum BookStatus
        public BookStatus BookStatus { get; set; }
        
        //generate a Book contructor
    }
    
    //create a BookStatus enum here
    public enum BookStatus
    {
        Resered,
        InLoan,
        Available
    }
}