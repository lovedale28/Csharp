using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionPayRate
{
    public class DecisionPayRate
    {
      public  static void Main(string[] args)
        {

            double Pay;

            Console.Out.Write("How many hours did you work last week?");

            string Hours = Console.ReadLine();

            double hours = Convert.ToDouble(Hours);

            Console.Out.WriteLine();

            Console.Out.Write("What is your hourly pay rate?");

            string Rate = Console.ReadLine();

            double rate = Convert.ToDouble(Rate);

            if (hours <= 40)
            {

                 Pay = hours * rate;
           
            }
            else {

                 Pay = hours * rate;

                 Pay = Pay + ((hours - 40) * (rate / 2.0));

                 Console.Out.WriteLine();

                 Console.Out.WriteLine("Your weekly pay is: " + Pay);

                 Console.Out.WriteLine();

                 Console.Out.WriteLine("Are you happy with your pay? Type (Y/N)");

                 string Answer = Console.ReadLine();

                 char answer = Convert.ToChar(Answer);

                 if (answer == 'Y')
                 {

                     Console.Out.WriteLine("I am glad that you are happy!");

                     Console.ReadLine();
                 }

                 else {

                     Console.Out.WriteLine("Maybe next week you can work more hours");

                     Console.ReadLine();
                 }

            
            }

        }
    }
}
