using ConsoleApp3.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public class User
    {
        [StringLength(100)]
        public string Name { get; set; }
        [ValidEmail]
        public string Email { get; set; }
        [ValidEmail]
        public string Password { get; set; }
        public User(string email)
        {
            Email = email;
        }

        public User()
        {
        }
    }
}
