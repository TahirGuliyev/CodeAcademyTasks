using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttributeS.CustomValidatorMethods
{
    public class CustomValidator
    {
        public static bool CheckEmail(string email)
        {
            Regex regex = new(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Match match = regex.Match(email);
            return match.Success;
        }

        public static bool CheckPassword(string email)
        {
            Regex regex = new(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
