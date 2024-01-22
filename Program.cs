using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare vriables
            string name = "Mpumelelo";
            int age;
            //initialization
            name = "Mpumelelo";
            age = 25;

            //what will be seen on console
            Console.WriteLine("There was once a girl called "+ name);
            Console.WriteLine(name  + " was "  + age +  " of age ");
            Console.WriteLine(name  + " really never liked her name. ");

            //change variable values
            age = 10;
            name = "Lebo";

            Console.WriteLine("At age " + age + " she changed her name to " + name);

            //to freeze the console
            Console.ReadLine();

         

        }
    }
}
