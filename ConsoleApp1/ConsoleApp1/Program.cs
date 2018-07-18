using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Console.Write("Type your last name:  ");
            string myLastName;
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + " nice to meet you!");
            Console.ReadLine();



        }
    }
}
