using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class Library : ILibrary
    {
        public List<Book> books = new List<Book>();
        public Library(List<Book> _books)
        {
            books = _books;
        }
        public List<Book> FindAllBooksByName(string name)
        {
            return books.FindAll(x => x.Name == name);
        }
        public void RemoveAllBooksByName(string name)
        {
            books.Remove(books.Find(x => x.Name == name));
        }
        public List<Book> SearchBooks(string val)
        {
            List<Book> first = books.FindAll(x => x.Name.Contains(val));
            List<Book> second = books.FindAll(x => x.AuthorName.Contains(val));
            //List<Book> third = books.FindAll(x => x.PageCount == int.Parse(val));
            List<Book> result = new List<Book>();
            first.AddRange(second);
            //first.AddRange(third);
            result.AddRange(first);
            return result;
        }
        public List<Book> FindAllBooksByPageCountRange(int a, int b)
        {
            return books.FindAll(x => x.PageCount > a && x.PageCount < b);
        }
        public void RemoveBookByCode(string code)
        {
            books.Remove(books.Find(x => x.Code == code));
        }
    }
}
