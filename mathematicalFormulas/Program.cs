using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematicalFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int radiusInt;
            string userInput;
            Console.Write("Enter radius value:");
            userInput = Console.ReadLine();
            radiusInt = Convert.ToInt32(userInput);
            int J = 2;
            double Circumference = J * Math.PI * radiusInt;
            double Area = Math.PI*radiusInt*radiusInt;
            int L = 6;
            int M = 4;
            double VOH = (M*Math.PI*radiusInt*radiusInt*radiusInt) / L;
            Console.WriteLine("Circumference: {0}", Circumference);
            Console.WriteLine("Area: {0}", Area);
            Console.WriteLine("Volume Of Hemisphere: {0}", VOH);
            //// Area Of Triangle!!!!!!!!!!
            Console.WriteLine("Now lets find the area of your triangle with all sides greater then 0!!!");
            int sidea;
            string sideA;
            Console.Write("Enter side a:");
            sideA = Console.ReadLine();
            sidea = Convert.ToInt32(sideA);
            int sideb;
            string sideB;
            Console.Write("Enter side b:");
            sideB = Console.ReadLine();
            sideb = Convert.ToInt32(sideB);
            int sidec;
            string sideC;
            Console.Write("Enter side c:");
            sideC = Console.ReadLine();
            sidec = Convert.ToInt32(sideC);
            double p = (sidea + sideb + sidec) / J;
            double N = p * (p - sidea) * (p - sideb) * (p - sidec);
            double AOT = Math.Sqrt(N);
            Console.WriteLine("The area of your triangle is: {0}", AOT);
            //// Sloving quadratic equation!!!!!!
            Console.WriteLine("Now lets solve the quadratic equation for integers greater then or equal to 0!!!");
            int a;
            string A;
            Console.Write("Enter side a:");
            A = Console.ReadLine();
            a = Convert.ToInt32(A);
            int b;
            string B;
            Console.Write("Enter side b:");
            B = Console.ReadLine();
            b = Convert.ToInt32(B);
            int c;
            string C;
            Console.Write("Enter side c:");
            C = Console.ReadLine();
            c = Convert.ToInt32(C);
            double W;
            W = (b * b) - (4 * a * c);
            double x1;
            x1 = (-b + Math.Sqrt(W)) / (2 * a);
            double x2;
            x2 = (-b - Math.Sqrt(W)) / (2 * a);
            Console.WriteLine("x1 is: {0}", x1);
            Console.WriteLine("x2 is: {0}", x2);
        }
    }
}
