using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTN3SIOOPInheritance
{
    class Honours : Student
    {
        public String Diss_topic { get; set; }

        public Honours() { }
        public Honours(String name, int age, double ave, string topic):base(name,age,ave)
        {
            // Then only handle the topic
            Diss_topic = topic;
        }

        // Method override
        public override string ShowStudent()
        {
            return base.ShowStudent() + "\t" + Diss_topic;
        }

        public override string GetPass()
        {
            //return base.GetPass();

            string pass = "";
            pass = StudentName.Substring(0, 2);
            pass += StudentAge / 10 * StudentAge % 10;
            return pass;
        }
    }
}
