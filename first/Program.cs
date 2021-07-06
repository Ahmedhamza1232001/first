using System;
using System.Linq;
using System.Collections.Generic;

namespace first
{
    class  Program
    {
        

        static void Main(string[] args)
        {

            float points=0f;
            int totalHours=0;
            float gpapoint = 0f;
            for (int d = 0; d < 12; d+=5)
            {
                

            }
            

            for (int i = 0; i < 7; i++,gpapoint+=5) 

            {
                Console.WriteLine("enter your course's grade ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 60)
                {
                    gpapoint = 0;
                }

                Console.WriteLine("enter your course's grade ");
                
                Console.WriteLine("enter course's hours ");
                int hours = Convert.ToInt32(Console.ReadLine());
                
                points += grade * hours;
                totalHours += hours;



            }
            float gpa = points / totalHours;
            Console.WriteLine("your Gpa = {0}",gpa);
            
        }
    }
}
