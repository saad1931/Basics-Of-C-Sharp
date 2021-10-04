using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with string
            /*(Multi Line Comments)
            string Name = "Muhammad Saad";
            Console.WriteLine(Name);
            Console.WriteLine(Name.Length);
            Console.WriteLine(Name.ToUpper());
            Console.WriteLine(Name.ToLower());
            Console.WriteLine(Name.Contains("Saad"));
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name.IndexOf("Saad"));
            Console.WriteLine(Name.Substring(9));
            Console.WriteLine(Name.Substring(9,2));
            Console.ReadLine();
            */

            //working with numbers
            /*
            Console.WriteLine(10);
            Console.WriteLine(8 + 2);
            Console.WriteLine(8 + 2 * 2);
            Console.WriteLine(8 % 2);//Moodule
            Console.WriteLine(8 / 3.0);
            Console.WriteLine(Math.Abs(-3));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(3,99));
            Console.WriteLine(Math.Round(3.6));
            */

            //Getting User Input
            Console.Write("Enter Your Name: ");
            string Nm = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " +Nm+" You are "+age+ " Years Old.");


            //Building Basic Calculator
            Console.Write("Enter a Number 1: ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of "+ num1+" & "+num2+" is equals to " +(num1+num2));
            Console.ReadLine();







        }
    }
}
