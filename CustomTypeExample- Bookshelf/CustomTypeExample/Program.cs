using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypeExample
{
    public class Book
    // Here is where you Custom type 'Book' to represent your individual books
    {

        //What are the properties of a book?
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public int BookPages {get; set;}

        //Setup a constructor?
        //What is a constructor?- A special method to initialize your object
        //What does that initialize mean? provide it with some default values
        public Book(string BookTitle, string BookAuthor, int BookPages)
        {
            //Why are we using "this"? 
            // If we do not use this then the class properties remain uninitilized with their default values.
            //Remind me to come back to this this lol
            this.BookTitle = BookTitle;
            this.BookAuthor = BookAuthor;
            this.BookPages = BookPages;

        }

        //Do you wnat to override the ToString method?
        //Remind me to come back to this
        public override string ToString()// overriding the default implementation
        {
            return $"{BookTitle} by {BookAuthor} ({BookPages} pages)";
        }

        //Create your custome type 'Bookshelf'
        //This will be used to manage a collection of books.

        public class Bookshelf
        {
            // How do we manage books?
            //Add, Remove, Display

            //Lets create a list to store the books- this is used to store the collection of objects inside the class
            //Why do we use private? Followign the principle of encapsulation
            private List<Book> books;

            // Constructor to create an empty bookshelf.
            public Bookshelf()
            {
                books = new List<Book>();// sometimes while typing you will notice the intellisence kick in
            }

            // Method to add to bookshelf
            //These methods will be sued to interact with the data. 
            public void Addbook(Book book)
            {
                books.Add(book);
            }
            //Method to remove book from bookshelf
            public void Removebook(Book book)
            {
                books.Remove(book);
            }

            //Method to Display all books on the bookshlef
            public void DisplayBooks()
            {
                Console.WriteLine("Here are your books on the Bookshelf");
                Console.WriteLine(" ");// you might want to use this to create some space
               
                foreach (var book in books)
                //var- this is a type inference keyword.
                //Allows you to declare your variables without specifing their data type explicitly

                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public class Program
        {
            public static void Main()
            {
                //Now we need some books... (Book objects)

                Book book1 = new Book("Othello", "D.S.Govender", 180);
                //Please do not ask me about this book or what happened there...

                //Copy and paste. Remember these are all mock information
                //Dont go look for them online
                Book book2 = new Book("Harry potter", "S.K.Govender", 120);
                Book book3 = new Book("I hate love stories", "P.Govender", 100);

                // Create a bookshelf object.
                Bookshelf myBookshelf = new Bookshelf();
               
                // Add books to the bookshelf.
                myBookshelf.Addbook(book1);
                myBookshelf.Addbook(book2);
                myBookshelf.Addbook(book3);

   
                // Display all the books on the bookshelf.
                myBookshelf.DisplayBooks();

                // Remove a book from the bookshelf.
                //myBookshelf.Removebook(book2);

                // Display the updated list of books on the bookshelf.
                //myBookshelf.DisplayBooks();
                Console.ReadKey();
            }
            //Revist "this"
            //Revist override String
            //Now I want you to remove the "this" or the overrride and examine the output
        }

    }
}
