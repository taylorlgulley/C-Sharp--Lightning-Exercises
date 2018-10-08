using System;
using System.Collections.Generic;

namespace Library
{
    public class CardHolder
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        private List<Book> _currentBooks = new List<Book>();

        // A method to checkout a book and add it to the cardholders current books list
        public void CheckoutBook(Book book)
        {
            _currentBooks.Add(book);
        }
        // A method to return a book and remove it from the cardholders current books list
        public void ReturnBook(Book book)
        {
            _currentBooks.Remove(book);
        }
    }
}