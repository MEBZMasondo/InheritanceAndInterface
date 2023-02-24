using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTN3SIOOPInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Student ImStudent = new Student("ImStudent", 5, 67);
            System.Console.WriteLine("The Student's details are {0}", ImStudent.ShowStudent());
            */

            //Honours ImHons = new Honours();
            /*
            Honours ImHons = new Honours("ImHons", 23, 78, "A study of C# Programming with IS&T students");
            System.Console.WriteLine("The Student's details are {0}", ImHons.ShowStudent());
            */

            // Polymorphism
            /*
            Student ImStud = new Student("ImStudent", 5, 67);
            Honours ImHon = new Honours("ImHons", 23, 78, "A study of C# Programming with IS&T students");
            List<Student> students = new List<Student>();
            students.Add(ImStud);
            students.Add(ImHon);
            ShowAllStudents(students);
            */

            List<Student> students = new List<Student>();
            GetAllStudents(students);
            ShowAllStudents(students);

            // Sorting
            System.Console.WriteLine("==========THE SORTED VERSION==========");
            students.Sort();
            ShowAllStudents(students);
            Console.ReadLine();
        }

        public static void ShowAllStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                System.Console.WriteLine("The Student's details are {0}", student.ShowStudent());
            }
            Console.WriteLine("");
        }

        public static void GetAllStudents(List<Student> students)
        {
            Honours temp = new Honours();
            Console.Write("Enter Student Name - type DONE to stop : ");
            temp.StudentName = Console.ReadLine();
            while(temp.StudentName.ToUpper() != "DONE")
            {
                Console.Write("Enter Student Age :");
                temp.StudentAge = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Average Mark :");
                temp.StudentAveMark = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Student Dissertation title - Enter Blank if undergraduate :");
                temp.Diss_topic = Console.ReadLine();

                if (temp.Diss_topic.Trim().Length > 0)
                    students.Add(temp);
                else
                    students.Add(new Student(temp.StudentName, temp.StudentAge, temp.StudentAveMark));
                temp = new Honours();

                Console.Write("Enter Student Name - type DONE to stop : ");
                temp.StudentName = Console.ReadLine();
            }
            Console.WriteLine("");
        }

    }
}
