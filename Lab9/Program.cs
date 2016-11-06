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
            int counter = 0;
            string inputResponse = "y";
            while (inputResponse == "y")

            {   //Get input. Create object. Display Output
                Console.Write("\nEnter radius: ");
                double x = double.Parse(Console.ReadLine());
                Circle userCircle = new Circle(x);
                Console.Write("\nCircumference: {0}\n\nArea: {1}", userCircle.getFormattedArea(), userCircle.getFormattedCircumference());

                //Counts number of times user creates a circle object.
                ++counter;
                
                //Continue?
                Console.Write("\n\nContinue? (y/n): ");
                inputResponse = Console.ReadLine();
           
                    if (inputResponse == "y" || inputResponse == "Y")
                        //Continue allows user to skip past break.
                    {
                       
                        continue;
                    }

                    else if (inputResponse == "n" || inputResponse == "N")
                    {
                        
                        Console.WriteLine("\nGoodbye! You created {0} Circle object(s)", counter);
                        break;
                    }

                    else if (inputResponse != "y" || inputResponse != "Y" || inputResponse == "")
                    {
                        Console.WriteLine("You typed something other than y/n...");
                        Console.WriteLine("Goodbye! You created {0} Circle object(s)", counter);
                        break;
                    }
                    
                     break;
            } 
        }
    }
}