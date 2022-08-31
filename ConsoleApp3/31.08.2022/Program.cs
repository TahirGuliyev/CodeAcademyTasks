using ConsoleApp3.Attributes;
using ConsoleApp3.Models;
using System.Reflection;

IEnumerable<string> ValidEmail<T>(T entity)
{
    List<string> emails = new List<string>();
    foreach (PropertyInfo info in entity.GetType().GetProperties())
    {
        bool result = Attribute.IsDefined(info, typeof(ValidEmail));
        if (result)
        {
            Console.WriteLine(info.GetValue());
        }
    }
    return default(IEnumerable<string>);
}

ValidEmail(new User("tahir@gmail.com"));