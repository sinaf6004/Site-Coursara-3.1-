using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_coursara_3._1
{
    class User
    {
        List<User> users = new List<User>();
        public enum MemberKind { Free, Premium, Special };
        string Name;
        string UserName;
        string Password;
        MemberKind memberKind;
        string Email;
        string Gender;
        string Country;
        List<string> Certificates = new List<string>();
        List<int> Courses = new List<int>();

        public void Edit()
        {
            string x;
            Console.Write("Name: ");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                Name = x;
            }

            Console.Write("UserName: ");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                UserName = x;
            }

            Console.Write("Password: ");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                Password = x;
            }
            Console.WriteLine("1.Free, 2.Premium, 3.Special");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                memberKind = (MemberKind)(int.Parse(x) - 1);
            }
            x = Console.ReadLine();
            Email = x;
            x = Console.ReadLine();
            Gender = x;
            x = Console.ReadLine();
            Country = x;



        }
    }
}
