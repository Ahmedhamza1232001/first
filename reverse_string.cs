using System;
using System.Linq;
using System.Text;


namespace EdabitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123;
            StringBuilder s = new StringBuilder();
            s.Append("ashjx");
            Console.WriteLine(s);
            
            
            Console.WriteLine(reverse(x));
            


        }
        static string reverse(int i) 
        {
            
            string s = i.ToString();

            char[] car = s.ToCharArray();
            StringBuilder builder = new StringBuilder();
            for (int x = car.Length-1; x >-1; x--)
            {
                builder.Append(car[x]);
            }
            //add the int as a string in builder 
            builder.Append(s.ToString());

            s = builder.ToString();
            

            return s ;
            
            
        
        
        
        }

        



    }
}
