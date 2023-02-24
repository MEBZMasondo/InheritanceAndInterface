using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTN3SIOOPInheritance
{
    class Student:ISayHello, IComparable // Interfacing
    {
        private string studentName;
        private int studentAge;
        public double StudentAveMark { get; set; }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int StudentAge
        {
            get { return studentAge;}
            set
            {
                if (value >= 10 && value <= 80)
                    studentAge = value;
                else
                    studentAge = 0;
            }
        }
        public Student() // if the default simply assigns default values
        {
        }
        public Student(string sName)
        {
            studentName = sName;
        }
        public Student(int sAge)
        {
            studentAge = sAge;
        }

        public Student(double ave)
        {
            StudentAveMark = ave;
        }

        public Student(string sName, int sAge)
        {
            studentName = sName;
            studentAge = sAge;
        }
        public Student(string sName, int sAge, double ave)
        {
            studentName = sName;
            studentAge = sAge;
            StudentAveMark = ave;
        }

        public virtual string ShowStudent() // Method override
        {
            return StudentName + "\t" + studentAge + "\t" + GetPass();
        }
        public virtual string GetPass()
        {
            string pass = "";
            pass = StudentName.Substring(0, 3);
            pass += studentAge / 10 + studentAge % 10;
            return pass;
        }

        public void Greetings()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Hello");
        }

        /* CompareTo auto created by IDE
        public int CompareTo(object obj)
        {
            return studentAge.CompareTo(obj);
        }*/

        public int CompareTo(object obj) // using a generic object
        {
            Student temp = (Student)obj; // convert it to an actual 
            if (this.StudentAge > temp.StudentAge)
                return 1;
            else
                return -1; 
        }
    }
}
