using System;

namespace DelegateHomework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = true;
            Console.WriteLine("Create a company:\nPlease enter company name");
            Company company = new Company();
            company.Name = Console.ReadLine();
            while (exit)
            {
                Console.WriteLine("Please enter number:");
                Console.WriteLine("1.Register a user(to company)\n" +
                    "2. Login in a user (to company)\n" +
                    "3. See all users in Company (GetAll)\n" +
                    "4. Get one User from Company (GetById)\n" +
                    "5. Update User's datas (UpdateById)\n" +
                    "6. Delete User from Company (DeleteById)\n" +
                    "7. Exit");
                int numb = int.Parse(Console.ReadLine());
                switch (numb)
                {
                    case 1:
                        string regName, regSurname, regPassword;
                        Console.WriteLine("Please enter name:");
                        regName = Console.ReadLine();
                        Console.WriteLine("Please enter surname:");
                        regSurname = Console.ReadLine();
                        Console.WriteLine("Please enter password");
                        regPassword = Console.ReadLine();
                        company.Register(regName, regSurname, regPassword);
                        break;
                    case 2:
                        Console.WriteLine("Login\nPlease enter username:");
                        string usrname = Console.ReadLine();
                        Console.WriteLine("Please enter password");
                        string password = Console.ReadLine();
                        Company.Login(usrname, password);
                        break;
                    case 3:
                        company.GetAll();
                        break;
                    case 4:
                        Console.WriteLine("Id daxil edin");
                        int id = int.Parse(Console.ReadLine());
                        Company.GetById(id);
                        break;
                    case 5:
                        Console.WriteLine("Id daxil edin");
                        int id2 = int.Parse(Console.ReadLine());
                        Company.UpdateById(id2);
                    case 6:
                        Console.WriteLine("Id daxil edin");
                        int id1 = int.Parse(Console.ReadLine());
                        company.DeleteById(id1);
                    case 7:
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a correct number!");
                        continue;
                }
            }
        }
    }
}