using System;
using System.Collections.Generic;

// Make a Library class that has:
// - Private List of Books (remember casing and naming convention here)
// - Public Method to add a Book to the List of Books
// - Public Address property
// - Public Name property

namespace Library {
    public class Library {

        // Constructor of a Library with an initial inventory as a parameter so the library has a default list of books
        public Library(List<Book> initialInventory)
        {
            _bookList = initialInventory;
        } 

        public string Name { get; set; }

        public string Address { get; set; }

        // If you are not using a constructor to set the book list to something then you need to set it to somehthing like
        // Ex. private List<Book> _bookList = new List<Book>();
        private List<Book> _bookList;

        public void AddToInventory(Book book)
        {
            // this. is specifying everything to this instance but it is optional in C#  
            this._bookList.Add(book);
        }

        // A Checkout book method
        public void Checkout(string isbn, CardHolder cardholder)
        {
            foreach(Book book in _bookList)
            {
                // iterates over the list of books and checks if a books ISBN matches and if it is available
                if(book.ISBN == isbn && book.IsAvailable)
                {
                    // If both are true then add the book to the person's list of current books and change availability to false
                    cardholder.CheckoutBook(book);
                    book.IsAvailable = false;
                }
            }
        }

        // A CheckIn book method
        public void CheckIn(string isbn, CardHolder cardholder)
        {
            foreach(Book book in _bookList)
            {
                // iterates over the list of books and checks if a books ISBN matches and if it is unavailable
                if(book.ISBN == isbn && !book.IsAvailable)
                {
                    // If both are true then remove the book from the person's list of current books and change availability to true
                    cardholder.ReturnBook(book);
                    book.IsAvailable = true;
                }
            }
        }

        // A method to check the availability of a book and return a boolean value
        public bool IsAvailable(string isbn) 
        {
            foreach(Book book in _bookList)
            {
                if(book.ISBN == isbn)
                {
                    // If the ISBN match then you return the availability value
                    return book.IsAvailable;
                }
            }
            // If the book doesn't exist then it will return false because it will be unavailable
            return false;
        }
    }
}