using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_coursara_3._1
{
    class User
    {
        static List<User> users = new List<User>();
        public enum MemberKind { Free, Premium, Special };
        public enum Gender { male, female }
        string Name;
        string UserName;
        string Password;
        MemberKind memberKind;
        string Email;//optional
        Gender gender;//optional
        string Country;//optional
        List<string> Certificates = new List<string>();
        List<int> Courses = new List<int>();

        public User()
        {
            string x;
            while (true)
            {
                Console.Write("Name: ");
                x = Console.ReadLine();
                if (x != "")
                {
                    Name = x;
                    break;
                }
            }
            while (true)
            {
                Console.Write("UserName: ");
                x = Console.ReadLine();
                if (x != "")
                {
                    UserName = x;
                    break;
                }
            }
            while (true)
            {
                Console.Write("Password: ");
                x = Console.ReadLine();
                if (x != "")
                {
                    Password = x;
                    break;
                }
            }
            memberKind = MemberKind.Free;
            Console.Write("Email: ");
            x = Console.ReadLine();
            Email = x;
            while (true)
            {
                Console.Write("Gender(1. male, 2.female): ");
                x = Console.ReadLine();
                if (x == "")
                {
                    break;
                }
                else
                {
                    try
                    {
                        if (((int.Parse(x) < 3) && (int.Parse(x) > 0)))
                        {
                            gender = (Gender)(int.Parse(x) - 1);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter a number betweem 1 and 2");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
            }
            Console.Write("Country: ");
            x = Console.ReadLine();
            Country = x;
            users.Add(this);
        }

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
            while (true)
            {
                Console.Write("UserName: ");
                x = Console.ReadLine();
                if (x == "")
                {

                }
                else
                {
                    int t = 0;
                    foreach (var user in users)
                    {
                        if (user.UserName == x)
                        {
                            t = 1;
                        }
                    }
                    if (t == 0)
                    {
                        UserName = x;
                        break;
                    }

                }
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
            Console.Write("Email: ");
            x = Console.ReadLine();
            Email = x;
            while (true)
            {
                Console.Write("Gender(1. male, 2.female): ");
                x = Console.ReadLine();
                try
                {
                    if (((int.Parse(x) < 3) && (int.Parse(x) > 0)))
                    {
                        gender = (Gender)(int.Parse(x) - 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a number betweem 1 and 2");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter a number");
                }
            }
            Console.Write("Country: ");
            x = Console.ReadLine();
            Country = x;
        }
        public void AddCourse(int course_id)
        {
            if (Course.courseExists(course_id))
            {
                int t = 0;
                foreach (var course in Courses)
                {
                    if (course == course_id)
                    {
                        t = 1;
                        break;
                    }
                }
                if (t == 0)
                {
                    if (Course.CourseType(course_id) == memberKind)
                    {
                        Courses.Add(course_id);
                    }
                    else
                    {
                        Console.WriteLine($"This cours is for {Course.CourseType(course_id).ToString()} users");
                    }
                }
                else
                {
                    Console.WriteLine("You have this course");
                }
            }
            else
            {
                Console.WriteLine("Could not find such a course");
            }

        }
        public void RemoveCourse(int course_id)
        {
            if (Course.courseExists(course_id))
            {
                Courses.Remove(course_id);
                Console.WriteLine("Successfully removed the course");
            }
            else
            {
                Console.WriteLine("Could not find this id");
            }
        }
        public void Promotion(int subscription)
        {
            if (subscription >= 80)
            {
                memberKind = MemberKind.Special;
            }
            else if (subscription >= 40)
            {
                memberKind = MemberKind.Premium;
            }
            else
            {
                Console.WriteLine("the subscription in not enough");
            }
        }
        public void FinishCourse(int course_id)
        {
            int t = 0;
            foreach (int course in Courses)
            {
                if (course == course_id)
                {
                    t = 1;
                    Courses.Remove(course);
                }
            }
            if (t == 1)
            {
                Console.WriteLine($"{Name} has successfully completed {Course.GiveLicense(course_id)} course");
            }
            else
            {
                Console.WriteLine("Could not find such an Id");
            }
        }

        public void UserPanel()
        {
            while (true)
            {
                int exit = 0;
                Console.WriteLine("1. Edit\n2. Add Course\n3. Remove Course\n4. promotion\n5. Show Info\n6. Exit");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Edit();
                        break;
                    case 2:
                        while (true)
                        {
                            Console.Write("Course Id: ");
                            try
                            {
                                int CourseId = int.Parse(Console.ReadLine());
                                AddCourse(CourseId);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please Enter a Number");
                            }

                        }
                        break;
                    case 3:
                        while (true)
                        {
                            Console.Write("Course Id: ");
                            try
                            {
                                int CourseId = int.Parse(Console.ReadLine());
                                RemoveCourse(CourseId);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please Enter a Number");
                            }
                        }

                        break;
                    case 4:
                        while (true)
                        {
                            Console.Write("Subscription: ");
                            try
                            {
                                int Subscription = int.Parse(Console.ReadLine());
                                Promotion(Subscription);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please Enter a Number");
                            }
                        }
                        break;
                    case 5:
                        while (true)
                        {
                            Console.Write("Course Id: ");
                            try
                            {
                                int CourseId = int.Parse(Console.ReadLine());
                                Course.ShowInfo(CourseId);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Please Enter a Number");
                            }
                        }


                        break;
                    case 6:
                        exit = 1;
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 6");
                        break;

                }
                if (exit == 1)
                {
                    break;
                }
            }
        }
        public static void UserLogin()
        {
            Console.Write("UserName: ");
            string UserName = Console.ReadLine();
            int t = 0;
            foreach (var user in users)
            {
                if (user.UserName == UserName)
                {
                    t = 1;
                    Console.Write("Password: ");
                    string Password = Console.ReadLine();
                    if (Password == user.Password)
                    {
                        user.UserPanel();
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
        public static void RemoveUser(string UserName)
        {
            int t = 0;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == UserName)
                {
                    users.RemoveAt(i);
                    t = 1;
                    Console.WriteLine("Successfully removed the user");
                }
            }
            if (t == 0)
            {
                Console.WriteLine("Could not find such a username");
            }
        }


    }
}
