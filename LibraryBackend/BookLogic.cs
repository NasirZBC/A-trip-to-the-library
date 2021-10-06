using A_trip_to_the_library.Storage;
using System.Collections.Generic;

namespace A_trip_to_the_library.LibraryBackend
{
    internal class BookLogic
    {
        private BookStorage bookStorage = new BookStorage();
        public Stack<Book> userBooks = new Stack<Book>();
        public List<bool> wantedBooks = new List<bool>();

        public List<string> currentLibraryBooks = new List<string>();
        public List<string> currentUserBooks = new List<string>();

        //List books that the library has currently available.
        public List<string> showLibraryBooks()
        {
            for (int i = 0; i < 3; i++)
            {
                Book topOfStack = bookStorage.libraryBooks.Pop();
                currentLibraryBooks.Add(topOfStack.Title);
            }
            bookStorage.libraryBooks.Push(bookStorage.book1);
            bookStorage.libraryBooks.Push(bookStorage.book2);
            bookStorage.libraryBooks.Push(bookStorage.book3);
            return currentLibraryBooks;
        }

        public void acceptBook()
        {
            wantedBooks.Add(true);
        }

        public void declineBook()
        {
            wantedBooks.Add(false);
        }

        public List<string> BookCheckOut()
        {
            Book currentUserBook;
            //Run through wantedBooks and return a list of strings with the wanted books.
            foreach (bool item in wantedBooks)
            {
                if (item == true)
                {
                    Book removedBook;
                    removedBook = bookStorage.libraryBooks.Pop();
                    userBooks.Push(removedBook);
                    currentUserBook = userBooks.Peek();
                    currentUserBooks.Add(currentUserBook.Title);
                }
                else
                {
                    bookStorage.libraryBooks.Peek();
                    bookStorage.libraryBooks.Pop();
                }
            }
            return currentUserBooks;
        }
    }
}