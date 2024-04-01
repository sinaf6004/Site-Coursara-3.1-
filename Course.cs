using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace site_coursara_3._1
{
    class Course
    {
        static List<Course> courses = new List<Course>();
        string Name;
        int Id;
        User.MemberKind CourseKind;
        List<string> Teachers = new List<string>();
        string University;





        //Methods
        public static void ShowInfo(int course_id)
        {
            foreach (Course course in courses)
            {
                if (course.Id == course_id)
                {
                    Console.Write($"Name: {course.Name}, Id: {course.Id}, Course kind: {course.CourseKind.ToString()},");
                    foreach (string teacher in course.Teachers)
                    {
                        Console.Write(teacher + " ");
                    }
                    Console.Write("," + course.University);
                    break;
                }
            }
        }
        public static void AddCourse()
        {
            Course obj = new Course();
            Console.Write("Name:");
            while (true)
            {
                string x = Console.ReadLine();
                if (x != "")
                {
                    obj.Name = x;
                    break;
                }
            }
            Console.Write("Id:");
            while (true)
            {
                string x = Console.ReadLine();
                if (x != "")
                {
                    try
                    {
                        obj.Id = int.Parse(x);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
            }
            Console.Write("Course kind(1. Free, 2. Premium, 3. Special):");
            while (true)
            {
                string x = Console.ReadLine();
                if (x != "")
                {
                    try
                    {
                        obj.CourseKind = (User.MemberKind)(int.Parse(x) - 1);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a number");
                    }
                }
            }
            Console.Write("Teachers:");
            while (true)
            {
                string x = Console.ReadLine();
                if (x != "")
                {

                    string[] Teachers = x.Split(' ');
                    foreach (string teacher in Teachers)
                    {
                        obj.Teachers.Add(teacher);
                    }

                }
            }
        }
        public void EditCourse()
        {
            string x;
            Console.Write("Enter Name:");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                Name = x;
            }

            Console.Write("Enter Course Kind(1. Free, 2. Premium, 3. Special): ");
            x = Console.ReadLine();
            if (x == "")
            {

            }
            else
            {
                try
                {
                    CourseKind = (User.MemberKind)(int.Parse(x));
                }
                catch
                {

                }
            }
        }
        public void AddInstructor()
        {
            Console.WriteLine("Enter the names: ");
            string x = Console.ReadLine();
            string[] teachers = x.Split(' ');
            foreach (string teacher in teachers)
            {
                int T = 0;
                foreach (string t in Teachers)
                {
                    if (t == teacher)
                    {
                        T = 1;
                    }
                }
                if (T == 0)
                {
                    Teachers.Add(teacher);
                }
            }
        }
        public void RemoveInstructor(string name)
        {
            if (Teachers.Count == 1)
            {
                Console.WriteLine("You can't delete this instructor from the list of instructos!");
            }
            else
            {
                int t = 0;
                for (int i = 0; i < Teachers.Count; i++)
                {
                    if (Teachers[i] == name)
                    {
                        Teachers.RemoveAt(i);
                        t = 1;
                    }
                }
                if (t == 0)
                {
                    Console.WriteLine("The name didn't founded");
                }
            }

        }
        public static bool courseExists(int course_id)
        {
            foreach (var course in courses)
            {
                if (course.Id == course_id)
                {
                    return true;
                }
            }
            return false;
        }
        public static User.MemberKind? CourseType(int course_id)
        {
            foreach (var course in courses)
            {
                if (course.Id == course_id)
                {
                    return course.CourseKind;
                }
            }
            return null;
        }
        public void RemoveCourse(int course_id)
        {
            int t = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                if(courses[i].Id == course_id)
                {
                    t = 1;
                    courses.RemoveAt(i);
                }
            }
            if(t == 1)
            {
                Console.WriteLine("Could not find this id");
            }
        }
    }
}
