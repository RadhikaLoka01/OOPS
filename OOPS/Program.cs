using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Student
    {
        int sid = 101;
        string sname = "Radha";
        string scollege = "Prathibha";
        string saddress = "Hyd";

        internal void DisplaystudentData()
        {
            Console.WriteLine("Student id is {0}", sid);
            Console.WriteLine("Student name is {0}", sname);
            Console.WriteLine("Student college is {0}", scollege);
            Console.WriteLine("Student address is {0}", saddress);
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.DisplaystudentData();
            Console.ReadLine();
        }
    }
}


            
    
    
                


           
        
    


     

        
    

