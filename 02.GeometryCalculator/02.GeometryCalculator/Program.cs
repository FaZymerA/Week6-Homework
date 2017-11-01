using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        
              {
            Menu();
            Console.ReadKey(true);
        }
        static void Menu()
        {
            Console.WriteLine("choose option (triagle, square ot radians): ");
            Console.WriteLine("[T]riangle");
            Console.WriteLine("[S]quare");
            Console.WriteLine("[R]ardians");
            Console.WriteLine("[E]xit");
            Console.WriteLine("you options");
            string options = Console.ReadLine();
            switch (options)
            {
                case "T": Triangle();break;
                case "S": Square(); break;
                case "R": Radians(); break;
                case "E": Environment.Exit(0); break;
                default: Console.WriteLine("Thant's not an options");break ; 
            }
        }
         static void Triangle(){
             Console.Clear();
             Console.WriteLine("Triangle");
             Console.WriteLine("Enter side: ");
             double a = double.Parse(Console.ReadLine());
             Console.WriteLine("Enter hight: ");
             double h = double.Parse(Console.ReadLine());
             double s = a*h/2;
             Console.WriteLine("The area of triangle is {0:F2}", s);
         }
        static void Square(){
            Console.Clear();
            Console.WriteLine("Square");
            Console.WriteLine("Enter side: ");
            double a= double.Parse(Console.ReadLine());
            double s =a*a;
            Console.WriteLine("The area of Square is {0:F2}",s);

        }
        static void Radians()
        {
            Console.Clear();
            Console.WriteLine("Radians");
            Console.WriteLine("Enter the degrees you want to transform in radians: ");
            double b = double.Parse(Console.ReadLine());
            double rad = (Math.PI / 180) * b;
            Console.WriteLine("Your degrees in radians are{0} ", rad);

        }
    }
}
