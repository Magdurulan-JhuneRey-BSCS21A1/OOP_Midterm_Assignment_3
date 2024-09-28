namespace ClassLibrary1
{
    public class Library
    {
        private List<Book> _listOfBooks = new List<Book>();

        public void AddBook(Book book)
        {
            _listOfBooks.Add(book);
        }
        public Book[] GetBooks() {
            return _listOfBooks.ToArray(); 
        }

        public void RemoveBook(Book book) 
        {
            _listOfBooks.Remove(book);  
        }
        public Book SearchBook(string title)
        {
            var foundBooks = _listOfBooks.Where(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
            return foundBooks.FirstOrDefault();
        }

    }
}
