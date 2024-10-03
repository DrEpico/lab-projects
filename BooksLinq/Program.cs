﻿

using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;

Console.WriteLine("Book List LINQ\n");

var books = new List<Book>
{
    new Book(1, "The Catcher in the Rye", "J.D. Salinger", 277, "Little Brown and Company", 1951, "Fiction", true),
    new Book(2, "War and Peace", "Leo Tolstoy", 1225, "The Russian Messenger (serial)", 1869, "Historical Fiction", true),
    new Book(3, "1984", "George Orwell", 328, "Secker & Warburg", 1949, "Dystopian", true)
};

books.AddRange(new List<Book>
{
new Book(4, "The Hobbit", "J.R.R. Tolkien", 310,
"George Allen & Unwin", 1937, "Fantasy", true),
new Book(5, "Tender Is the Night", "F. Scott Fitzgerald", 317,
"Charles Scribner", 1934, "Fiction", true),
new Book(6, "The Great Gatsby", "F. Scott Fitzgerald", 180,
"Charles Scribner", 1925, "Fiction", true),
new Book(7, "To Kill a Mockingbird", "Harper Lee", 336,
"J.B. Lippincott & Co.", 1960, "Fiction", true),
new Book(8, "The Alchemist", "Paulo Coelho", 208,
"HarperTorch", 1988, "Adventure", true),
new Book(9, "Brave New World", "Aldous Huxley", 268,
"Chatto & Windus", 1932, "Dystopian", true),
new Book(10, "Moby-Dick", "Herman Melville", 635,
"Harper & Brothers", 1851, "Adventure", true),
new Book(11, "Pride and Prejudice", "Jane Austen", 279,
"T. Egerton, Whitehall", 1813, "Romance", true),
new Book(12, "The Lord of the Rings", "J.R.R. Tolkien", 1178,
"George Allen & Unwin", 1954, "Fantasy", true),
new Book(13, "Becoming", "Michelle Obama", 448,
"Crown", 2018, "Autobiography", false),
new Book(14, "Sapiens: A Brief History of Humankind", "Yuval Harari", 443,
"Harper", 2011, "Non-Fiction", false),
new Book(15, "Educated", "Tara Westover", 334,
"Random House", 2018, "Autobiography", false),
new Book(17, "Thinking, Fast and Slow", "Daniel Kahneman", 499,
"Farrar, Straus and Giroux", 2011, "Non-Fiction", false),
new Book(18, "The Body Keeps the Score", "Bessel van der Kolk", 464,
"Viking", 2014, "Non-Fiction", false)
}
);

Book.DisplayBookList(books);

Console.WriteLine("\nTolkein Books");
var TolkeinBooks = books
    .Where(b => b.Author == "J.R.R. Tolkien")
    .ToList();
Book.DisplayBookList(TolkeinBooks);

Console.WriteLine("\nTolkien Or Coelho Books");
var tolkienOrCoelhoBooks = books
    .Where(b => b.Author == "J.R.R. Tolkien" || b.Author == "Paulo Coelho")
    .ToList();
Book.DisplayBookList(tolkienOrCoelhoBooks);

Console.WriteLine("\nBooks with IS in the title");
var isBooks = books
    .Where(b => b.Title.Contains("is", StringComparison.CurrentCultureIgnoreCase))
    .ToList();
Book.DisplayBookList(isBooks);

Console.WriteLine("\nBooks with a page count between 450 and 1000 (invlusive)");
var mediumSizeBooks = books
    .Where(b => b.PageCount >= 450 && b.PageCount <= 1000)
    .ToList();
Book.DisplayBookList(mediumSizeBooks);

Console.WriteLine("\nBooks in the Autobiography and Romance Genre");
var genrefilteredList = new List<string> { "Autobiography", "Romance" };
var GenreFilteredBooks = books
    .Where(b => genrefilteredList.Contains(b.Genre))
    .ToList();
Book.DisplayBookList(GenreFilteredBooks);

Console.WriteLine("\nBooks sorted by Genre");
var booksSortedByGenre = books
    .OrderBy(b => b.Genre)
    .ToList();
Book.DisplayBookList(booksSortedByGenre);

Console.WriteLine("\nBooks sorted by Genre and Title");
var booksSortedByGenreAndTitle = books
    .OrderBy(b => b.Genre)
    .ThenBy(b => b.Title)
    .ToList();
Book.DisplayBookList(booksSortedByGenreAndTitle);

Console.WriteLine("\nBooks sorted by Year Published (latest first) and Title");
var booksSortedByGenreAndYear = books
    .OrderByDescending(b => b.PublishedYear)
    .ThenBy(b => b.Title)
    .ToList();
Book.DisplayBookList(booksSortedByGenreAndYear);

Console.WriteLine("\nOldest and newest book - Year Published");
var oldestBookYear = books
    .Select(b => b.PublishedYear) //extract years
    .Min(); //then find min
Console.WriteLine($"Oldest Year Published: {oldestBookYear}");
var newestBookYear = books
    .Max(b => b.PublishedYear); //extract year as part of Max
Console.WriteLine($"Most Recent Year Published: {newestBookYear}");

Console.WriteLine("\nJ.R.R Tolkien first book");
var tolkienFirstBook = books
    .Where(b => b.Author == "J.R.R Tolkien")
    .OrderBy(b => b.PublishedYear)
    .FirstOrDefault(); //get first book from list
Console.WriteLine(tolkienFirstBook);

Console.WriteLine("\nBook Count for each genre");
var genreCounts = books
    .GroupBy(b => b.Genre) //Create a shortcut of records for each genre
    .OrderBy(g => g.Key) //optional: sort by genre [key]
    .Select(g => new { //Create an anonymous class with: 
        Genre = g.Key, // - Genre [the group key]
        Count = g.Count() // - A count of the subset of Genre records
    }).ToList();

foreach (var gc in genreCounts)
{
    Console.WriteLine($"{gc.Genre} : {gc.Count}");
}

Console.WriteLine("\nBooks that are classic and have more than 300 pages");
var classicAndMoreThan300Pages = books
    .Where(b => b.PageCount > 300 && b.IsClassic)
    .ToList();
Book.DisplayBookList(classicAndMoreThan300Pages);





