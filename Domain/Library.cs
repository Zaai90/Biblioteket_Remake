using System;
using System.Collections.Generic;

namespace Biblioteket_Remake
{
    internal class Library
    {
        private List<Book> books = new();
        private IDataManager dataManager;

        public Library(IDataManager dataManager)
        {
            this.dataManager = dataManager;
            LoadBooks();
        }

        public void AddBook(Book newBook)
        {
            books.Add(newBook);
            SaveChanges();
        }

        public void LoadBooks()
        {
            books.AddRange(dataManager.Load());
        }

        private void SaveChanges()
        {
            dataManager.Save(books);
        }

        internal List<Book> SearchBooks(string searchWord)
        {
            return books.FindAll(b => b.ToString().Contains(searchWord, StringComparison.OrdinalIgnoreCase));
        }

        internal IList<Book> GetAllBooks()
        {
            return books.AsReadOnly();
        }
    }
}