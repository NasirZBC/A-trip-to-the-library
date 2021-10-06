using A_trip_to_the_library.LibraryBackend;
using System;
using System.Collections.Generic;
using System.Threading;

namespace A_trip_to_the_library
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Instance of BookLogic
            BookLogic bookLogic = new BookLogic();
            char userInput;

            Console.WriteLine("Welcome to the library");
            Console.WriteLine("Below you can see the books we have available");
            Console.WriteLine();
            Thread.Sleep(1000);
            //Write current library books that are received from the showLibraryBooks method.
            List<string> currentLibraryBooks = bookLogic.showLibraryBooks();
            foreach (string item in currentLibraryBooks)
            {
                Thread.Sleep(1000);
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("You can choose whether or not you want to borrow a book by pressing Y for yes or N for no.");
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Would you like to borrow The nothing of nothing?");
            userInput = Console.ReadKey().KeyChar;
            inputControl();
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Would you like to borrow The everything of everything");
            userInput = Console.ReadKey().KeyChar;
            inputControl();
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("Would you like to borrow The whatever of whatever?");
            userInput = Console.ReadKey().KeyChar;
            inputControl();

            //Validating the users input.
            void inputControl()
            {
                bool inputControlLoop = true;
                while (inputControlLoop)
                {
                    if (userInput.ToString() == "y")
                    {
                        //If the user wants the book
                        bookLogic.acceptBook();
                        inputControlLoop = false;
                    }
                    else if (userInput.ToString() == "n")
                    {
                        //If the user does not want the book.
                        bookLogic.declineBook();
                        inputControlLoop = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid, please try again with the given options (Y or N) Y being yes and N being no.");
                        userInput = Console.ReadKey().KeyChar;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Your borrowed books:");
            Console.WriteLine();

            //List used to write current user books that are received from the BookCheckOut method.
            List<string> currentUserBooks = bookLogic.BookCheckOut();
            foreach (string item in currentUserBooks)
            {
                Thread.Sleep(1000);
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Have a nice day and enjoy your books.");
        }
    }
}