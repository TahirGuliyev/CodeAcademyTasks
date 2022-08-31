using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Attributes
{
    public class ValidEmail : Attribute
    {
        private string _email;
        public ValidEmail()
        {

        }
        public ValidEmail(string email)
        {
            _email = email;

        }
    }
}
