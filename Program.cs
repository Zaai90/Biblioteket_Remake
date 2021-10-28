using System;

namespace Biblioteket_Remake
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Make a Menu!
            SimpleSaver dataManager = new();
            Library library = new(dataManager);

            foreach (var item in library.SearchBooks("en"))
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
