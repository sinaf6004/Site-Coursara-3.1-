using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_coursara_3._1
{
    class Admin
    {
        //optional
        string Name;
        string UserName;
        string Email;
        string Password;
        static List<Admin> admins = new List<Admin>();
        public static void AddAdmin()
        {
            Admin obj = new Admin();
            admins.Add(obj);
            string x;
            Console.Write("Name: ");
            x = Console.ReadLine();
            obj.Name = x;
            while (true)
            {
                Console.Write("UserName: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    obj.UserName = x;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Email: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    obj.Email = x;
                    break;
                }
            } while (true)
            {
                Console.Write("Password: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    obj.Password = x;
                    break;
                }
            }
        }
        public void Edit()
        {
            string x;
            Console.Write("Name: ");
            x = Console.ReadLine();
            Name = x;
            while (true)
            {
                Console.Write("UserName: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    UserName = x;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Email: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    Email = x;
                    break;
                }
            } while (true)
            {
                Console.Write("Password: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    Password = x;
                    break;
                }
            }

        }
        public static void AdminLogin()
        {
            Console.Write("UserName: ");
            string UserName = Console.ReadLine();
            int t = 0;
            foreach (var admin in admins)
            {
                if (admin.UserName == UserName)
                {
                    t = 1;
                    Console.Write("Password: ");
                    string Password = Console.ReadLine();
                    if (Password == admin.Password)
                    {
                        admin.AdminPanel();

                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                }
            }
            if (t == 0)
            {
                Console.WriteLine("Could not find such a username");
            }

        }
        public void AdminPanel()
        {
            while (true)
            {
                Console.WriteLine("1. AddAdmin\n2. Edit\n3. AddCourse\n4. RemoveCourse\n5. EditCourse\n6. AddInstructor\n7. RemoveInstructor\n8. ShowInfo\n9. AddUser\n10. RemoveUser\n11. Exit");
                int Choice = int.Parse(Console.ReadLine());
                int exit = 0;
                switch (Choice)
                {
                    case 1:
                        AddAdmin();
                        break;
                    case 2:
                        Edit();
                        break;
                    case 3:
                        Course.AddCourse();
                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Id: ");
                            try
                            {
                                int Id = int.Parse(Console.ReadLine());
                                Course.RemoveCourse(Id);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number");
                            }
                        }
                        break;
                    case 5:
                        while (true)
                        {
                            Console.Write("Id: ");
                            try
                            {
                                int Id = int.Parse(Console.ReadLine());
                                Course.EditCourse(Id);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number");
                            }
                        }

                        break;
                    case 6:
                        while (true)
                        {
                            Console.Write("Id: ");
                            try
                            {
                                int Id = int.Parse(Console.ReadLine());
                                Course.AddInstructor(Id);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number");
                            }
                        }
                        break;
                    case 7:
                        while (true)
                        {
                            Console.Write("Id: ");
                            try
                            {
                                int Id = int.Parse(Console.ReadLine());
                                Course.RemoveInstructor(Id);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number");
                            }
                        }
                        break;
                    case 8:
                        while (true)
                        {
                            Console.Write("Id: ");
                            try
                            {
                                int Id = int.Parse(Console.ReadLine());
                                Course.ShowInfo(Id);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Enter a number");
                            }
                        }
                        break;
                    case 9:
                        new User();
                        break;
                    case 10:
                        Console.Write("User Name: ");
                        string UserName = Console.ReadLine();
                        User.RemoveUser(UserName);
                        break;
                    case 11:
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("Enter a number");
                        break;
                }
                if (exit == 1)
                {
                    break;
                }
            }
        }

    }
}

