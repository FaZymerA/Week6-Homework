using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GetMax
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third numbere");
            int num3=int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is: {0}",GetMax(num1,num2,num3));
        }
        static double GetMax(double num1 ,double num2,double num3)
        {
            double max1=num1>num2?num1: num2;
            return max1  >num3 ? max1 : num3;
        }
    }
}
