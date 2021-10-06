namespace A_trip_to_the_library.LibraryBackend
{
    class Book
    {
        private string title;
        private string author;
        private string genre;

        public Book(string bookTitle, string bookAuthor, string bookGenre)
        {
            title = bookTitle;
            author = bookAuthor;
            genre = bookGenre;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
    }
}