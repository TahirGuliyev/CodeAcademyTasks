using ConsoleApp3.Attributes;
using ConsoleApp3.Models;
using ConsoleApp3.ValidatorServices;
using System.Reflection;

User user = new User()
{
    Email = "tahir@gmail.com",
    Password = "123ABC*"
};

ValidatorService<User> validationService = new ValidatorService<User>();
validationService.CheckAtribute(user, typeof(ValidEmail));
validationService.CheckAtribute(user, typeof(ValidPassword));