using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Biblioteket_Remake
{
    internal class SimpleSaver : IDataManager
    {
        private const string fileName = "LibraryBookList.json";

        public bool Save(List<Book> bookList)
        {
            string jsonString = JsonSerializer.Serialize<List<Book>>(bookList);
            File.WriteAllText(fileName, jsonString);

            return true;
        }

        public List<Book> Load()
        {
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Book>>(jsonString);
            }
            return new List<Book>();
        }
    }
}