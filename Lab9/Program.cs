using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            string y = "y";

            while (y == "y")

            {   //Get input. Create object. Display Output
                Console.Write("\nEnter radius: ");
                double x = double.Parse(Console.ReadLine());
                Circle userCircle = new Circle(x);
                Console.Write("\nCircumference: {0}\n\nArea: {1}", userCircle.getFormattedArea(), userCircle.getFormattedCircumference());

                //Continue?
                Console.Write("\n\nContinue? (y/n): ");
                string inputResponse = Console.ReadLine();

                if (inputResponse == "y" || inputResponse == "Y")  
                {//continue allows user to skip past break 
                 continue;
                }

                else if (inputResponse == "n" || inputResponse == "N")
                { Console.WriteLine("\nGoodbye!"); }

                else if (inputResponse != "y" || inputResponse != "Y"||inputResponse == "")
                {
                Console.WriteLine("You typed something other than y/n");
                Console.WriteLine("\nGoodbye!");
                }
                //breaks out of program if anything other than y/Y 
                break;    y = "y";
            }
                //allows user to enter next radius
              
        }
    }
}