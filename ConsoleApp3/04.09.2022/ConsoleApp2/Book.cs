using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Book
    {
        private string _name;
        private static int count = 1;
        public string AuthorName { get; set; }
        public string Name {
            get => _name; set
            {
                string codestr = value.Substring(0, 2);
                _name = value;
                Code = codestr + count++;
            } }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book()
        {

        }
    }
}
