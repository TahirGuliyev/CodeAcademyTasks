using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework
{
    public class Company
    {
        public string Name { get; set; }
        public static List<User> users = new List<User>();
        public delegate void UserDelegate(User user);
        public void CreateEmail(User user)
        {
            user.Email = user.Name + "." + user.Surname + "@gmail.com";
        }
        public void CreateUsername(User user)
        {
            user.Username = user.Name + "." + user.Surname;
        }
        public void Register(string name, string surname, string password) {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.Password = password;
            UserDelegate userDelegate = new UserDelegate(CreateEmail);
            userDelegate += CreateUsername;
            userDelegate.Invoke(user);
            Console.WriteLine("User elave olundu.");
        }
        public void GetAll()
        {
            foreach (var item in users)
            {
                Console.WriteLine(item.Id+" "+item.Name+" "+item.Surname+" "+item.Username);
            }
        }
        public void DeleteById(int id)
        {
            users.Remove(GetById(id));
        }
        public void UpdateteById(int id)
        {

        }

        public static User GetById(int id)
        {
            return users.Find(x => x.Id.Equals(id));
        }
        public static bool Login(string username, string password)
        {
            var usr = users.Find(x => x.Username.Equals(username));
            if (usr.Username == username&&usr.Password == password)
            {
                Console.WriteLine("Login olundu!");
                return true;
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz username ve ya password yanlisdir!");
                return false;
            }
        }
    }
}
