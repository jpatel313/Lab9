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
            //get input
            Console.WriteLine("Welcome to the Circle Tester\n Enter radius: ");
            double x = double.Parse(Console.ReadLine());

            //create circle object
            Circle  userCircle = new Circle(x);
            
            //display circumference/area
            {
               return userCircle.getFormattedCircumference(x);
                return formatNumber(getCircumference(x));
                Console.WriteLine("\nCircumference: {0}\nArea:         {1}", formatNumber(getFormattedCircumference(x), return formatNumber(getArea(x)); ;
            }


        }



    }

}