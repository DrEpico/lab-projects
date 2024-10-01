

Console.WriteLine("Book List LINQ\n");

var books = new List<Book>
{
    new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277, "Little Brown and Company", 1951, "Fiction", true),
    new Book(2, "War and Peace", "Leo Tolstoy", 1225, "The Russian Messenger (serial)", 1869, "Historical Fiction", true),
    new Book(3, "1984", "George Orwell", 328, "Secker & Warburg", 1949, "Dystopian", true)
};

Book.DisplayBookList(books);



