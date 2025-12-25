using System;

namespace BridgeLabzTraining.level2_c__methods_practices
{
    internal class Quadratic
    {
        public static void Main(string[] args)
        {
            // Taking user input for values a, b and c
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double c=Convert.ToDouble(Console.ReadLine());
            // Creating an object of the class to access the method
            Quadratic quadratic=new Quadratic();
            // Calling the method to find the roots of the quadratic equation
            double[] roots=quadratic.FindRoots(a,b,c);
            // Checking and displaying the roots based on the returned array
            if (roots.Length==2)
            {
                Console.WriteLine("Root 1="+roots[0]);
                Console.WriteLine("Root 2="+roots[1]);
            }
            else if (roots.Length==1)
            {
                Console.WriteLine("Only one root="+roots[0]);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }

        // Write a Method to find the roots of a quadratic equation and return the roots
        public double[] FindRoots(double a,double b,double c)
        {
            // Calculating delta using the formula delta = b^2 - 4*a*c
            double delta=Math.Pow(b,2)-(4*a*c);
            // If delta is positive, there are two real roots
            if (delta>0)
            {
                // Calculating square root of delta
                double sqrtDelta=Math.Sqrt(delta);
                // Calculating the two roots using the formula
                double root1=(-b+sqrtDelta)/(2 * a);
                double root2=(-b-sqrtDelta)/(2 * a);
                // Returning both roots in an array
                return new double[]{root1,root2};
            }
            // If delta is zero, there is only one real root
            else if (delta==0)
            {
                // Calculating the single root
                double root=-b/(2*a);
                // Returning the single root in an array
                return new double[]{root};
            }
            // If delta is negative, return an empty array (no real roots)
            return new double[0];
        }
    }
}
