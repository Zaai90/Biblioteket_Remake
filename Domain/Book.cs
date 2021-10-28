using System;

namespace Biblioteket_Remake
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }
        public BookCategory Category { get; set; }

        public Book()
        {
            // Constructor for Json
        }

        public Book(string _title, string _author, int _year, BookCategory _category)
        {
            Title = _title;
            Author = _author;
            PublicationYear = new DateTime(_year, 1, 1);
            Category = _category;

        }

        public override string ToString()
        {
            return $"{Category}".PadRight(17) + $"{Title}".PadRight(25) + $"{Author}".PadRight(25) + $"{PublicationYear.Year.ToString()}";
        }

    }
    public enum BookCategory
    {
        Novel = 0,
        Audiobook = 1,
        Magazine = 2
    }
}