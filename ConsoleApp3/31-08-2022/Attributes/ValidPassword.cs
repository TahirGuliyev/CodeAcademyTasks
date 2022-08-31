using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Attributes
{
    public class ValidPassword : Attribute
    {
        public string _password;

        public ValidPassword()
        {

        }

        public ValidPassword(string password)
        {
            _password = password;
        }
    }
}
