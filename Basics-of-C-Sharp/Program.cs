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
            //-----------------------------------------------//


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
            //-----------------------------------------------//



            //Getting User Input
            /*
            Console.Write("Enter Your Name: ");
            string Nm = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + Nm + " You are " + age + " Years Old.");
            */
            //-----------------------------------------------//



            //Building Basic Calculator
            /*
            Console.Write("Enter a Number 1: ");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition of "+ num1+" & "+num2+" is equals to " +(num1+num2));
           */
            //-----------------------------------------------//




            //Calling Methods
            //MethodOne();
            //MethodTwo("Saad");
            //-----------------------------------------------//

            //Return Statement
            /*
            int Square = SquareOfNumber(2);
            Console.WriteLine(SquareOfNumber(3));
            Console.WriteLine(Square);
            */
            //-----------------------------------------------//


            //Madlib Game
            /*
            string color, item, name;
            Console.Write("Enter Color : ");
            color= Console.ReadLine();
            Console.Write("Enter Item : ");
            item = Console.ReadLine();
            Console.Write("Enter Nmae : ");
            name = Console.ReadLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Roses are "+color);
            Console.WriteLine(item+" are blue");
            Console.WriteLine("I Love "+name);
            */
            //-----------------------------------------------//


            //Arrays
            /*
            int[] RandomNumbers = { 1, 99, 8, 10, 0 };
            string[] RandomNames = new string[3];
            RandomNames[0] = "Saad";
            RandomNames[1] = "Zubair";
            RandomNames[2] = "Arshad";
            Console.WriteLine(RandomNames[0]);
            Console.WriteLine(RandomNumbers[0]);
            //update array
            RandomNumbers[0] = 2;
            Console.WriteLine(RandomNumbers[0]);
            */
            Console.ReadLine();





        }

        //Methods
        static void MethodOne()
        {
            Console.WriteLine("Hi, This is Method One.");
        }

        //Parameterized Method
        static void MethodTwo(string Name)
        {
            Console.WriteLine("Hi "+Name+", This is Method Two.");
        }
        //--------------------------------------------------------//


        //Return Statements
        static int SquareOfNumber(int num)
        {
            int result = num * num;
            return result;
        }
    }
}
