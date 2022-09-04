using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ILibrary
    {
        public abstract List<Book> FindAllBooksByName(string name);
        public abstract void RemoveAllBooksByName(string name);
        public abstract List<Book> SearchBooks(string val);
        public abstract List<Book> FindAllBooksByPageCountRange(int a, int b);
        public abstract void RemoveBookByCode(string code);
    }
}
