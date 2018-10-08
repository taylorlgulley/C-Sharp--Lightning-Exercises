using System;
using System.Collections.Generic;

//Create a few (4 or so) instances of books and use the method on your Library class to add them to the list of books in an instance of Library

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Books
            Book book1 = new Book()
            {
                Title = "Game of Thrones",
                Author = "George R.R. Martin",
                ISBN = "111A"
            };
            Book book2 = new Book()
            {
                Title = "Casino Royale",
                Author = "Ian Fleming",
                ISBN = "111B"
            };
            Book book3 = new Book()
            {
                Title = "Lord of the Rings",
                Author = "J.R.R. Tolkien",
                ISBN = "111C"
            };
            Book book4 = new Book()
            {
                Title = "Count of Monte Cristo",
                Author = "Alexander Dumas",
                ISBN = "111D"
            };
            // Make two books for the initial inventory
            Book bookA = new Book()
            {
                Title = "BookA",
                Author = "AuthorA",
                ISBN = "A"
            };
            Book bookB = new Book()
            {
                Title = "BookB",
                Author = "AuthorB",
                ISBN = "B"
            };
            // make an initial inventory
            List<Book> initialInventory = new List<Book>();
            initialInventory.Add(bookA);
            initialInventory.Add(bookB);

            // Create the library and give it the initial Inventory
            Library library1 = new Library(initialInventory)
            {
                Name = "Gulley's Library",
                Address = "here"
            };

            // Add the books to the Library Inventory
            library1.AddToInventory(book1);
            library1.AddToInventory(book2);
            library1.AddToInventory(book3);
            library1.AddToInventory(book4);

            // create a Card Holder
            CardHolder tg = new CardHolder()
            {
                FullName = "Taylor Gulley",
                Id = 1234
            };
            //Check if a book is available
            if(library1.IsAvailable("111D"))
            {
                Console.WriteLine("This book is available");
            } else 
            {
                Console.WriteLine("This book is not available");
            }
            // Checkout a book
            library1.Checkout("111D", tg);
            //Return the book
            library1.CheckIn("111D", tg);

            Console.WriteLine("Hello World!");
        }
    }
}
