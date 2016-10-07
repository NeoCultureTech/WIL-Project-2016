using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDLL.Students;
namespace MyDLL
{
    namespace Students
    {
    public class Student
        {
 
        private int Age;
        private string Name;
        public Student(int Age,string Name)
        {
            Age = 21;
            Name = "Kohl";
        }
            
            public string NameStud
            {
                get { return Name; }
                
            }

           

            public int AgeStud
            {
                get { return Age; }
                set { AgeStud = value; }

            }
         
        }

    }
   
}
