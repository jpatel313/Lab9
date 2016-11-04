using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double radius;

        #region Methods
        
        public double Radius
        {
            get
            { return radius; }

            set
            { radius = value; }
        }

        public Circle(double x)
        {
            //this.radius= radius; //alt way turns user input into local variable
            radius = x;
        }

        public double getCircumference()
        {
            double circumference = radius * (2 * Math.PI);
            return circumference;
        }

        public double getArea()
        {
            double area = (radius * radius)* Math.PI;
            return area;
        }

        private String formatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }

        public String getFormattedCircumference()
        {
          return  formatNumber(getCircumference());
        }

        public String getFormattedArea()
        {
            return formatNumber(getArea());
        }
        #endregion
    }
}
