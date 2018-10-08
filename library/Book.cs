using System;
using System.Collections.Generic;

// Make a Book class that has
// - Title property
// - Author property
// - ISBN (this will be a string) property

namespace Library {
    public class Book 
    {
        //constructor so that the book has the availabilty defaulted to true when created
        public Book()
        {
            IsAvailable = true;
        }
        public string Title { get; set; }

        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }

    }
}