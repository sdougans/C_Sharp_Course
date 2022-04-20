using System;

namespace Exercise07
{
    class Rectangle
    {

        double length;
        double breadth;

        public Rectangle(double length, double breadth)
        {
            /*
             * this.length refers to the length variable that belongs to this class, i.e. on line 8
             * = length refers to the length tht is being passed in to the method
             * 
             * This is a unique way to have 2 variables that have the same name, and is usually only used in a constructor.
             * 
             */
            this.length = length;
            this.breadth = breadth;
        }

        public double CalculateArea()
        {
            return length * breadth;
        }

        public double CalculatePerimeter()
        {
            return (2 * length) + (2 * breadth);
        }

        public bool CheckSquare()
        {
            /*
             * The expression length == breadth will be evaluated to either true or false, and that true/false value will be returned.
             * 
             * This is shorthand for
             *  if(length==breadth{
             *      return true;
             *  }
             *  else{
             *      return false;
             *  }
             * 
             */
            return length == breadth;
        }
    }
}
