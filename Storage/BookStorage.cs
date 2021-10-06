using A_trip_to_the_library.LibraryBackend;
using System.Collections.Generic;

namespace A_trip_to_the_library.Storage
{
    class BookStorage
    {
        public Stack<Book> libraryBooks = new Stack<Book>();

        public Book book1 = new Book("The whatever of whatever", "JJ", "Action");
        public Book book2 = new Book("The everything of everything", "MS", "Adventure");
        public Book book3 = new Book("The nothing of nothing", "EJ", "Drama");

        public BookStorage()
        {
            libraryBooks.Push(book1);
            libraryBooks.Push(book2);
            libraryBooks.Push(book3);
        }
    }
}