using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_coursara_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int t = 0;
                Console.WriteLine("1. User Sign Up\n2. User Login\n3. Admin Sign Up\n4. Admin Login\n5. Exit");
                int Choice = 0;
                try
                {
                 Choice= int.Parse(Console.ReadLine());
                }
                catch
                {
                }
                switch (Choice)
                {
                    case 1:
                        User user = new User();
                        user.UserPanel();
                        break;
                    case 2:
                        User.UserLogin();
                        break;
                    case 3:
                        Admin.AddAdmin();
                        break;
                    case 4:
                        Admin.AdminLogin();
                        break;

                    case 5:
                        t = 1;
                        break;
                    default:
                        Console.WriteLine("Please enter a number");
                        break;
                }
                if (t == 1)
                {
                    break;
                }
            }
        }
    }
}
