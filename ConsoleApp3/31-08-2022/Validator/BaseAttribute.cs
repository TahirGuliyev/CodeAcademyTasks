using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Validator
{
    public class BaseAttribute : Attribute
    {
        private string _validMessage;
        public BaseAttribute() { }
        public BaseAttribute(string inValidMess) { this._validMessage = inValidMess; }
        public string ValidMessage { get { return _validMessage; } }
    }
    public class ValidMessage : BaseAttribute
    {
        public ValidMessage() { }
        public ValidMessage(string validMesage) : base(validMesage) { }
    }
}
