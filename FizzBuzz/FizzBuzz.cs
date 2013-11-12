using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
   public class FizzBuzz
    {

        private static int startVal = 1;
        private static int endVal = 20;

        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            for (int i = startVal; i <= endVal; i++)
            {
                output.Append(WorkOut(i) + ' ');
            }

           Console.WriteLine("{0}",output.ToString());
        }

        public static string WorkOut(int number)
        {
            bool number3 = ((number % 3) == 0);
            bool number5 = ((number % 5) == 0);
      
            if (number3 && number5)
            {
                return "fizzbuzz";
            }
            else if(number3)
            {
                return "fizz";
            }
            else if (number5)
            {
                return "buzz";
            }
           
            else
            {
                return number.ToString();
            }
            
        }
       
    }
}
