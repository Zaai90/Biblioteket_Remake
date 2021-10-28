using System.Collections.Generic;

namespace Biblioteket_Remake
{
    internal interface IDataManager
    {
        bool Save(List<Book> list);
        List<Book> Load();
    }
}